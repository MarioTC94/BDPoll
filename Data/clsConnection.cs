using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data {
    public class clsConnection {

        private SqlConnection oCN;

      public clsConnection() {

            SqlConnectionStringBuilder SQLSB = new SqlConnectionStringBuilder();
            SQLSB.DataSource = "ZERO-PC\\SQL2016";
            SQLSB.InitialCatalog = "DBPoll";
            SQLSB.IntegratedSecurity = true;

            oCN = new SqlConnection(SQLSB.ConnectionString);

        }

        private bool OpenConnection() {
            try {
                oCN.Open();
                return true;
            } catch (Exception ex){
                throw new Exception("No se puede abrir la conexión con la base de datos", ex);
            }
        }

        private bool CloseConnection() {
            try {
                if (oCN.State != System.Data.ConnectionState.Closed) {
                    oCN.Close();
                }
                return true;
            } catch (Exception  ex) {
                throw new Exception("No se puede cerrar la conexión con la base de datos", ex);
            }
        }
        private bool CMD(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                if (OpenConnection()) {
                    oSQLC.ExecuteNonQuery();
                    oCN.Close();
                    return true;
                }              
                oCN.Close();
                return false;
            } catch (Exception ex) {
                throw new Exception("No se pudo completar la solicitud", ex);
            }
        }
        private DataTable SelectData(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                DataTable oDT = new DataTable();
                SqlDataAdapter oSQLDA = new SqlDataAdapter(oSQLC);
                if (OpenConnection()) {
                    oSQLDA.Fill(oDT);
                }
                CloseConnection();
                return oDT;
            } catch (Exception ex) {
                throw new Exception("No se pudo obtener la información deseada", ex);
            }
        }
        
        private SqlDataReader SelectUniqueData(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                SqlDataReader OSQLR = null;
                if (OpenConnection()) {
                    OSQLR = oSQLC.ExecuteReader();
                    if (OSQLR.Read()) {
                        return OSQLR;
                    }
                }
                CloseConnection();
                return null;
            } catch (Exception ex) {
                throw new Exception("No se pudo recuperar la información deseada");
            }
        }
        
        private bool Exists(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                SqlDataReader OSQLR = null;
                if (OpenConnection()) {
                    OSQLR = oSQLC.ExecuteReader();
                }
                bool Exists = OSQLR.Read();
                CloseConnection();
                return Exists;
            } catch (Exception ex) {
                throw new Exception("No se pudo recuperar la información deseada");
            }
        }
  
    }
}

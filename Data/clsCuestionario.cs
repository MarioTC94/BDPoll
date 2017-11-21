using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data {
    public class clsCuestionario {

        public bool InsertarCuestionario(Model.Cuestionario oCuestionario) {
            clsConnection oConnection = new clsConnection();
            oConnection.OpenConnection();

            using( SqlTransaction oSQLTRAN = oConnection.GetTransaction() ) {
                try {
                    SqlCommand oSQLC = new SqlCommand();

                    oSQLC.Transaction = oSQLTRAN;
                    oSQLC.Connection = oConnection.oCN;

                    oSQLC.CommandText = "INSERT INTO dbo.Cuestionario(TipoCuestionario, IDUsuario, Titulo, Descripcion, FechaInicio, FechaFinal) VALUES (@TipoCuestionario, @IDUsuario, @Titulo, @Descripcion, @FechaInicio, @FechaFinal);";
                    oSQLC.Parameters.AddWithValue("@TipoCuestionario", oCuestionario.TipoCustionario);
                    oSQLC.Parameters.AddWithValue("@IDUsuario", oCuestionario.IDUsuario);
                    oSQLC.Parameters.AddWithValue("@Titulo", oCuestionario.Titulo);
                    oSQLC.Parameters.AddWithValue("@Descripcion", oCuestionario.IDUsuario);
                    oSQLC.Parameters.AddWithValue("@FechaInicio", oCuestionario.FechaInicio);
                    oSQLC.Parameters.AddWithValue("@FechaFinal", oCuestionario.FechaFinal);
                    oSQLC.ExecuteNonQuery();
                    oSQLC.Parameters.Clear();


                    //******************************************************************************************************************************************************/


                    SqlDataReader oSQLDA = oConnection.SelectUniqueData(new SqlCommand("SELECT IDENT_CURRENT('Cuestionario') AS IDCuestionario"));

                    if( oSQLDA == null ) { return false; }

                    int IDCuestionario = (int) oSQLDA["IDCuestionario"];

                    List<Model.Pregunta> ListPregunta = oCuestionario.Pregunta.ToList();
                    for( int i = 0; i < ListPregunta.Count; i++ ) {
                        oSQLC.CommandText = "INSERT INTO dbo.Pregunta(IDPregunta, IDTipoPregunta, IDCuestionario, DescripcionPregunta) VALUES (@IDPregunta, @IDTipoPregunta, @IDCuestionario, @DescripcionPregunta); ";
                        oSQLC.Parameters.AddWithValue("@IDPregunta", ( i + 1 ));
                        oSQLC.Parameters.AddWithValue("@IDTipoPregunta", ListPregunta[i].IDTipoPregunta);
                        oSQLC.Parameters.AddWithValue("@DescripcionPregunta", ListPregunta[i].DescripcionPregunta);
                        oSQLC.Parameters.AddWithValue("@IDCuestionario", IDCuestionario);
                        oConnection.CMD(oSQLC);
                        oSQLC.Parameters.Clear();

                        List<Model.Opciones> ListaOpciones = ListPregunta[i].Opciones.ToList();
                        for( int j = 0; j < ListPregunta.Count; j++ ) {
                            oSQLC.CommandText += "INSERT INTO dbo.Opciones(IDOpcion, IDCuestionario, IDPregunta, DescripcionOpcion) VALUES(@IDOpcion, @IDCuestionario, @IDPregunta, @DescripcionOpcion)";
                            oSQLC.Parameters.AddWithValue("@IDOpcion", ( j + 1 ));
                            oSQLC.Parameters.AddWithValue("IDCuestionario", IDCuestionario);
                            oSQLC.Parameters.AddWithValue("IDPregunta", ( i + 1 ));
                            oSQLC.Parameters.AddWithValue("DescripcionOpcion", ListaOpciones[j].DescripcionOpcion);
                            oConnection.CMD(oSQLC);
                            oSQLC.Parameters.Clear();
                        }
                    }

                    oSQLTRAN.Commit();
                    oConnection.oCN.Close();
                    return true;
                }
                catch( Exception ex ) {
                    oSQLTRAN.Rollback();
                    oConnection.oCN.Close();
                    throw new Exception("Error al insertar cuestionario", ex);
                }
            }
        }

        public DataTable CuestionariosParaContestar(String UsuarioLogueado, DateTime FechaActual) {
            SqlCommand oSQLC = new SqlCommand("SELECT IDCuestionario, Titulo, Descripcion, FechaInicio, FechaFinal, IDUsuario FROM dbo.Cuestionario WHERE Activo = 1 AND IDUsuario != @Usuario AND FechaFinal >= @FechaActual");
            oSQLC.Parameters.AddWithValue("@Usuario", UsuarioLogueado);
            return new clsConnection().SelectData(oSQLC);
        }

        public DataTable MisCuestionarios(String UsuarioLogueado) {
            SqlCommand oSQLC = new SqlCommand("SELECT IDCuestionario, Titulo, Descripcion, FechaInicio, FechaFinal FROM dbo.Cuestionario WHERE Activo = 1 AND IDUsuario = @Usuario ");
            oSQLC.Parameters.AddWithValue("@Usuario", UsuarioLogueado);
            return new clsConnection().SelectData(oSQLC);
        }

        public DataTable PreguntasDeCuestionario(int IDCuestionario) {
            SqlCommand oSQLC = new SqlCommand("SELECT b.IDPregunta, a.IDTipoPregunta, a.DescripcionTipoPregunta FROM dbo.Pregunta a JOIN dbo.TipoPregunta a ON a.IDTipoPregunta = b.IDTipoPregunta a.Activo = 1 AND a.IDCuestionario = @IDCuestionario");
            oSQLC.Parameters.AddWithValue("@IDCuestionario", IDCuestionario);
            return new clsConnection().SelectData(oSQLC);
        }

        public DataTable OpcionesDePregunta(int IDCuestionario, String IDPregunta) {
            SqlCommand oSQLC = new SqlCommand("SELECT IDOpcion, DescripcionOpcion FROM dbo.Opciones WHERE IDCuestionario = @IDCuestionario AND Activo = 1 AND IDPregunta = @IDPregunta");
            oSQLC.Parameters.AddWithValue("@IDCuestionario", IDCuestionario);
            oSQLC.Parameters.AddWithValue("@IDPregunta", IDPregunta);
            return new clsConnection().SelectData(oSQLC);
        }
    }
}

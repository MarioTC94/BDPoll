using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data {
    public class clsCuestionario {

        public bool InsertarCuestionario(List<Model.Cuestionario> oListCuestionario) {
            clsConnection oConnection = new clsConnection();
            oConnection.OpenConnection();

            using( SqlTransaction oSQLTRAN = oConnection.GetTransaction() ) {
                try {
                    SqlCommand oSQLC = new SqlCommand("");

                    oSQLC.Connection = oConnection.oCN;
                    oSQLC.Transaction = oSQLTRAN;

                    foreach( var oCuestionario in oListCuestionario ) {
                        oSQLC.CommandText = "INSERT INTO dbo.Cuestionario(TipoCuestionario, IDUsuario, Titulo, Descripcion, FechaInicio, FechaFinal) VALUES (@TipoCuestionario, @IDUsuario, @Titulo, @Descripcion, @FechaInicio, @FechaFinal); ";
                        oSQLC.Parameters.AddWithValue("@TipoCuestionario", oCuestionario.TipoCustionario);
                        oSQLC.Parameters.AddWithValue("@IDUsuario", oCuestionario.IDUsuario);
                        oSQLC.Parameters.AddWithValue("@Titulo", oCuestionario.Titulo);
                        oSQLC.Parameters.AddWithValue("@Descripcion", oCuestionario.Descripcion);
                        oSQLC.Parameters.AddWithValue("@FechaInicio", oCuestionario.FechaInicio);
                        oSQLC.Parameters.AddWithValue("@FechaFinal", oCuestionario.FechaFinal);
                        oSQLC.ExecuteNonQuery();
                        oSQLC.Parameters.Clear();


                        //******************************************************************************************************************************************************/

                        List<Model.Pregunta> ListPregunta = oCuestionario.Pregunta.ToList();
                        for( 
                            
                            
                            int i = 0; i < ListPregunta.Count; i++ ) {
                            oSQLC.CommandText = "INSERT INTO dbo.Pregunta(IDPregunta, IDTipoPregunta, IDCuestionario, DescripcionPregunta) VALUES (@IDPregunta, @IDTipoPregunta, @@IDENTITY, @DescripcionPregunta); ";
                            oSQLC.Parameters.AddWithValue("@IDPregunta", ( i + 1 ));
                            oSQLC.Parameters.AddWithValue("@IDTipoPregunta", ListPregunta[i].IDTipoPregunta);
                            oSQLC.Parameters.AddWithValue("@DescripcionPregunta", ListPregunta[i].DescripcionPregunta);
                            oSQLC.ExecuteNonQuery();
                            oSQLC.Parameters.Clear();

                            List<Model.Opciones> ListaOpciones = ListPregunta[i].Opciones.ToList();
                            for( int j = 0; j < ListaOpciones.Count; j++ ) {
                                oSQLC.CommandText = "INSERT INTO dbo.Opciones(IDOpcion, IDCuestionario, IDPregunta, DescripcionOpcion) VALUES(@IDOpcion, @@IDENTITY, @IDPregunta, @DescripcionOpcion); ";
                                oSQLC.Parameters.AddWithValue("@IDOpcion", ( j + 1 ));
                                oSQLC.Parameters.AddWithValue("@IDPregunta", ( i + 1 ));
                                oSQLC.Parameters.AddWithValue("@DescripcionOpcion", ListaOpciones[j].DescripcionOpcion);
                                oSQLC.ExecuteNonQuery();
                                oSQLC.Parameters.Clear();
                            }
                        }
                    }

                    oSQLTRAN.Commit();
                    oConnection.oCN.Close();
                    return true;
                }
                catch( Exception ex ) {
                    oSQLTRAN.Rollback();
                    oConnection.oCN.Close();
                    throw new Exception("Error al insertar cuestionarios", ex);
                }
            }
        }

        public DataTable CuestionariosParaContestar(String UsuarioLogueado, DateTime FechaActual) {
            SqlCommand oSQLC = new SqlCommand(@"SELECT 
	                                                a.IDCuestionario,
	                                                b.IDPregunta,
                                                    c.IDOpcion,
	                                                a.Titulo, 
	                                                a.Descripcion,
	                                                a.FechaInicio,
	                                                a.FechaFinal,
	                                                b.DescripcionPregunta, 
	                                                d.DescripcionTipoPregunta,
	                                                c.DescripcionOpcion
                                                FROM Cuestionario A 
                                                JOIN Pregunta B ON A.IDCuestionario  = B.IDCuestionario 
                                                LEFT JOIN Opciones C ON B.IDCuestionario = C.IDCuestionario AND B.IDPregunta = C.IDPregunta
                                                JOIN TipoPregunta D ON D.IDTipoPregunta = B.IDTipoPregunta
                                                WHERE a.IDUsuario <> @Usuario AND (a.FechaFinal > GETDATE());");

            oSQLC.Parameters.AddWithValue("@Usuario", UsuarioLogueado);
            return new clsConnection().SelectData(oSQLC);
        }

        public DataTable MisCuestionarios(String UsuarioLogueado) {
            SqlCommand oSQLC = new SqlCommand(@"SELECT
                                                a.IDCuestionario,
                                                b.IDPregunta,
                                                c.IDOpcion,
                                                a.Titulo,
                                                a.Descripcion,
                                                a.FechaInicio,
                                                a.FechaFinal,
                                                b.DescripcionPregunta,
                                                d.IDTipoPregunta,
                                                c.DescripcionOpcion
                                            FROM Cuestionario A
                                            JOIN Pregunta B ON A.IDCuestionario = B.IDCuestionario
                                            LEFT JOIN Opciones C ON B.IDCuestionario = C.IDCuestionario AND B.IDPregunta = C.IDPregunta
                                            JOIN TipoPregunta D ON D.IDTipoPregunta = B.IDTipoPregunta
                                            WHERE a.IDUsuario = @Usuario;");

            oSQLC.Parameters.AddWithValue("@Usuario", UsuarioLogueado);
            return new clsConnection().SelectData(oSQLC);
        }

        public DataTable PreguntasDeCuestionario(int IDCuestionario) {
            SqlCommand oSQLC = new SqlCommand("SELECT b.IDPregunta, a.DescripcionTipoPregunta, b.DescripcionPregunta FROM dbo.Pregunta a JOIN dbo.TipoPregunta a ON a.IDTipoPregunta = b.IDTipoPregunta a.Activo = 1 AND a.IDCuestionario = @IDCuestionario; ");
            oSQLC.Parameters.AddWithValue("@IDCuestionario", IDCuestionario);
            return new clsConnection().SelectData(oSQLC);
        }

        public DataTable OpcionesDePregunta(int IDCuestionario, int IDPregunta) {
            SqlCommand oSQLC = new SqlCommand("SELECT IDOpcion, DescripcionOpcion FROM dbo.Opciones WHERE IDCuestionario = @IDCuestionario AND Activo = 1 AND IDPregunta = @IDPregunta");
            oSQLC.Parameters.AddWithValue("@IDCuestionario", IDCuestionario);
            oSQLC.Parameters.AddWithValue("@IDPregunta", IDPregunta);
            return new clsConnection().SelectData(oSQLC);
        }

    }
}

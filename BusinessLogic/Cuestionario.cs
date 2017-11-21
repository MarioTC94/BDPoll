using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BusinessLogic {
    public class Cuestionario {

        public Task<bool> InsertarCuestionario(Model.Cuestionario oCuestionario) {

            return Task.Run(() => {

                if( String.IsNullOrEmpty(oCuestionario.Titulo) )
                    throw new ArgumentNullException("Titulo", "Por favor ingrese el título del cuestionario");
                if( String.IsNullOrEmpty(oCuestionario.Descripcion) )
                    throw new ArgumentNullException("Descripcion", "Por favor ingrese la descripción del cuestionario");

                foreach( Model.Pregunta oPregunta in oCuestionario.Pregunta ) {
                    if( String.IsNullOrEmpty(oPregunta.DescripcionPregunta) )
                        throw new ArgumentNullException("DescripcionPregunta", "La pregunta no puede estar vacía");

                    foreach( Model.Opciones oOpcion in oPregunta.Opciones ) {
                        if( String.IsNullOrEmpty(oOpcion.DescripcionOpcion) )
                            throw new ArgumentNullException("DescripcionPregunta", "Escriba una opción correcta");
                    }

                }

                return new Data.clsCuestionario().InsertarCuestionario(oCuestionario);

            });


        }

        public Task<DataTable> CuestionarioParaContestar() {

            return Task.Run(() => {
                DataTable dtCuestionario = new Data.clsCuestionario().CuestionariosParaContestar(Credenciales.Usuario.NombreUsuario, DateTime.Now);
                List<Model.Cuestionario> ListCuestionarios = new List<Model.Cuestionario>();

                foreach( DataRow RowCuestionario in dtCuestionario.Rows ) {//IDCuestionario, Titulo, Descripcion, FechaInicio, FechaFinal, IDUsuario
                    Model.Cuestionario oCuestionario = new Model.Cuestionario();
                    oCuestionario.IDCuestionario = (int)RowCuestionario["IDCuestionario"];
                    oCuestionario.Titulo = (String) RowCuestionario["Titulo"];
                    oCuestionario.Descripcion = (String)RowCuestionario["Descripcion"];
                    oCuestionario.FechaInicio = (DateTime)RowCuestionario["FechaInicio"];
                    oCuestionario.FechaFinal = (DateTime) RowCuestionario["FechaFinal"];
                    oCuestionario.IDUsuario = (String) RowCuestionario["IDUsuario"];

                    DataTable dtPregunta = new Data.clsCuestionario().PreguntasDeCuestionario(oCuestionario.IDCuestionario);
                }


                return new DataTable();
            });
        }

        public Task<DataTable> MisCuestionarios() {

            return Task.Run(() => {

                return new Data.clsCuestionario().MisCuestionarios(Credenciales.Usuario.NombreUsuario);
            });
        }




    }
}

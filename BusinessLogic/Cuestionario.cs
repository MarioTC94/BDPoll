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

                if (String.IsNullOrEmpty(oCuestionario.Titulo)) throw new ArgumentNullException("Titulo", "Por favor ingrese el título del cuestionario");
                if (String.IsNullOrEmpty(oCuestionario.Descripcion)) throw new ArgumentNullException("Descripcion", "Por favor ingrese la descripción del cuestionario");

                foreach (Model.Pregunta oPregunta in oCuestionario.Pregunta) {
                    if (String.IsNullOrEmpty(oPregunta.DescripcionPregunta)) throw new ArgumentNullException("DescripcionPregunta", "La pregunta no puede estar vacía");

                    foreach (Model.Opciones oOpcion in oPregunta.Opciones) {
                        if (String.IsNullOrEmpty(oOpcion.DescripcionOpcion)) throw new ArgumentNullException("DescripcionPregunta", "Escriba una opción correcta");
                    }

                }

                return new Data.clsCuestionario().InsertarCuestionario(oCuestionario);

            });


        }

        public Task<DataTable> CuestionarioParaContestar() {

            return Task.Run(() => {
                DataTable oCuestionario = new Data.clsCuestionario().CuestionariosParaContestar(Credenciales.Usuario.NombreUsuario, DateTime.Now);
                DataTable oPreguntas = null;
                DataTable oOpciones= null;
                List<String> ListaIDCuestionarios = oCuestionario.AsEnumerable().Select(x => x["IDCuestionario"].ToString()).ToList();
                List<Model.Cuestionario> ListCuestionarios = new List<Model.Cuestionario>();

                foreach (var ocuestionario in ListaIDCuestionarios) {
                    oPreguntas = new Data.clsCuestionario().PreguntasDeCuestionario(ocuestionario);
                    var rowCuestionario = oCuestionario.Rows.OfType<DataRow>();
                    List<String> ListaIDPreguntas = oPreguntas.AsEnumerable().Select(x => x["IDPregunta"].ToString()).ToList();
                    foreach (var oPregunta in ListaIDPreguntas) {
                        oOpciones = new Data.clsCuestionario().OpcionesDePregunta(ocuestionario, oPregunta);
                        List<String> ListaIDOpciones = oPreguntas.AsEnumerable().Select(x => x["IDOpcion"].ToString()).ToList();
                        Model.Cuestionario var = new Model.Cuestionario() {
                            Descripcion = (String) rowCuestionario["Descripcion"],
                            FechaFinal = (DateTime) rowCuestionario["FechaFinal"],
                            FechaInicio = (DateTime) rowCuestionario["FechaInicio"],
                            IDCuestionario = (int) rowCuestionario["IDCuestionario"],
                            IDUsuario = (String) rowCuestionario["IDUsuario"]
                            

                    }
                }

                foreach (DataRow rowCuestionario in oCuestionario.Rows) {


                    foreach (DataRow rowPreguntas in oPreguntas.Rows) {
                        Model.Pregunta pre = new Model.Pregunta() {
                           
                        }

                    }
                }


                return oCuestionario;
            });
        }

        public Task<DataTable> MisCuestionarios() {

            return Task.Run(() => {

                return new Data.clsCuestionario().MisCuestionarios(Credenciales.Usuario.NombreUsuario);
            });
        }




    }
}

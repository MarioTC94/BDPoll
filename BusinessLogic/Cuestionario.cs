﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BusinessLogic {
    public class Cuestionario {

        public Task<bool> InsertarCuestionario(Model.Cuestionario oCuestionario) {

            return Task.Run(() => {

                if( String.IsNullOrEmpty(oCuestionario.Titulo) )throw new ArgumentNullException("Titulo", "Por favor ingrese el título del cuestionario");
                if( String.IsNullOrEmpty(oCuestionario.Descripcion) )throw new ArgumentNullException("Descripcion", "Por favor ingrese la descripción del cuestionario");

                foreach( Model.Pregunta oPregunta in oCuestionario.Pregunta ) {
                    if( String.IsNullOrEmpty(oPregunta.DescripcionPregunta) )  throw new ArgumentNullException("DescripcionPregunta", "La pregunta no puede estar vacía");

                    foreach( Model.Opciones oOpcion in oPregunta.Opciones ) {
                        if( String.IsNullOrEmpty(oOpcion.DescripcionOpcion) )throw new ArgumentNullException("DescripcionPregunta", "Escriba una opción correcta");
                    }
                }
                return new Data.clsCuestionario().InsertarCuestionario(oCuestionario);
            });
        }

        public Task<List<Model.Cuestionario>> CuestionarioParaContestar() {
            return Task.Run(() => {
                return getListCustionarios(new Data.clsCuestionario().CuestionariosParaContestar(Credenciales.Usuario.NombreUsuario, DateTime.Now));
            });
        }

        public Task<List<Model.Cuestionario>> MisCuestionarios() {
            return Task.Run(() => {
                return getListCustionarios(new Data.clsCuestionario().MisCuestionarios(Credenciales.Usuario.NombreUsuario));
            });
        }


        private List<Model.Cuestionario> getListCustionarios(DataTable dtCuestionarios) {
            List<Model.Cuestionario> ListCuestionarios = new List<Model.Cuestionario>();

            foreach( DataRow RowCuestionario in dtCuestionarios.Rows ) {//IDCuestionario, Titulo, Descripcion, FechaInicio, FechaFinal, IDUsuario
                Model.Cuestionario oCuestionario = new Model.Cuestionario() {
                    IDCuestionario = (int) RowCuestionario["IDCuestionario"],
                    Titulo = (String) RowCuestionario["Titulo"],
                    Descripcion = (String) RowCuestionario["Descripcion"],
                    FechaInicio = (DateTime) RowCuestionario["FechaInicio"],
                    FechaFinal = (DateTime) RowCuestionario["FechaFinal"],
                    IDUsuario = (String) RowCuestionario["IDUsuario"]
                };

                DataTable dtPreguntas = new Data.clsCuestionario().PreguntasDeCuestionario(oCuestionario.IDCuestionario);

                foreach( DataRow RowPregunta in dtPreguntas.Rows ) {
                    Model.Pregunta oPregunta = new Model.Pregunta() {
                        IDCuestionario = oCuestionario.IDCuestionario,
                        IDPregunta = (int) RowCuestionario["IDPregunta"],
                        DescripcionPregunta = (String) RowCuestionario["DescripcionPregunta"],
                        IDTipoPregunta = (int) RowCuestionario["IDTipoPregunta"],
                        TipoPregunta = new Model.TipoPregunta() { DescripcionTipoPregunta = (String) RowCuestionario["IDTipoPregunta"], IDTipoPregunta = (int) RowCuestionario["IDTipoPregunta"] },
                    };

                    DataTable dtOpciones = new Data.clsCuestionario().OpcionesDePregunta(oCuestionario.IDCuestionario, oPregunta.IDPregunta);
                    foreach( DataRow RowOpciones in dtOpciones.Rows ) {
                        Model.Opciones oOpciones = new Model.Opciones() {//IDOpcion, DescripcionOpcion
                            IDCuestionario = oCuestionario.IDCuestionario,
                            IDPregunta = oPregunta.IDPregunta,
                            IDOpcion = (int) RowCuestionario["IDOpcion"],
                            DescripcionOpcion = (String) RowCuestionario["DescripcionOpcion"]
                        };
                    }
                }

                ListCuestionarios.Add(oCuestionario);
            }
            return ListCuestionarios;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}

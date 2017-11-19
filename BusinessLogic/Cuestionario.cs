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
                    
                }
                

                return new Data.clsCuestionario().InsertarCuestionario(oCuestionario);

            });
            
          
        }
    }
}

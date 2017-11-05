using System;
using System.Collections.Generic;

namespace Model{   
    
    public class RespuestaVerdaderoFalso{

        public string IDPersona { get; set; }
        public int IDPregunta { get; set; }
        public int IDCuestionario { get; set; }
        public bool Opcion { get; set; }
        public bool Activo { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Pregunta Pregunta { get; set; }
    }
}

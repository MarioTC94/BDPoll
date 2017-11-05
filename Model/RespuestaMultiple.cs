using System;
using System.Collections.Generic;

namespace Model{
    
    public class RespuestaMultiple{

        public string IDPersona { get; set; }
        public int IDPregunta { get; set; }
        public int IDCuestionario { get; set; }
        public int IDOpcion { get; set; }
        public bool Activo { get; set; }
    
        public virtual Opciones Opciones { get; set; }
        public virtual Persona Persona { get; set; }
    }
}

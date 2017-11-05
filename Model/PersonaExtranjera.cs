using System;
using System.Collections.Generic;

namespace Model{
     
    public class PersonaExtranjera{
        public string IDPersonaExtranjera { get; set; }
        public int IDGenero { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
    
        public virtual Genero Genero { get; set; }
        public virtual Persona Persona { get; set; }
    }
}

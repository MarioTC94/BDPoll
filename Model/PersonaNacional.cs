using System;
using System.Collections.Generic;

namespace Model{
   
    public class PersonaNacional{

        public string IDPersonaNacional { get; set; }
        public int IDGenero { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
    
        public virtual Genero Genero { get; set; }
        public virtual Persona Persona { get; set; }
    }
}

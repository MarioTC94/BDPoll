using System;
using System.Collections.Generic;

namespace Model{
   
    public class Genero{

        public Genero(){
            this.PersonaExtranjera = new HashSet<PersonaExtranjera>();
            this.PersonaNacional = new HashSet<PersonaNacional>();
        }
    
        public int IDGenero { get; set; }
        public string DescripcionGenero { get; set; }
        public bool Activo { get; set; }
    
        
        public virtual ICollection<PersonaExtranjera> PersonaExtranjera { get; set; }
        public virtual ICollection<PersonaNacional> PersonaNacional { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Model{
       
    public class TipoPersona{
       
        public TipoPersona(){
            this.Persona = new HashSet<Persona>();
        }
    
        public int IDTipoPersona { get; set; }
        public string DescripcionTipoPersona { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}

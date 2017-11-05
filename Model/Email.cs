using System;
using System.Collections.Generic;

namespace Model{
      
    public class Email{

        public int IDEmail { get; set; }
        public string IDPersona { get; set; }
        public byte IDTipoEmail { get; set; }
        public string NombreEmail { get; set; }
        public bool Activo { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual TipoEmail TipoEmail { get; set; }
    }
}

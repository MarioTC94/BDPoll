using System;
using System.Collections.Generic;

namespace Model{
    
    public class Telefono{

        public int IDTelefono { get; set; }
        public string IDPersona { get; set; }
        public byte IDTipoTelefono { get; set; }
        public bool Activo { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual TipoEmail TipoEmail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Model{
  
    public class TipoEmail{
        
        public TipoEmail(){
            this.Email = new HashSet<Email>();
            this.Telefono = new HashSet<Telefono>();
        }
    
        public byte IDTipoEmail { get; set; }
        public string DescripcionTipoEmail { get; set; }
        public bool Activo { get; set; }
 
        public virtual ICollection<Email> Email { get; set; }
        public virtual ICollection<Telefono> Telefono { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Model{
      
    public class TipoDireccion{
   
        public TipoDireccion(){
            this.Direccion = new HashSet<Direccion>();
        }
    
        public byte IDTipoDireccion { get; set; }
        public string DescripcionTipoDireccion { get; set; }
        public bool Activo { get; set; }
    
        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}

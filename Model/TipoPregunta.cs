using System;
using System.Collections.Generic;

namespace Model{
     
    public partial class TipoPregunta{
 
        public TipoPregunta(){
            this.Pregunta = new HashSet<Pregunta>();
        }
    
        public int IDTipoPregunta { get; set; }
        public string DescripcionTipoPregunta { get; set; }
        public bool Activo { get; set; }
    
        public virtual ICollection<Pregunta> Pregunta { get; set; }
    }
}

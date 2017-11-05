using System;
using System.Collections.Generic;

namespace Model{
        
    public class TipoCuestionario{
 
        public TipoCuestionario(){
            this.Cuestionario = new HashSet<Cuestionario>();
        }
    
        public int IDTipoCuestionario { get; set; }
        public string NombreTipoCustionario { get; set; }
        public bool Activo { get; set; }
    
        public virtual ICollection<Cuestionario> Cuestionario { get; set; }
    }
}

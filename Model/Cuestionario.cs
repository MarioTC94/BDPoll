using System;
using System.Collections.Generic;

namespace Model{
     
    public class Cuestionario{
       
        public Cuestionario(){
            this.Pregunta = new HashSet<Pregunta>();
        }
    
        public int IDCuestionario { get; set; }
        public int TipoCustionario { get; set; }
        public String IDUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        
    
        public virtual Detalle Detalle { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }
        public virtual TipoCuestionario TipoCuestionario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

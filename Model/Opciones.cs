using System;
using System.Collections.Generic;

namespace Model{
      
    public class Opciones{
        
        public Opciones(){
            this.RespuestaMultiple = new HashSet<RespuestaMultiple>();
            this.RespuestaSelecUnica = new HashSet<RespuestaSelecUnica>();
        }
    
        public int IDOpcion { get; set; }
        public int IDCuestionario { get; set; }
        public int IDPregunta { get; set; }
        public string DescripcionOpcion { get; set; }
        public bool Activo { get; set; }
    
        public virtual ICollection<RespuestaMultiple> RespuestaMultiple { get; set; }
        public virtual ICollection<RespuestaSelecUnica> RespuestaSelecUnica { get; set; }
        public virtual Pregunta Pregunta { get; set; }
    }
}

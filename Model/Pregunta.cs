using System;
using System.Collections.Generic;

namespace Model{
    
    public class Pregunta{

        public Pregunta(){
            this.Opciones = new HashSet<Opciones>();
            this.RespuestaVerdaderoFalso = new HashSet<RespuestaVerdaderoFalso>();
        }
    
        public int IDPregunta { get; set; }
        public int IDTipoPregunta { get; set; }
        public int IDCuestionario { get; set; }
        public bool Activo { get; set; }
        public String DescripcionPregunta { get; set; }

        public virtual Cuestionario Cuestionario { get; set; }
        public virtual ICollection<Opciones> Opciones { get; set; }
        public virtual ICollection<RespuestaVerdaderoFalso> RespuestaVerdaderoFalso { get; set; }
        public virtual TipoPregunta TipoPregunta { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Model{
    
    public class Facturacion{
       
        public Facturacion(){
            this.Detalle = new HashSet<Detalle>();
        }
    
        public int IDFacturacion { get; set; }
        public DateTime FechaFac { get; set; }
        public decimal PrecioPorPregunta { get; set; }
        public byte TotalPreguntas { get; set; }
        public decimal MontoTotal { get; set; }
         
        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}

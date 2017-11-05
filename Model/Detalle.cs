using System;
using System.Collections.Generic;

namespace Model{
   
    public class Detalle{
        public int IDCuestionario { get; set; }
        public byte IDDetalle { get; set; }
        public byte CantPreguntas { get; set; }
        public int IDFacturacion { get; set; }
    
        public virtual Cuestionario Cuestionario { get; set; }
        public virtual Facturacion Facturacion { get; set; }
    }
}

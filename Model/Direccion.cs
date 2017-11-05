using System;
using System.Collections.Generic;

namespace Model{
     
    public class Direccion{
        public int IDDireccion { get; set; }
        public string IDPersona { get; set; }
        public byte IDTipoDireccion { get; set; }
        public int IDCity { get; set; }
        public int IDState { get; set; }
        public int IDCountry { get; set; }
        public string NombreDireccion { get; set; }
        public bool Activo { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual States States { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual TipoDireccion TipoDireccion { get; set; }
    }
}

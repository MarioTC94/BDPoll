using System;
using System.Collections.Generic;

namespace Model{
  
    public class Persona{
       
        public Persona(){
            this.Direccion = new HashSet<Direccion>();
            this.Email = new HashSet<Email>();
            this.RespuestaMultiple = new HashSet<RespuestaMultiple>();
            this.RespuestaSelecUnica = new HashSet<RespuestaSelecUnica>();
            this.RespuestaVerdaderoFalso = new HashSet<RespuestaVerdaderoFalso>();
            this.Telefono = new HashSet<Telefono>();
        }
    
        public string IDPersona { get; set; }
        public int IDTipoPersona { get; set; }
        public bool Activo { get; set; }
            
        public virtual ICollection<Direccion> Direccion { get; set; }
        public virtual ICollection<Email> Email { get; set; }
        public virtual PersonaExtranjera PersonaExtranjera { get; set; }
        public virtual PersonaNacional PersonaNacional { get; set; }
        public virtual ICollection<RespuestaMultiple> RespuestaMultiple { get; set; }
        public virtual ICollection<RespuestaSelecUnica> RespuestaSelecUnica { get; set; }
        public virtual ICollection<RespuestaVerdaderoFalso> RespuestaVerdaderoFalso { get; set; }
        public virtual ICollection<Telefono> Telefono { get; set; }
        public virtual TipoPersona TipoPersona { get; set; }
    }
}

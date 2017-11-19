using System;
using System.Collections.Generic;

namespace Model{
    
    public class Usuario{
        
        public Usuario(){
            this.Cuestionario = new HashSet<Cuestionario>();
        }
        public string NombreUsuario { get; set; }
        public byte[] Contrasena { get; set; }
        public string Salt { get; set; }
        public bool Activo { get; set; }
   
        public virtual ICollection<Cuestionario> Cuestionario { get; set; }
        public virtual Email Email { get; set; }
    }
}

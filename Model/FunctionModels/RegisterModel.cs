using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FunctionModels {
   public class RegisterModel {

        public string IDPersona { get; set; }
        public int IDTipoPersona { get; set; }
        public int IDGenero { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNac { get; set; }
        public int Country { get; set; }
        public int States { get; set; }
        public int City { get; set; }
        public string NumeroTelefono { get; set; }
        public string NombreUsuario { get; set; }
        public byte[] Contrasena { get; set; }
        public byte[] Salt { get; set; }
        public int IDTelefono { get; set; }
        public int TipoDireccion { get; set; }
        public byte IDTipoEmail { get; set; }
        public string DescripcionTipoEmail { get; set; }
        public byte IDTipoTelefono { get; set; }
        public string DescripcionTipoTelefono { get; set; }
        public string NombreDireccion { get; set; }
        public string NombreEmail { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FunctionModels {

    public class RegisterModel{

        public String IDPersona  { get; set; }
        public int IDTipoPersona { get; set; }
        public String Nombre { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public DateTime FechaNac { get; set; }
        public int IDGenero { get; set; }
        public byte IDTipoTelefono { get; set; }
        public string NumeroTelefono { get; set; }
        public byte TipoDireccion { get; set; }
        public int Country { get; set; }
        public int States { get; set; }
        public int City { get; set; }
        public string NombreDireccion { get; set; }
        public byte IDTipoEmail { get; set; }
        public string NombreEmail { get; set; }
        public string NombreUsuario { get; set; }
        public byte [] Contrasena { get; set; }
        public string Salt { get; set; }

    }
}

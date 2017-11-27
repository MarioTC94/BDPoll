using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class Login {

        public bool tryLogin(String Usuario, String Password) {

            if (!new Data.clsRegistro().UsarioExiste(Usuario)) throw new Exception("Lo sentimos, El usuario no existe.");
            byte[] salt = new Data.Login().getSalt(Usuario);
            byte[] hash = Encrypt.HashPassword(Password, Convert.ToBase64String(salt));
            byte[] getpassword = new Data.Login().getPassword(Usuario);
            if (hash.SequenceEqual(getpassword)) {
                Model.FunctionModels.Usuario oUser = new Data.Login().getUserData(Usuario);
                GuardarCredenciales(oUser.Nombre, oUser.Apellido1, oUser.Apellido2, oUser.IDPersona, oUser.IDTipoPersona, oUser.NombreUsuario);
                return true;
            }
            return false;

        }

        public static void GuardarCredenciales(String Nombre, String Apellido1, String Apellido2, String IDPersona, int IDTipoPersona, String NombreUsuario) {

            Credenciales.Usuario.Nombre = Nombre;
            Credenciales.Usuario.Apellido1 =Apellido1;
            Credenciales.Usuario.Apellido2 = Apellido2;
            Credenciales.Usuario.IDPersona = IDPersona;
            Credenciales.Usuario.IDTipoPersona = IDTipoPersona;
            Credenciales.Usuario.NombreUsuario = NombreUsuario;
        }


    }
}

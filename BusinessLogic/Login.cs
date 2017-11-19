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
                Credenciales.Usuario.Nombre = oUser.Nombre;
                Credenciales.Usuario.Apellido1 = oUser.Apellido1;
                Credenciales.Usuario.Apellido2 = oUser.Apellido2;
                Credenciales.Usuario.IDPersona = oUser.IDPersona;
                Credenciales.Usuario.IDTipoPersona = oUser.IDTipoPersona;
                Credenciales.Usuario.NombreUsuario = oUser.NombreUsuario;
                return true;
            }
            return false;

        }


    }
}

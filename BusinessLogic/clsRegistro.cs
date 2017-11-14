using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model.FunctionModels;

namespace BusinessLogic {
    public class clsRegistro {
        
        public Task<bool> AuntenticarUsuario(String IDPersona, int TipoPersona, String Nombre, String Apellido1,  String Apellido2, DateTime FechaNac, 
                                             int Genero, String Email, byte TipoEmail, String Telefono, byte TipoTelefono, String Usuario,
                                             String Contraseña, int Country, int State, int City, byte TipoDireccion, String NombreDireccion) {

            return Task.Run(() => {

                if (String.IsNullOrEmpty(IDPersona)) throw new ArgumentNullException("IDPersona", " La Cédula no puede estar vacía ");
                if (String.IsNullOrEmpty(Nombre)) throw new ArgumentNullException("Nombre", "El Nombre no puede estar vacío");
                if (String.IsNullOrEmpty(Apellido1)) throw new ArgumentNullException("Apellido1", "El Apellido 1 no puede estar vacío");
                if (String.IsNullOrEmpty(Apellido2)) throw new ArgumentNullException("Apellido2", "El Apellido 2 no puede estar vacío");
                if (String.IsNullOrEmpty(Email)) throw new ArgumentNullException("Email", "El Email no puede estar vacío");
                if (String.IsNullOrEmpty(Telefono)) throw new ArgumentNullException("Telefono", "El Teléfono no puede estar vacío");
                if (String.IsNullOrEmpty(Usuario)) throw new ArgumentNullException("Usuario", "El Usuario no puede estar vacío");
                if (String.IsNullOrEmpty(Contraseña)) throw new ArgumentNullException("Contraseña", "La Contraseña no puede estar vacía");
                if (String.IsNullOrEmpty(NombreDireccion)) throw new ArgumentNullException("Nombre", "El campo de Nombre Dirección no puede estar vacia");


                String Salt = Encrypt.GetRandomSalt();
                byte[] Hash = Encrypt.HashPassword(Contraseña, Salt);



                RegisterModel oRegister = new RegisterModel() {
                    IDPersona = IDPersona,
                    IDTipoPersona = TipoPersona,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNac = FechaNac,
                    IDGenero = Genero,
                    NombreEmail = Email,
                    IDTipoEmail = TipoEmail,
                    NumeroTelefono = Telefono,
                    IDTipoTelefono = TipoTelefono,
                    NombreUsuario = Usuario,
                    Contrasena = Hash,
                    Country = Country,
                    States = State,
                    City = City,
                    TipoDireccion = TipoDireccion,
                    Salt = Salt,
                    NombreDireccion = NombreDireccion
                };
                

                

                return true;
            });


        }
    }
}

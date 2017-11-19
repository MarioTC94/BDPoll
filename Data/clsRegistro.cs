 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.FunctionModels;
using System.Data.SqlClient;
using System.Data;

namespace Data {
   public class clsRegistro {

        public bool Registrar(RegisterModel oRegistro) {

            SqlCommand oSQLC = new SqlCommand();
            String Persona = "INSERT INTO Persona(IDPersona, IDTipoPersona) VALUES(@IDPersona, @IDTipoPersona);";
            String InfoPersona = "";
            if (oRegistro.IDTipoPersona == 1)
                InfoPersona = "INSERT INTO PersonaNacional(IDPersonaNacional, IDGenero, Nombre, Apellido1, Apellido2, FechaNacimiento) VALUES(@IDPersona, @IDGenero, @Nombre, @Apellido1, @Apellido2, @FechaNacimiento);";
            else
                InfoPersona = "INSERT INTO PersonaExtranjera(IDPersonaExtranjera, IDGenero, Nombre, Apellido1, FechaNacimiento) VALUES(@IDPersona, @IDGenero, @Nombre, @Apellido1, @FechaNacimiento);";

            String Telefono = "INSERT INTO Telefono(IDPersona, IDTipoTelefono, NumeroTelefono) VALUES(@IDPersona, @IDTipoTelefono, @NumeroTelefono);";
            String Direccion = "INSERT INTO Direccion(IDPersona, IDTipoDireccion, IDCity, IDState, IDCountry, NombreDireccion) VALUES (@IDPersona, @IDTipoDireccion, @IDCity, @IDState, @IDCountry, @NombreDireccion);";
            String Email = "INSERT INTO Email(IDPersona, IDTipoEmail, NombreEmail) VALUES (@IDPersona, @IDTipoEmail, @NombreEmail);";
            String Usuario = "INSERT INTO Usuario(NombreUsuario, Contrasena, Salt, IDPersona) VALUES (@NombreUsuario, @Contrasena, @Salt, @IDPersona);";

            oSQLC.CommandText = Persona + InfoPersona + Telefono + Direccion + Email + Usuario;
            oSQLC.Parameters.AddWithValue("@IDPersona", oRegistro.IDPersona);
            oSQLC.Parameters.AddWithValue("@IDTipoPersona", oRegistro.IDTipoPersona);
            oSQLC.Parameters.AddWithValue("@IDGenero", oRegistro.IDGenero);
            oSQLC.Parameters.AddWithValue("@Nombre", oRegistro.Nombre);
            oSQLC.Parameters.AddWithValue("@Apellido1", oRegistro.Apellido1);
            oSQLC.Parameters.AddWithValue("@Apellido2", oRegistro.Apellido2);
            oSQLC.Parameters.AddWithValue("@FechaNacimiento", oRegistro.FechaNac);
            oSQLC.Parameters.AddWithValue("@IDTipoTelefono", oRegistro.IDTipoTelefono);
            oSQLC.Parameters.AddWithValue("@NumeroTelefono", oRegistro.NumeroTelefono);
            oSQLC.Parameters.AddWithValue("@IDTipoDireccion", oRegistro.TipoDireccion);
            oSQLC.Parameters.AddWithValue("@IDCity", oRegistro.City);
            oSQLC.Parameters.AddWithValue("@IDState", oRegistro.States);
            oSQLC.Parameters.AddWithValue("@IDCountry", oRegistro.Country);
            oSQLC.Parameters.AddWithValue("@NombreDireccion", oRegistro.NombreDireccion);
            oSQLC.Parameters.AddWithValue("@IDTipoEmail", oRegistro.IDTipoEmail);
            oSQLC.Parameters.AddWithValue("@NombreEmail", oRegistro.NombreEmail);
            oSQLC.Parameters.AddWithValue("@NombreUsuario", oRegistro.NombreUsuario);
            oSQLC.Parameters.AddWithValue("@Contrasena", oRegistro.Contrasena);
            oSQLC.Parameters.AddWithValue("@Salt", oRegistro.Salt);

            return new clsConnection().CMD(oSQLC);
       
        }

        public bool PersonaExiste(String IDPersona) {
            SqlCommand oSQLC = new SqlCommand("SELECT IDPersona FROM Persona WHERE IDPersona = @ID AND Activo = 1");
            oSQLC.Parameters.AddWithValue("@ID", IDPersona);
            return new Data.clsConnection().Exists(oSQLC);
        }

        public bool UsarioExiste(String NombreUsuario) {
            SqlCommand oSQLC = new SqlCommand("SELECT NombreUsuario FROM Usuario WHERE NombreUsuario = @ID AND Activo = 1");
            oSQLC.Parameters.AddWithValue("@ID", NombreUsuario);
            return new Data.clsConnection().Exists(oSQLC);
        }

    }
}

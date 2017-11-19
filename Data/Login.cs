using System;
using System.Data;
using System.Data.SqlClient;
using Model.FunctionModels;

namespace Data {
    public class Login {


        public byte[] getSalt(String Usuario) {
            SqlCommand oSQLC = new SqlCommand("SELECT Salt FROM dbo.Usuario WHERE NombreUsuario = @User AND Activo = 1");
            oSQLC.Parameters.AddWithValue("@User", Usuario);
            SqlDataReader oSQLDR = new clsConnection().SelectUniqueData(oSQLC);
            byte[] hash = null;

            if (oSQLDR != null) {
                hash = (byte[]) oSQLDR["Salt"];
            }

            return hash;
        }

        public byte[] getPassword(String Usuario) {
            SqlCommand oSQLC = new SqlCommand("SELECT Contrasena FROM dbo.Usuario WHERE NombreUsuario = @User AND Activo = 1");
            oSQLC.Parameters.AddWithValue("@User", Usuario);
            SqlDataReader oSQLDR = new clsConnection().SelectUniqueData(oSQLC);
            byte[] hash = null;

            if (oSQLDR != null) {
                hash = (byte[]) oSQLDR["Contrasena"];
            }

            return hash;

        }

        public bool UsuarioExiste(String Usuario) {
            SqlCommand oSQLC = new SqlCommand("SELECT COUNT(*) FROM dbo.Usuario WHERE NombreUsuario = @User AND Activo = 1");
            oSQLC.Parameters.AddWithValue("@User", Usuario);
            return new clsConnection().Exists(oSQLC);
        }

        public Usuario getUserData(String Username) {
            SqlCommand oSQLC = new SqlCommand("SELECT a.IDTipoPersona, b.IDPersona, c.NombreUsuario, d.Nombre, d.Apellido1, d.Apellido2 FROM dbo.TipoPersona a " +
                                            "JOIN dbo.Persona b ON b.IDTipoPersona = a.IDTipoPersona " +
                                            "JOIN dbo.Usuario c ON c.IDPersona = b.IDPersona " +
                                            "JOIN dbo.PersonaNacional d ON d.IDPersonaNacional = b.IDPersona " +
                                            "WHERE c.NombreUsuario = 'MarioTC09' AND b.Activo = 1 ");

            oSQLC.Parameters.AddWithValue("MarioTC09", Username);
            SqlDataReader oSQLDR = new clsConnection().SelectUniqueData(oSQLC);
            if (oSQLDR != null) {
                Usuario oUser = new Usuario() {
                    IDPersona = (String) oSQLDR["IDPersona"],
                    IDTipoPersona = (int) oSQLDR["IDTipoPersona"],
                    NombreUsuario = (String) oSQLDR["NombreUsuario"],
                    Nombre = (String) oSQLDR["Nombre"],
                    Apellido1 = (String) oSQLDR["Apellido1"],
                    Apellido2 = (String) oSQLDR["Apellido2"],
                    
                };
                oSQLDR.Close();
                return oUser;
            }
            return null;
        }
    }
}

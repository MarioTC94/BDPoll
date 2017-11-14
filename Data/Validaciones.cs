using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data {
    public class Validaciones {

        public Task<bool> ExistsIDUser(String NombreUsuario) {

            return Task.Run(() => {
                SqlCommand oSQLC = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @NombreUsuario;");
                using (oSQLC) {
                    return new Data.clsConnection().Exists(oSQLC);
                }
            });
        }

            public Task<bool> ExistsIDPerson(String IDPersona) {

                return Task.Run(() => {
                    SqlCommand oSQLC = new SqlCommand("SELECT COUNT(*) FROM Persona WHERE IDPersona = @IDPersona;");

                    using (oSQLC) {
                        return new Data.clsConnection().Exists(oSQLC);
                    }
                });
            }
        }
    }


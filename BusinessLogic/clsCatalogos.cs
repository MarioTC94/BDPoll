using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic {

    public class clsCatalogos {

        public Task<DataTable> getTipoPersona() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoPersona();
            });
        }

        public DataTable getTipoDireccion() {
            return new Data.clsCatalogos().getTipoDireccion();
        }

        public DataTable getTipoEmail() {
            return new Data.clsCatalogos().getTipoEmail();
        }

        public DataTable getTipoTelefono() {
            return new Data.clsCatalogos().getTipoTelefono();
        }

        public DataTable getTipoPregunta() {
            return new Data.clsCatalogos().getTipoPregunta();
        }

        public DataTable getTipoCuestionario() {
            return new Data.clsCatalogos().getTipoCuestionario();
        }

        public DataTable getCountry() {
            return new Data.clsCatalogos().getCountry();
        }

        public DataTable getState() {
            return new Data.clsCatalogos().getState();
        }

        public DataTable getCity() {
            return new Data.clsCatalogos().getCity();
        }
    }
}

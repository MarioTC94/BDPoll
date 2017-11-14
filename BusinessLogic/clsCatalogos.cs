using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic {

    public class clsCatalogos {

        //Metodos asincronos que evitar que el programa se quede congelado por medio de hilos de ejecución

        public Task<DataTable> getTipoPersona() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoPersona();
            });
        }

        public Task<DataTable> getTipoDireccion() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoDireccion();
            });
        }

        public Task<DataTable> getTipoEmail() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoEmail();
            });
        }

        public Task<DataTable> getTipoTelefono() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoTelefono();
            });
        }

        public Task<DataTable> getTipoPregunta() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoPregunta();
            });
        }

        public Task<DataTable> getTipoCuestionario() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getTipoCuestionario();
            });
        }

        public Task<DataTable> getCountry() {
            return Task.Run(() => { 
                return new Data.clsCatalogos().getCountry();
            });
        }

        public Task<DataTable> getState(int IDCountry) {
            return Task.Run(() => {
                return new Data.clsCatalogos().getState(IDCountry);
            });
        }

        public Task<DataTable> getCity(int IDState) {
            return Task.Run(() => {
                return new Data.clsCatalogos().getCity(IDState);
            });
        }

        public Task <DataTable> getGenero() {
            return Task.Run(() => {
                return new Data.clsCatalogos().getGenero();
            });
        }
    }
}

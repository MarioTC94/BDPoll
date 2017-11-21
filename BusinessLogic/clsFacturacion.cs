using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class clsFacturacion {

        public Task<bool> InsertarFactura(int IDFacturacion, byte TotalPreguntas, int MontoTotal) {

            return Task.Run(() => {

                return new Data.Facturacion().InsertarFactura(new Model.Facturacion() {IDFacturacion= IDFacturacion, TotalPreguntas= TotalPreguntas, MontoTotal= MontoTotal });
            });
        }

        public Task<bool> InsertarDetalle(int IDCuestionario, byte IDDetalle, byte CantPreguntas, int IDFacturacion){

            return Task.Run(() => {

                return new Data.Facturacion().InsertarDetalle(new Model.Detalle() { IDCuestionario = IDCuestionario, IDDetalle = IDDetalle, CantPreguntas = CantPreguntas, IDFacturacion = IDFacturacion });
            });
        }
    }
}

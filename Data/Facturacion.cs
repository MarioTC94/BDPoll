using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data {
   public class Facturacion {

        public bool InsertarFactura(Model.Facturacion oFacturacion) {

            SqlCommand oSQLC = new SqlCommand("INSERT INTO dbo.Facturacion(IDFacturacion, PrecioPorPregunta, TotalPreguntas, MontoTotal) VALUES(@IDFacturacion, @PrecioPorPregunta, @TotalPreguntas, @MontoTotal;");
            oSQLC.Parameters.AddWithValue("@IDFacturacion", oFacturacion.IDFacturacion);
            oSQLC.Parameters.AddWithValue("@PrecioPorPregunta", 2);
            oSQLC.Parameters.AddWithValue("@TotalPreguntas", oFacturacion.TotalPreguntas);
            oSQLC.Parameters.AddWithValue("@MontoTotal", oFacturacion.MontoTotal);

            return new Data.clsConnection().CMD(oSQLC);
        }

        public bool InsertarDetalle(Model.Detalle oDetalle) {

            SqlCommand oSQLC = new SqlCommand("Insert INTO dbo.Detalle(IDCuestionario,IDDetalle, CantPreguntas, IDFacturacion) VALUES(@IDCuestionario, @IDDetalle, @CantPreguntas, @IDFacturacion;");
            oSQLC.Parameters.AddWithValue("@IDCuestionario", oDetalle.IDCuestionario);
            oSQLC.Parameters.AddWithValue("@IDDetalle", oDetalle.IDDetalle);
            oSQLC.Parameters.AddWithValue("@CantPreguntas", oDetalle.CantPreguntas);
            oSQLC.Parameters.AddWithValue("@IDFacturacion", oDetalle.Facturacion);

            return new Data.clsConnection().CMD(oSQLC);
        }
    }
}

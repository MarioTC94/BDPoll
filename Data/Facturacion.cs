using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data {
   public class Facturacion {

        public bool InsertarFactura(Model.Facturacion oFacturacion) {

            SqlCommand oSQLC = new SqlCommand("INSERT INTO dbo.Facturacion(IDFacturacion, FechaFac, PrecioPorPregunta, TotalPreguntas, MontoTotal) VALUES(@IDFacturacion, @FechaFac, @PrecioPorPregunta, @TotalPreguntas, @MontoTotal;");
            oSQLC.Parameters.AddWithValue("@IDFacturacion", oFacturacion.IDFacturacion);
            oSQLC.Parameters.AddWithValue("@FechaFac", oFacturacion.FechaFac);
            oSQLC.Parameters.AddWithValue("@PrecioPorPregunta", oFacturacion.PrecioPorPregunta);
            oSQLC.Parameters.AddWithValue("@TotalPreguntas", oFacturacion.TotalPreguntas);
            oSQLC.Parameters.AddWithValue("@MontoTotal", oFacturacion.MontoTotal);

            return new Data.clsConnection().CMD(oSQLC);
        }
    }
}

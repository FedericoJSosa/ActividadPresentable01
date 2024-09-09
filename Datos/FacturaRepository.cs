using ActividadPresentable01.Dominio;
using ActividadPresentable01.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPresentable01.Datos
{
    public class FacturaRepository : IFacturaRepository
    {
        private string connectionString = Resources.cnnString;

        public void CrearFactura(Factura factura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CrearFactura", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumeroFactura", factura.NumeroFactura);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@FormaPagoId", 1);  
                cmd.Parameters.AddWithValue("@ClienteId", 1);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarFactura(Factura factura)
        {
            throw new NotImplementedException();
        }
        public void EliminarFactura(int numeroFactura)
        {
            throw new NotImplementedException();
        }
        public Factura ObtenerFactura(int numeroFactura)
        {
            throw new NotImplementedException();
        }
    }
}

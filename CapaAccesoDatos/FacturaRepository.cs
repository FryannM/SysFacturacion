using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaAccesoDatos
{
   public class FacturaRepository
    {
        public static FacturaRepository Instancia { get; } = new FacturaRepository();



        public int CrearFactura(entFactura factura)
        {
            SqlCommand cmd = null;
            var respuesta = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spGuardarFactura", cn);
                cmd.Parameters.AddWithValue("@clienteid", factura.clienteID);
                cmd.Parameters.AddWithValue("@tipoPago", factura.TipoPago);
                cmd.Parameters.AddWithValue("@estado", factura.estado);
                cmd.Parameters.AddWithValue("@anulada", factura.anulada);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                respuesta = cmd.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception )
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }


    }
}

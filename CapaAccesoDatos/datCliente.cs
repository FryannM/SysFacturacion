using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region singleton
        private static readonly datCliente _intancia = new datCliente();
        public static datCliente Intancia {
            get { return datCliente._intancia; }
        }
        #endregion singleton


        #region metodos

        public List<entCliente> BuscarClienteAvanzada(String Nom_cli)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entCliente> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBusquedaSensitiva", cn);
                cmd.Parameters.AddWithValue("@prmNom_Cli",Nom_cli);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entCliente>();
                while (dr.Read())
                {
                    entCliente c = new entCliente();
                    c.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    entTipoDocumento td = new entTipoDocumento();
                    td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc_Cliente"].ToString());
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    c.NumeroDoc_Cliente = dr["NumeroDoc_Cliente"].ToString();
                    c.Nombre_Cliente = dr["Nombre_Cliente"].ToString();
                    c.Telefono_Cliente = dr["Telefono_Cliente"].ToString();
                    c.Celular_Cliente = dr["Celular_Cliente"].ToString();
                    c.Correo_Cliente = dr["Correo_Cliente"].ToString();
                    c.Direccion_Cliente = dr["Direccion_Cliente"].ToString();
                    c.FechaNac_Cliente = dr["FechaNac_Cliente"].ToString();
                    Lista.Add(c);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public entCliente BuscarCliente(int id_Cli, String nro_Doc) {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entCliente c = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.Parameters.AddWithValue("@prmidCliente", id_Cli);
                cmd.Parameters.AddWithValue("@prmNroDoc", nro_Doc);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new entCliente();
                    c.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    entTipoDocumento td = new entTipoDocumento();
                    td.Id_TipDoc =Convert.ToInt32(dr["Id_TipDoc_Cliente"].ToString());
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    c.NumeroDoc_Cliente = dr["NumeroDoc_Cliente"].ToString();
                    c.Nombre_Cliente = dr["Nombre_Cliente"].ToString();
                    c.Telefono_Cliente = dr["Telefono_Cliente"].ToString();
                    c.Celular_Cliente = dr["Celular_Cliente"].ToString();
                    c.Correo_Cliente = dr["Correo_Cliente"].ToString();
                    c.Direccion_Cliente = dr["Direccion_Cliente"].ToString();
                    c.FechaNac_Cliente = dr["FechaNac_Cliente"].ToString();
                    c.Sexo_Cliente = dr["Sexo_Cliente"].ToString();


                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); } return c;      
        }

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entCliente> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entCliente>();
                while (dr.Read())
                {
                    entCliente c = new entCliente();
                    c.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    entTipoDocumento td = new entTipoDocumento();
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    c.NumeroDoc_Cliente = dr["NumeroDoc_Cliente"].ToString();
                    c.Nombre_Cliente = dr["Nombre_Cliente"].ToString();
                    c.Telefono_Cliente = dr["Telefono_Cliente"].ToString();
                    c.Celular_Cliente = dr["Celular_Cliente"].ToString();
                    c.Correo_Cliente = dr["Correo_Cliente"].ToString();
                    c.Direccion_Cliente = dr["Direccion_Cliente"].ToString();
                    Lista.Add(c);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public int MantenimientoCliente(String cadXml)
        {
            SqlCommand cmd = null;
            var result=0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsEditElimCliente", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
           
        }

        public List<entTipoDocumento> ListarTipDoc() {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entTipoDocumento> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipDoc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entTipoDocumento>();
                while (dr.Read())
                {
                    entTipoDocumento td = new entTipoDocumento();
                    td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc"]);
                    td.Abreviatura_TipDoc = dr["Abreviatura_TipDoc"].ToString();
                    Lista.Add(td);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); } return Lista;      
        }
        
        #endregion metodos

    }
}

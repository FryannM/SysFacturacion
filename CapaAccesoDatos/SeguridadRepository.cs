using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Entidades;
namespace CapaAccesoDatos
{
    public class SeguridadRepository{

        #region singleton
        private static readonly SeguridadRepository _instancia = new SeguridadRepository();
        public static SeguridadRepository Instancia {
            get { return SeguridadRepository._instancia; }
        }
        #endregion singleton

        #region metodos

        public int MantenimientoUsuario(String cadXml) {
            SqlCommand cmd = null;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsEditElimUsario", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@retorno", DbType.Int32);
                p.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(p);
                cn.Open();
                var result =  cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public entUsuario BuscarUusario(String por, String valor){
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUsuario u = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("[spBuscarUsuario_new]", cn);
                cmd.Parameters.AddWithValue("@prmBusqueda", por);
                cmd.Parameters.AddWithValue("@prmValor", valor);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUsuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    u.Codigo_Usuario = dr["Codigo_Usuario"].ToString();
                    u.Nombre_Usuario = dr["Nombre_Usuario"].ToString();
                    u.Login_Usuario = dr["Login_Usuario"].ToString();
                    u.Password_Usuario = dr["Password_Usuario"].ToString();
                    u.Telefono_Usuario = dr["Telefono_Usuario"].ToString();
                    u.Celular_Usuario = dr["Celular_Usuario"].ToString();
                    u.Correo_Usuario = dr["Correo_Usuario"].ToString();
                    //u.DominoCorreo_Usuario = dr["DominoCorreo_Usuario"].ToString();
                    u.Estado_Usuario = Convert.ToBoolean(dr["Estado_Usuario"]);
                    u.Expiracion_Usuario = dr["Expiracion_Usuario"].ToString();
                    entNivelAcceso na = new entNivelAcceso();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    u.nivel_acceso = na;
                    entSucursal s = new entSucursal();
                    s.Id_Suc = Convert.ToInt32(dr["Id_Suc"]);
                    s.Direccion_Suc = dr["Direccion_Suc"].ToString();
                    s.Codigo_Suc = dr["Codigo_Suc"].ToString();
                    u.sucursal = s;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }

        public entSucursal MostrarCodSuc(Int32 idSuc){
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entSucursal s = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMostrarCodSuc", cn);
                cmd.Parameters.AddWithValue("@prmIdSuc", idSuc);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    s = new entSucursal();
                    s.Codigo_Suc = dr["Codigo_Suc"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return s;
        }

        public entNivelAcceso ListarNivelAccesoDesc(Int32 idnivel)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entNivelAcceso entNivelAcceso = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMostrarDescNivel", cn);
                cmd.Parameters.AddWithValue("@prmNivelAcceso", idnivel);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    entNivelAcceso = new entNivelAcceso();
                    entNivelAcceso.Descripcion_NivelAcc = dr["Descripcion_NivelAcc"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return entNivelAcceso;
        }

        public List<entNivelAcceso> ListarNivelAcceso() {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
           List<entNivelAcceso> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaNivelAcceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entNivelAcceso>();
                while (dr.Read())
                {
                    entNivelAcceso na = new entNivelAcceso();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    na.Descripcion_NivelAcc = dr["Descripcion_NivelAcc"].ToString();
                    Lista.Add(na);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public List<entSucursal> ListarSucursal() {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entSucursal> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarSucursal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entSucursal>();
                while (dr.Read())
                {
                    entSucursal s = new entSucursal();
                    s.Id_Suc = Convert.ToInt32(dr["Id_Suc"]);
                    s.Direccion_Suc = dr["Direccion_Suc"].ToString();
                    Lista.Add(s);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public entUsuario VerificarAcceso(String usuario,String clave){
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUsuario u = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spVerificarAcceso_new", cn);
                cmd.Parameters.AddWithValue("@prmUsuario", usuario);
                cmd.Parameters.AddWithValue("@prmpassword", clave);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    u = new entUsuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    u.Nombre_Usuario = dr["Nombre_Usuario"].ToString();
                    u.Expiracion_Usuario = dr["Expiracion_Usuario"].ToString();
                    u.Estado_Usuario = Convert.ToBoolean(dr["Estado_Usuario"]);
                    entNivelAcceso na = new entNivelAcceso();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    u.nivel_acceso = na;
                    entSucursal s = new entSucursal();
                    s.Id_Suc = Convert.ToInt32(dr["Id_Suc"]);
                    s.Direccion_Suc = dr["Direccion_Suc"].ToString();
                    u.sucursal = s;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }


        #endregion metodos


    }
}

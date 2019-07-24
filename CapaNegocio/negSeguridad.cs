using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
namespace CapaNegocio
{
    public class negSeguridad{
        #region singleton
        private  static readonly negSeguridad  _instancia=new negSeguridad();
        public static negSeguridad Instancia {
            get{
                return negSeguridad._instancia; 
            }
        }

        #endregion singleton
        public int MantenimientoUsuario(entUsuario u,int tipoedicion) {
            try
            {
                String cadXml = "";
                cadXml += "<usuario ";
                cadXml += "idusuario='" + u.Id_Usuario + "' ";
                cadXml += "idnivelacceso='" + u.nivel_acceso.Id_NivelAcc + "' ";
                cadXml+= "idsucusuario='"+u.sucursal.Id_Suc+"' ";
                cadXml += "nombre='" + u.Nombre_Usuario + "' ";
                cadXml += "logeo='" + u.Login_Usuario + "' ";
                cadXml += "pass='" + u.Password_Usuario + "' ";
                cadXml += "telefono='" + u.Telefono_Usuario + "' ";
                cadXml += "celular='" + u.Celular_Usuario + "' ";
                cadXml += "correo='" + u.Correo_Usuario + "' ";
                cadXml += "estado='" + u.Estado_Usuario + "' ";
                cadXml += "usuariocreacion='" + u.UsuarioCreacion_Usuario + "' ";
                cadXml += "expiracion='" + u.Expiracion_Usuario + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "'/>";

                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.MantenimientoUsuario(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public entUsuario BuscarUsario(String por, String valor) {
            try
            {
                if (por.Equals("<<<< Seleccionar >>>>")){
                    throw new ApplicationException("Seleccione el campo de busqueda");
                }
                entUsuario u = null;
                u = datSeguridad.Instancia.BuscarUusario(por, valor);
                if (u == null) {
                    throw new ApplicationException("No se encontraron registros");
                }
                return u;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entSucursal MostrarCodSuc( Int32 idScu) {
            try
            {
                return datSeguridad.Instancia.MostrarCodSuc(idScu);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entNivelAcceso ListarNivelAccesoDesc(Int32 idnivel)
        {
            try
            {
                return datSeguridad.Instancia.ListarNivelAccesoDesc(idnivel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entNivelAcceso> ListarNivelAcceso()
        {
            try
            {
                return datSeguridad.Instancia.ListarNivelAcceso();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entSucursal> ListarSucursal() {
            try
            {
                return datSeguridad.Instancia.ListarSucursal();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public entUsuario IngresoSisema(String usuario,String password)
        {
            try
            {
                if (usuario == "") throw new ApplicationException("Ingrese un usuario");
                if (password == "") throw new ApplicationException("Ingrese una contraseña");
                entUsuario u = null;
                u = datSeguridad.Instancia.VerificarAcceso(usuario, password);
                if (u == null)
                {
                    throw new ApplicationException("Usuario ó password invalido");
                }
                else if (u != null) {
                    if (u.Estado_Usuario==false)
                    {
                        throw new ApplicationException("Usuario Inactivo");
                    }
                    else if (Convert.ToDateTime(u.Expiracion_Usuario) < DateTime.Now)
                    {
                        throw new ApplicationException("Su fecha de acceso ah expirado");
                    }
                }
                return u;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}

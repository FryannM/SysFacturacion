using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using Entidades;
namespace CapaNegocio
{
   public class negCliente
    {
        #region singleton
        private static readonly negCliente _intancia = new negCliente();
        public static negCliente Intancia {
            get { return negCliente._intancia; }
        }
        #endregion singleton

        #region metodos 

        public List<entCliente> BuscarClienteAvanzada(String Nomm_cli)
        {
            try
            {
                List<entCliente> Lista = null;
                Lista = datCliente.Intancia.BuscarClienteAvanzada(Nomm_cli);
                if (Lista == null) throw new ApplicationException("Ocurrio un problema en la busqueda");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entCliente BuscarCliente(int id_cli, String nro_Doc) {
            try
            {
                entCliente c = null;
                c = datCliente.Intancia.BuscarCliente(id_cli,nro_Doc);
                if (c == null) throw new ApplicationException("No se encontro registro en la BD");
                return c;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entCliente> ListarCliente()
        {
            try
            {
                List<entCliente> Lista = datCliente.Intancia.ListarCliente();
                if (Lista.Count <= 0) throw new ApplicationException("Lista de clientes vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista de clientes");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int MantenimientoCliente(entCliente c,int tipoedicion) {
            try
            {
                string cadXml = "";
                cadXml += "<cliente ";
                cadXml+="idcliente='"+c.Id_Cliente+"' ";
                cadXml += "idtipdoc='" + c.tipodocumento.Id_TipDoc + "' ";
                cadXml += "nrodoc='" + c.NumeroDoc_Cliente + "' ";
                cadXml += "nombre='" + c.Nombre_Cliente + "' ";
                cadXml += "fechanac='" + c.FechaNac_Cliente + "' ";
                cadXml += "sexo='" + c.Sexo_Cliente + "' ";
                cadXml += "telefono='" + c.Telefono_Cliente + "' ";
                cadXml += "celular='" + c.Celular_Cliente + "' ";
                cadXml += "correo='" + c.Correo_Cliente + "' ";
                cadXml += "direccion='" + c.Direccion_Cliente + "' ";
                cadXml += "usuariocreacion='" + c.UsuarioCreacion_Cliente + "' ";
                cadXml += "usuarioupdate='" + c.UsuarioUpdate_Cliente + "' ";
                cadXml += "tipoedicion='" +tipoedicion + "'/>";
                
                cadXml = "<root>" + cadXml + "</root>";
                int result = datCliente.Intancia.MantenimientoCliente(cadXml);
                if (result <= 0) throw new ApplicationException("Ocurrio un error al registrar");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entTipoDocumento> ListarTipDoc() {
            try
            {
                List<entTipoDocumento> Lista = datCliente.Intancia.ListarTipDoc();
                if (Lista.Count <= 0) throw new ApplicationException("Lista tipo documento vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista tipo documento");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }



        #endregion metodos

    }
}

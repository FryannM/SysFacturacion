﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
namespace CapaNegocio
{
   public class negVenta {

        #region singleton
        private static readonly negVenta _intancia = new negVenta();
        public static negVenta Intancia {
            get { return negVenta._intancia; }
        }
        #endregion singleton

        #region metodos

        public entVenta VentaDetalle(int id_venta) {
            try
            {
                entVenta v = datVenta.Instancia.LstVentaDetalle(id_venta);
                if (v == null) throw new ApplicationException("Ocurrio un error al tratar de mostrar detalle");
                //else if (v.detalleventa.Count == 0 || v.detalleventa == null) { throw new ApplicationException("No se encontraron items");return v; }
                return v;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AnularVentaxId(int id_venta) {
            try
            {
                int retorno = datVenta.Instancia.AnularVentaXid(id_venta);
                if (retorno == 0) throw new ApplicationException("No se pudo completar la acción");
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entVenta> ListarVenta(String fdesde,String fhasta,int idSucursal)
        {
            try
            {
                List<entVenta> Lista = datVenta.Instancia.ListarVenta(fdesde, fhasta,idSucursal);
                if (Lista == null) throw new ApplicationException("Error al cargar historial de ventas");
                else if (Lista.Count == 0) throw new ApplicationException("Lista de historial de ventas vacia");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entTipoPago> CargarTipoPago() {
            try
            {
                List<entTipoPago> Lista = datVenta.Instancia.CargarTipoPago();
                if (Lista == null) throw new ApplicationException("Error al cargar tipo de pago");
                else if (Lista.Count == 0) throw new ApplicationException("Litsa tipo de pago vacia");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AnularComprobante(String serie,String correlativo,int tipcomprobante){
            try
            {
                int result = datVenta.Instancia.AnularComprobante(serie,correlativo,tipcomprobante);
                if (result <= 0) throw new ApplicationException("No se pudo anular comprobante");
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public String CargarCorrelativo(int id_tipcom,String serie) {
            try
            {
                String correlativo = datVenta.Instancia.CargarCorrelativo(id_tipcom,serie);
                if (correlativo == null) throw new ApplicationException("Error al cargar número correlativo");
                return correlativo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entSerie CargarSerie(int id_suc,int id_tipcom) {
            try
            {
                entSerie s = datVenta.Instancia.CargarSerie(id_suc,id_tipcom);
                if (s == null) throw new ApplicationException("Error al cargar serie, problema con dato de sucursal");
                return s;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GuardarVenta(entVenta v,int id_tipdocventa,String serie) {
            try
            {
                if (v.cliente.Id_Cliente == 0) throw new ApplicationException("Debe tener un cliente seleccionado");
                if (v.detalleventa.Count == 0) throw new ApplicationException("Debe selecionar como mínimo un producto");

                String Cadxml = "";
                Cadxml += "<venta ";
                Cadxml += "idcliente='"+v.cliente.Id_Cliente +"' ";
                Cadxml += "idusuario='" + v.usuario.Id_Usuario + "' ";
                Cadxml += "idsucursal='" + v.sucursal.Id_Suc +"' ";
                Cadxml += "istipcom='" + v.tipocomprobante.Id_TipCom +"' ";
                Cadxml += "idmoneda='" + v.moneda.Id_Moneda +"' ";
                Cadxml += "idtipopago='" + v.tipopago.Id_TipPago + "' ";
                Cadxml += "igv='" + v.Igv_Venta + "' ";
                Cadxml += "serie='" + serie + "' ";
                Cadxml += "descuento='" + v.Descuento_Venta.ToString().Replace(",",".") + "' ";
                Cadxml += "descripcion='" + v.Desc_Venta.ToString() + "'>";

                foreach (entDetalleVenta dt in v.detalleventa) {
                    Cadxml += "<detalle ";
                    Cadxml += "idproducto='" +dt.Id_Prod_Det +"' ";
                    Cadxml += "precioprod='" +dt.PrecProd_Det.ToString().Replace(",",".") +"' ";
                    Cadxml += "cantidad='" +dt.Cantidad_Det +"'/>";
                }
                Cadxml += "</venta>";
                Cadxml = "<root>" + Cadxml + "</root>";
                int i = datVenta.Instancia.GuardarVenta(Cadxml, id_tipdocventa);
                if (i <= 0) throw new ApplicationException("Ocurrio un erro al guardar venta actual");
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<entMoneda> ListarMoneda() {
            try
            {
                List<entMoneda> Lista = datVenta.Instancia.ListarMoneda();
                if (Lista.Count <= 0) throw new ApplicationException("Lista moneda esta vacia");
                else if(Lista==null) throw new ApplicationException("Error al cargar lista de moneda");
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

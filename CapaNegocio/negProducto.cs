using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class negProducto
    {
        #region singleton
        private static readonly negProducto _intancia = new negProducto();
        public static negProducto Instancia
        {
            get { return negProducto._intancia; }
        }
        #endregion singleton

        #region metodos

        public int EliminarMaterial(Int32 id) {

            try
            {
                int r = datProducto.Instancia.EliminarMateria(id);
                if (r <= 0)
                {
                    throw new Exception("Ocurrio un error al Eliminar Material");
                }
                return r;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public entMaterial BuscarMaterial(Int32 idMaterial)
        {
            try
            {
                entMaterial m = datProducto.Instancia.BuscarMaterial(idMaterial);
                return m;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<entMaterial> ListarMaterial() {
            try
            {
                List<entMaterial> Lista = datProducto.Instancia.ListarMaterial();
                if (Lista.Count<=0) {
                    throw new ApplicationException("Lista Material vacia");
                }
                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public int EditarMaterial(int idMaterial,String material) {
            try
            {
                int i = datProducto.Instancia.EditarMaterial(idMaterial,material);
                if (i <= 0)
                {
                    throw new Exception("Ocurrio un error al Editar Material");
                }
                return i;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int RegistrarMaterial(String m)
        {
            try
            {
                int i = datProducto.Instancia.CrearMaterial(m);
                if (i <= 0)
                {
                    throw new Exception("Ocurrio un error al registrar Material");
                }
                return i;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<entProducto> BuscarprodAvanzadaIndicador(String name)
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.LstProdIndicadorAvanzada(name);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProducto> ListarProductoIndicador(String codigo, int id_cat, int rango)
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.ListarProductoIndicador(codigo, id_cat, rango);
                if (Lista.Count == 0) throw new ApplicationException("No se encontro ningun registro");
                else if (Lista == null) throw new ApplicationException("Se produjo un error en la carga de la lista de productos");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProducto> BuscarprodAvanzada(int tip_busq, String val_busqueda)
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.BuscarProductoAvanzada(tip_busq, val_busqueda);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entProducto BuscarProducto(int id_producto)
        {
            try
            {
                entProducto p = null;
                p = datProducto.Instancia.BuscarProducto(id_producto);
                if (p == null) throw new ApplicationException("No se encontro producto seleccionado en la BD");
                return p;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProducto> ListarProducto()
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.ListarProducto();
                if (Lista.Count == 0) throw new ApplicationException("Lista de productos vacia");
                else if (Lista == null) throw new ApplicationException("Se produjo un error en la carga de la lista de productos");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int MantenimientoProducto(entProducto p, int tipoedicion)
        {
            try
            {

                String cadXml = "";
                cadXml += "<producto ";
                cadXml += "idproducto='" + p.Id_Prod + "' ";
                cadXml += "idcat='" + p.categoria.Id_Cat + "' ";
                cadXml += "idunmed='" + p.unidmedida.Id_Umed + "' ";
                cadXml += "idprov='" + p.proveedor.Id_Proveedor + "' ";
                cadXml += "nombre='" + p.Nombre_Prod + "' ";
                cadXml += "marca='" + p.Marca_Prod + "' ";
                cadXml += "preciocompra='" + p.PrecioCompra_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "precio='" + p.Precio_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "stock='" + p.Stock_Prod + "' ";
                cadXml += "stockprom='" + p.StockProm_Prod + "' ";
                cadXml += "stockmin='" + p.StockMin_Prod + "' ";
                cadXml += "usuariocreacion='" + p.UsuarioCreacion_Prod + "' ";
                cadXml += "usuarioupdate='" + p.UsuarioUpdate_Prod + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "' ";
                cadXml += "idmaterial='" + p.material.Id + "'/>";

                cadXml = "<root>" + cadXml + "</root>";
                int i = datProducto.Instancia.MantenimientoProducto(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int MantenimientoProveedor(entProveedor pr, int tipoedicion)
        {
            try
            {
                String cadXml = "";
                cadXml += "<proveedor ";
                cadXml += "idprove='" + pr.Id_Proveedor + "' ";
                cadXml += "razonsocial='" + pr.RazSocial_Proveedor + "' ";
                cadXml += "ruc='" + pr.Ruc_Proveedor + "' ";
                cadXml += "direccion='" + pr.Direccion_Proveedor + "' ";
                cadXml += "telefono='" + pr.Telefono_Proveedor + "' ";
                cadXml += "celular='" + pr.Celular_Proveedor + "' ";
                cadXml += "correo='" + pr.Correo_Proveedor + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int i = datProducto.Instancia.MantenimientoProveedor(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int MantenimientoUnidMedida(entUnidadMedida ume, int tipoedicion)
        {
            try
            {
                entUnidadMedida um = new entUnidadMedida();
                um = ume;
                String cadXml = "";
                cadXml += "<unmedida ";
                cadXml += "idunmedida='" + um.Id_Umed + "' ";
                cadXml += "descripcion='" + um.Descripcion_Umed + "' ";
                cadXml += "abreviatura='" + um.Abreviatura_Umed + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int i = datProducto.Instancia.MantenimientoUnidMedida(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public entProveedor BuscarProveedor(int id_Prove)
        {
            try
            {
                entProveedor pr = null;
                pr = datProducto.Instancia.BuscarProveedor(id_Prove);
                if (pr == null) throw new ApplicationException("No se encontro registro en la BD");
                return pr;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entUnidadMedida BuscarUnidMedida(int id_uniMed)
        {
            try
            {
                entUnidadMedida um = null;
                um = datProducto.Instancia.BuscarUniMedida(id_uniMed);
                if (um == null) throw new ApplicationException("No se encontro registro en la BD");
                return um;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProveedor> ListarProveedor()
        {
            try
            {
                List<entProveedor> Lista = null;
                Lista = datProducto.Instancia.ListarProveedor();
                //        if (Lista.Count == 0) throw new ApplicationException("No se encontraron registros");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entUnidadMedida> ListarUnidMed()
        {
            try
            {
                List<entUnidadMedida> Lista = null;
                Lista = datProducto.Instancia.ListarUniMedida();
                //if (Lista.Count == 0) throw new ApplicationException("No se encontraron registros");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entCategoria BuscrCategoria(int cat_id)
        {
            try
            {
                if (cat_id.ToString() == "") throw new ApplicationException("Debe seleccionar un registro de la lista");
                entCategoria c = null;
                c = datProducto.Instancia.BuscarCategoria(cat_id);
                if (c == null) throw new ApplicationException("No se encontro el registro en BD");
                return c;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int MantenimientoCategoria(entCategoria c, int tipoedicion)
        {
            try
            {
                entCategoria cat = new entCategoria();
                cat = c;
                String cadXml = "";
                cadXml += "<categoria ";
                cadXml += "idcategoria='" + cat.Id_Cat + "' ";
                cadXml += "nombre='" + cat.Nombre_Cat + "' ";
                cadXml += "descripcion='" + cat.Descripcion_Cat + "' ";
                cadXml += "usuariocreacion='" + cat.UsuarioCreacion_Cat + "' ";
                cadXml += "usuarioupdate='" + cat.UsuarioUpdate_Cat + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int i = datProducto.Instancia.MantenimientoCategoria(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<entCategoria> ListarCategoria()
        {
            try
            {
                return datProducto.Instancia.ListarCategoria();
            }
            catch (Exception)
            {
                throw;
            }

        }


        #endregion metodos

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        Int32 idUsuario;
        public frmProducto(Int32? id_Usuario)
        {
            InitializeComponent();
            idUsuario = (Int32)id_Usuario;
        }

        // metodos globales para etiquetas del formulario 

        AccionesEnControles ac = new AccionesEnControles();

        public void ControlBotones(String pantalla,Boolean nuevo, Boolean editar, Boolean grabar, Boolean eliminar, Boolean cancelar, Boolean salir)
        {
            try
            {
                if (pantalla == "P")
                {
                    btnNuevoP.Enabled = nuevo;
                    btnEditarP.Enabled = editar;
                    btnGuardarP.Enabled = grabar;
                    btnEliminarP.Enabled = eliminar;
                    btnCancelarP.Enabled = cancelar;
                    btnSalirP.Enabled = salir;
                }

                else if (pantalla == "C")
                {
                    btnNuevoC.Enabled = nuevo;
                    btnEditarC.Enabled = editar;
                    btnGuardarC.Enabled = grabar;
                    btnEliminarC.Enabled = eliminar;
                    btnCancelarC.Enabled = cancelar;
                    btnSalirC.Enabled = salir;
                }

                else if (pantalla == "UM")
                {

                    btnNuevoUM.Enabled = nuevo;
                    btnEditarUM.Enabled = editar;
                    btnGuardarUM.Enabled = grabar;
                    btnEliminarUM.Enabled = eliminar;
                    btnCancelarUM.Enabled = cancelar;
                    btnSalirUM.Enabled = salir;
                }
                else if (pantalla == "PR") {
                    btnNuevoPR.Enabled = nuevo;
                    btnEditarPR.Enabled = editar;
                    btnGuardarPR.Enabled = grabar;
                    btnEliminarPR.Enabled = eliminar;
                    btnCancelarPR.Enabled = cancelar;
                    btnSalirPR.Enabled = salir;
                }
                else{
                    btnNuevoMaterial.Enabled = nuevo;
                    btnEditarMaterial.Enabled = editar;
                    btnGrabarMaterial.Enabled = grabar;
                    btnEliminarMaterial.Enabled = eliminar;
                    btnCancelarMaterial.Enabled = cancelar;
                    btnSalirMaterial.Enabled = salir;
                }
               

               

            }
            catch (Exception)
            {
                throw;
            }
        }
        // Crear diseño del GRID
        private void CrearGrid()
        {
            dgvProductos.Columns.Add("ColumnId", "Id");
            dgvProductos.Columns.Add("ColumnNumero", "#");
            dgvProductos.Columns.Add("ColumnCodigo", "Codigo");
            dgvProductos.Columns.Add("ColumnNombre", "Nombre");
            dgvProductos.Columns.Add("ColumnMarca", "Marca");
            dgvProductos.Columns.Add("ColumnCategoria", "Categoria");
            dgvProductos.Columns.Add("ColumnUnidMed", "Unid. Med");
            dgvProductos.Columns.Add("ColumnProveedor", "Proveedor");

            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Width = 30;
            dgvProductos.Columns[1].Width = 60;

            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

        }
        private void CrearGridCategoria()
        {
            dgvCategoria.Columns.Add("ColumnId", "id");
            dgvCategoria.Columns.Add("ColumnNumero", "#");
            dgvCategoria.Columns.Add("ColumnCodigo", "Codigo");
            dgvCategoria.Columns.Add("ColumnNombre", "Nombre");
            dgvCategoria.Columns.Add("ColumnDescripcion", "Descripción");

            //  dgvCategoria.Columns[0].Visible = false;
            dgvCategoria.Columns[1].Width = 30;
            dgvCategoria.Columns[2].Width = 150;
            dgvCategoria.Columns[3].Width = 300;

            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategoria.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.MultiSelect = false;

        }
        private void CrearGridUniMed()
        {
            dgvUnidadMedida.Columns.Add("ColumnId", "id");
            dgvUnidadMedida.Columns.Add("ColumnNumero", "#");
            dgvUnidadMedida.Columns.Add("ColumnCodigo", "Codigo");
            dgvUnidadMedida.Columns.Add("ColumnDescripcion", "Descripción");
            dgvUnidadMedida.Columns.Add("ColumnAbrev", "Abreviatura");

            dgvUnidadMedida.Columns[0].Visible = false;
            dgvUnidadMedida.Columns[1].Width = 30;
            dgvUnidadMedida.Columns[3].Width = 300;
            dgvUnidadMedida.Columns[4].Width = 150;


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUnidadMedida.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvUnidadMedida.AllowUserToAddRows = false;
            dgvUnidadMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void CrearGridProveedor()
        {
            dgvProveedor.Columns.Add("ColumnId", "id");
            dgvProveedor.Columns.Add("ColumnNumero", "#");
            dgvProveedor.Columns.Add("ColumnCodigo", "Codigo");
            dgvProveedor.Columns.Add("ColumnRazSocial", "Raz. Social");
            dgvProveedor.Columns.Add("ColumnRuc", "Ruc");

            dgvProveedor.Columns[0].Visible = false;
            dgvProveedor.Columns[1].Width = 30;
            dgvProveedor.Columns[3].Width = 300;
            dgvProveedor.Columns[4].Width = 150;


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedor.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void CrearGridMaterial()
        {
            dgvMaterial.Columns.Add("ColumnId", "id");
            dgvMaterial.Columns.Add("ColumnNumero", "#");
            dgvMaterial.Columns.Add("ColumnCodigo", "Codigo");
            dgvMaterial.Columns.Add("ColumnNombre", "Nombre");

            dgvMaterial.Columns[0].Visible = false;
            dgvMaterial.Columns[1].Width = 30;
            dgvMaterial.Columns[2].Width = 150;
            dgvMaterial.Columns[3].Width = 300;


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaterial.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        // cargar combos para producto
        private void LlenarCombos()
        {
            try
            {
                cboCategoria.ValueMember = "Id_Cat";
                cboCategoria.DisplayMember = "Nombre_Cat";
                cboCategoria.DataSource = negProducto.Instancia.ListarCategoria();

                cboUnidMed.ValueMember = "Id_Umed";
                cboUnidMed.DisplayMember = "Descripcion_Umed";
                cboUnidMed.DataSource = negProducto.Instancia.ListarUnidMed();

                cboProveedor.ValueMember = "Id_Proveedor";
                cboProveedor.DisplayMember = "RazSocial_Proveedor";
                cboProveedor.DataSource = negProducto.Instancia.ListarProveedor();

                cboMaterial.ValueMember = "Id";
                cboMaterial.DisplayMember = "Nombre";
                cboMaterial.DataSource = negProducto.Instancia.ListarMaterial();


            }
            catch (Exception)
            {
                throw;
            }
        }
        // funcion validar entrada solo caracteres validos 
        private Boolean EntradaDecimales(KeyPressEventArgs e)
        {
            try
            {
                Boolean result;
                String cadena = "1234567890," + (char)5;
                if (cadena.Contains(e.KeyChar))
                {
                    result = true;
                }
                else
                {
                    MessageBox.Show("Esta intentando ingresar un caracter no válido", "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning); result = false;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Mostrarfila_select(int id_prod)
        {
            try
            {
                entProducto p = null;
                // int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                p = negProducto.Instancia.BuscarProducto(id_prod);
                txtIdP.Text = p.Id_Prod.ToString();
                txtCodigoP.Text = p.Codigo_Prod;
                txtNombre.Text = p.Nombre_Prod;
                txtMarca.Text = p.Marca_Prod;
                txtPrecioCompra.Text = p.PrecioCompra_Prod.ToString();
                txtPrecioVenta.Text = p.Precio_Prod.ToString();
                txtStock.Text = p.Stock_Prod.ToString();
                txtStockPromedio.Text = p.StockProm_Prod.ToString();
                txtStockMin.Text = p.StockMin_Prod.ToString();
                cboCategoria.SelectedValue = p.categoria.Id_Cat;
                cboUnidMed.SelectedValue = p.unidmedida.Id_Umed;
                cboProveedor.SelectedValue = p.proveedor.Id_Proveedor;
                cboMaterial.SelectedValue = p.material.Id;
                ac.BloquearText(this.tbcProducto, false);
                ControlBotones("P",true, true, false, true, false, true);
            }
            catch (Exception)
            {

                throw;
            }
        }

     


        private void frmProducto_Load(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("P",true, false, false, false, false, true);
                ControlBotones("C", true, false, false, false, false, true);
                ControlBotones("PR", true, false, false, false, false, true);
                ControlBotones("UM", true, false, false, false, false, true);
                ControlBotones("M", true, false, false, false, false, true);


                ac.BloquearText(this.tbcProducto, false);
                ac.BloquearText(this.tbcCategoria, false);
                ac.BloquearText(this.tbcProveedor, false);
                ac.BloquearText(this.tbcUnidMedida, false);
                
                CrearGrid();
                CrearGridCategoria();
                CrearGridUniMed();
                CrearGridProveedor();
                CrearGridMaterial();
                LlenarCombos();
                CargarGridProducto();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ac.LimpiarText(this.tbcProducto);
                ac.BloquearText(this.tbcProducto, true);
                ControlBotones("P",false, false, true, false, true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("P",false, false, true, false, true, false);
                ac.BloquearText(this.tbcProducto, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(Convert.ToString(cboCategoria.SelectedValue))) throw new ApplicationException("Deber tener seleccionada una Categoria");
                else if (String.IsNullOrEmpty(Convert.ToString(cboProveedor.SelectedValue))) throw new ApplicationException("Deber tener seleccionado un Proveedor");
                else if (String.IsNullOrEmpty(Convert.ToString(cboUnidMed.SelectedValue))) throw new ApplicationException("Deber tener seleccionada una Unidad de Medida ");


                entProducto p = new entProducto();
                int tipoedicion = 1;
                if (txtIdP.Text != "") { tipoedicion = 2; p.Id_Prod = Convert.ToInt32(txtIdP.Text); }
                p.Nombre_Prod = txtNombre.Text;
                p.Marca_Prod = txtMarca.Text;
                if (txtPrecioCompra.Text == "") p.PrecioCompra_Prod = 0; else p.PrecioCompra_Prod = Convert.ToDouble(txtPrecioCompra.Text);
                if (txtPrecioVenta.Text == "") p.Precio_Prod = 0; else p.Precio_Prod = Convert.ToDouble(txtPrecioVenta.Text);
                if (txtStock.Text == "") p.Stock_Prod = 0; else p.Stock_Prod = Convert.ToInt32(txtStock.Text);
                if (txtStockPromedio.Text == "") p.StockProm_Prod = 0; else p.StockProm_Prod = Convert.ToInt32(txtStockPromedio.Text);
                if (txtStockMin.Text == "") p.StockMin_Prod = 0; else p.StockMin_Prod = Convert.ToInt32(txtStockMin.Text);
                entCategoria c = new entCategoria();
                c.Id_Cat = Convert.ToInt32(cboCategoria.SelectedValue);
                p.categoria = c;
                entUnidadMedida um = new entUnidadMedida();
                um.Id_Umed = Convert.ToInt32(cboUnidMed.SelectedValue);
                p.unidmedida = um;
                entProveedor pr = new entProveedor();
                pr.Id_Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);
                p.proveedor = pr;
                entMaterial m = new entMaterial();
                m.Id = Convert.ToInt32(cboMaterial.SelectedValue);
                p.material = m;

                p.UsuarioCreacion_Prod = idUsuario;
                p.UsuarioUpdate_Prod = idUsuario;
                int i = negProducto.Instancia.MantenimientoProducto(p, tipoedicion);
                MessageBox.Show("¡Registro Correcto!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ControlBotones("P",true, false, false, false, false, true);
                ac.BloquearText(this.tbcProducto, false);
                CargarGridProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                entCategoria c = new entCategoria();
                entUnidadMedida um = new entUnidadMedida();
                entProveedor pr = new entProveedor();
                p.Id_Prod = Convert.ToInt32(txtIdP.Text);
                p.categoria = c;
                p.proveedor = pr;
                p.unidmedida = um;
                DialogResult r = MessageBox.Show("¿Desea eliminar Registro seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = negProducto.Instancia.MantenimientoProducto(p, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ControlBotones("P",true, false, false, false, false, true);
                ac.BloquearText(this.tbcProducto, false);
                CargarGridProducto();
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("P",true, true, false, true, false, true);
                ac.BloquearText(this.tbcProducto, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tbcCategoria_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrid()
        {
            try
            {
                dgvCategoria.Rows.Clear();
                List<entCategoria> Lista = null;
                Lista = negProducto.Instancia.ListarCategoria();
                int num = 0;
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new string[] { Lista[i].Id_Cat.ToString(), num.ToString(), Lista[i].Codigo_Cat, Lista[i].Nombre_Cat, Lista[i].Descripcion_Cat };
                    dgvCategoria.Rows.Add(fila);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CargarGridMaterial()
        {
            try
            {
                dgvMaterial.Rows.Clear();
                List<entMaterial> Lista = null;
                Lista = negProducto.Instancia.ListarMaterial();
                int num = 0;
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new string[] { Lista[i].Id.ToString(), num.ToString(), Lista[i].Id.ToString("000"),Lista[i].Nombre};
                   dgvMaterial.Rows.Add(fila);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarGridUnidMedida()
        {
            try
            {
                int num = 0;
                dgvUnidadMedida.Rows.Clear();
                List<entUnidadMedida> um = null;
                um = negProducto.Instancia.ListarUnidMed();
                for (int i = 0; i < um.Count; i++)
                {
                    num++;
                    String[] fila = new string[] { um[i].Id_Umed.ToString(), num.ToString(), um[i].Codigo_Umed, um[i].Descripcion_Umed, um[i].Abreviatura_Umed };
                    dgvUnidadMedida.Rows.Add(fila);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarGridProveedor()
        {
            try
            {
                int num = 0;
                dgvProveedor.Rows.Clear();
                List<entProveedor> pr = null;
                pr = negProducto.Instancia.ListarProveedor();
                for (int i = 0; i < pr.Count; i++)
                {
                    num++;
                    String[] fila = new String[] { pr[i].Id_Proveedor.ToString(), num.ToString(), pr[i].Cod_Proveedor, pr[i].RazSocial_Proveedor, pr[i].Ruc_Proveedor };
                    dgvProveedor.Rows.Add(fila);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarGridProducto()
        {
            try
            {
                dgvProductos.Rows.Clear();
                List<entProducto> Lista = negProducto.Instancia.ListarProducto();
                int num = 0;
                for (int i = 0; i < Lista.Count(); i++)
                {
                    num++;
                    String[] fila = new String[] { Lista[i].Id_Prod.ToString(),num.ToString(),Lista[i].Codigo_Prod,Lista[i].Nombre_Prod,Lista[i].Marca_Prod,
                    Lista[i].categoria.Nombre_Cat,Lista[i].unidmedida.Descripcion_Umed,Lista[i].proveedor.RazSocial_Proveedor};
                    dgvProductos.Rows.Add(fila);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCargarC_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
                btnCargarC.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoC_Click(object sender, EventArgs e)
        {
            try
            {


                ac.LimpiarText(this.tbcCategoria);
                ac.BloquearText(this.tbcCategoria, true);
                ControlBotones("C",false, false, true, false, true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("C",false, false, true, false, true, false);
                ac.BloquearText(this.tbcCategoria, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                int tipoedicion = 1;
                if (txtidC.Text != "") { tipoedicion = 2; c.Id_Cat = Convert.ToInt32(txtidC.Text); }
                c.Nombre_Cat = txtNombreC.Text;
                c.Descripcion_Cat = txtDescripcionC.Text;
                c.UsuarioCreacion_Cat = idUsuario;
                c.UsuarioUpdate_Cat = idUsuario;
                int i = negProducto.Instancia.MantenimientoCategoria(c, tipoedicion);
                MessageBox.Show("¡Registro Correcto!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlBotones("C",true, false, false, false, false, true);
                ac.BloquearText(this.tbcCategoria, false);
                CargarGrid();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                c.Id_Cat = Convert.ToInt32(txtidC.Text);
                DialogResult r = MessageBox.Show("¿Desea eliminar categoria seleccionada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = negProducto.Instancia.MantenimientoCategoria(c, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ControlBotones("C",true, false, false, false, false, true);
                ac.BloquearText(this.tbcCategoria, false);
                CargarGrid();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("C",true, true, false, true, false, true);
                ac.BloquearText(this.tbcCategoria, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirC_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCargarUM_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGridUnidMedida();
                btnCargarUM.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoPR_Click(object sender, EventArgs e)
        {
            try
            {
                ac.LimpiarText(this.tbcProveedor);
                ac.BloquearText(this.tbcProveedor, true);
                ControlBotones("PR",false, false, true, false, true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoUM_Click(object sender, EventArgs e)
        {
            try
            {
                ac.LimpiarText(this.tbcUnidMedida);
                ac.BloquearText(this.tbcUnidMedida, true);
                ControlBotones("UM",false, false, true, false, true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarUM_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("UM",false, false, true, false, true, false);
                ac.BloquearText(this.tbcUnidMedida, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarUM_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadMedida um = new entUnidadMedida();
                int tipoedicion = 1;
                if (txtidUM.Text != "") { tipoedicion = 2; um.Id_Umed = Convert.ToInt32(txtidUM.Text); }
                um.Descripcion_Umed = txtDescripcionUM.Text;
                um.Abreviatura_Umed = txtAbrev.Text;
                int i = negProducto.Instancia.MantenimientoUnidMedida(um, tipoedicion);
                MessageBox.Show("¡Registro Correcto!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ControlBotones("UM",true, false, false, false, false, true);
                ac.BloquearText(this.tbcUnidMedida, false);
                CargarGridUnidMedida();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUM_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadMedida um = new entUnidadMedida();
                um.Id_Umed = Convert.ToInt32(txtidUM.Text);
                DialogResult r = MessageBox.Show("¿Desea eliminar registro seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = negProducto.Instancia.MantenimientoUnidMedida(um, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ControlBotones("UM",true, false, false, false, false, true);
                ac.BloquearText(this.tbcUnidMedida, false);
                CargarGridUnidMedida();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarUM_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("UM",true, true, false, true, false, true);
                ac.BloquearText(this.tbcUnidMedida, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirUM_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnidadMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarPR_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("PR",false, false, true, false, true, false);
                ac.BloquearText(this.tbcProveedor, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarPR_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pr = new entProveedor();
                int tipoedicion = 1;
                if (txtIdPR.Text != "") { tipoedicion = 2; pr.Id_Proveedor = Convert.ToInt32(txtIdPR.Text); }
                pr.RazSocial_Proveedor = txtRazSocial.Text;
                pr.Ruc_Proveedor = txtRuc.Text;
                pr.Direccion_Proveedor = txtDireccion.Text;
                pr.Telefono_Proveedor = txtTelefono.Text;
                pr.Celular_Proveedor = txtCelular.Text;
                pr.Correo_Proveedor = txtCorreo.Text;
                int i = negProducto.Instancia.MantenimientoProveedor(pr, tipoedicion);
                MessageBox.Show("¡Registro Correcto!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ControlBotones("PR",true, false, false, false, false, true);
                ac.BloquearText(this.tbcProveedor, false);
                CargarGridProveedor();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPR_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pr = new entProveedor();
                pr.Id_Proveedor = Convert.ToInt32(txtIdPR.Text);
                DialogResult r = MessageBox.Show("¿Desea eliminar Registro seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = negProducto.Instancia.MantenimientoProveedor(pr, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ControlBotones("UM",true, false, false, false, false, true);
                ac.BloquearText(this.tbcUnidMedida, false);
                CargarGridProveedor();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarPR_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("PR",true, true, false, true, false, true);
                ac.BloquearText(this.tbcProveedor, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirPR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCargraPR_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGridProveedor();
                btnCargraPR.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id_cate = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);
                entCategoria c = null;
                c = negProducto.Instancia.BuscrCategoria(id_cate);
                txtidC.Text = c.Id_Cat.ToString();
                txtCodigoC.Text = c.Codigo_Cat;
                txtNombreC.Text = c.Nombre_Cat;
                txtDescripcionC.Text = c.Descripcion_Cat;
                ControlBotones("C",true, true, false, true, false, true);
                ac.BloquearText(this.tbcCategoria, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnidadMedida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_Unidmed = Convert.ToInt32(dgvUnidadMedida.CurrentRow.Cells[0].Value);
                entUnidadMedida um = null;
                um = negProducto.Instancia.BuscarUnidMedida(id_Unidmed);
                txtidUM.Text = um.Id_Umed.ToString();
                txtCodigoUM.Text = um.Codigo_Umed;
                txtDescripcionUM.Text = um.Descripcion_Umed;
                txtAbrev.Text = um.Abreviatura_Umed;
                ControlBotones("UM",true, true, false, true, false, true);
                ac.BloquearText(this.tbcUnidMedida, false);
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_Proveedor = Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value);
                entProveedor pr = null;
                pr = negProducto.Instancia.BuscarProveedor(id_Proveedor);
                txtIdPR.Text = pr.Id_Proveedor.ToString();
                txtCodigoPR.Text = pr.Cod_Proveedor;
                txtRazSocial.Text = pr.RazSocial_Proveedor;
                txtRuc.Text = pr.Ruc_Proveedor;
                txtDireccion.Text = pr.Direccion_Proveedor;
                txtTelefono.Text = pr.Telefono_Proveedor;
                txtCelular.Text = pr.Celular_Proveedor;
                txtCorreo.Text = pr.Correo_Proveedor;
                ControlBotones("PR",true, true, false, true, false, true);
                ac.BloquearText(this.tbcProveedor, false);
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Aviso",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                Mostrarfila_select(id_prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaDecimales(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaDecimales(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaSoloNumeros(e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStockPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductoBuscar frmProdBuscar = new frmProductoBuscar(this.idUsuario);
                //frmProdBuscar.MdiParent = this.ParentForm;

                frmProdBuscar.ShowDialog();
                int id = LocalBD.Instancia.ReturnIdprod(0, 0);
                for (int i = 0; i < dgvProductos.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value) == id)
                    {
                        dgvProductos.Rows[i].Selected = true;
                        Mostrarfila_select(id);
                        LocalBD.Instancia.ReturnIdprod(1, 0);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNuevoMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreMaterial.Enabled = true;
                txtNombreMaterial.Text = "";
                txtIdMaterial.Text = "";
                ControlBotones("M",false, false, true, false, true, false);
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Mensaje",
             MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtIdMaterial.Text)) { /*editar*/ int i = negProducto.Instancia.EditarMaterial(Convert.ToInt32(txtIdMaterial.Text), txtNombreMaterial.Text); }
                else { /*guardar*/int i = negProducto.Instancia.RegistrarMaterial(txtNombreMaterial.Text); }
           
                ControlBotones("M",true, false, false, false, false, true);
                txtNombreMaterial.Enabled = false;
                MessageBox.Show("Material registrado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridMaterial();
                txtNombreMaterial.Enabled = false;
                LlenarCombos();
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGridMaterial();
                btnCargarMaterial.Visible = false;
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_material = Convert.ToInt32(dgvMaterial.CurrentRow.Cells[0].Value);
                entMaterial m = null;
                m = negProducto.Instancia. BuscarMaterial(id_material);
                txtIdMaterial.Text = m.Id.ToString();
                txtCodigoMaterial.Text = m.Id.ToString("000");
                txtNombreMaterial.Text = m.Nombre;
                ControlBotones("M",true, true, false, true, false, true);
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id_material = 0;
                id_material = Convert.ToInt32(txtIdMaterial.Text);
                DialogResult r = MessageBox.Show("¿Desea eliminar Material seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = negProducto.Instancia.EliminarMaterial(id_material);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ControlBotones("M",true, false, false, false, false, true);
                CargarGridMaterial();
                LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarMaterial_Click(object sender, EventArgs e)
        {

            try
            {
                ControlBotones("M",false, false, true, false, true, false);
                txtNombreMaterial.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBotones("M",true, true, false, true, false, true);
                txtNombreMaterial.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

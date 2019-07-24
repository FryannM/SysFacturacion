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
    public partial class frmCliente : Form
    {
        int idUsuario = 0;
        public frmCliente(int? Id_Usuario)
        {
            InitializeComponent();
            this.idUsuario = (int)Id_Usuario;
        }

        private void ControlBotones(Boolean nuevo,Boolean editar,Boolean eliminar,Boolean salir,Boolean vender) {
            try
            {
                btnNuevo.Enabled = nuevo;
                btnEditar.Enabled = editar;
                btnEliminar.Enabled = eliminar;
                btnSalir.Enabled = salir;
                btnVender.Enabled = vender;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CrearGrid() {
            try
            {
                dgvCliente.Columns.Add("ColumnId", "Id");
                dgvCliente.Columns.Add("ColumnNro", "#");
                dgvCliente.Columns.Add("ColumnNombre", "Nombre/Raz.Social");
                dgvCliente.Columns.Add("ColumnTipoDoc", "Tipo Doc.");
                dgvCliente.Columns.Add("ColumnNroDoc", "Número Documento");
                dgvCliente.Columns.Add("ColumnTelefono", "Teléfono");
                dgvCliente.Columns.Add("ColumnCelular", "Celular");
                dgvCliente.Columns.Add("ColumnCorreo", "Correo");
                dgvCliente.Columns.Add("ColumnDireccion", "Dirección");


                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].Width = 70;
                dgvCliente.Columns[2].Width = 500;
                dgvCliente.Columns[3].Width = 150;
                dgvCliente.Columns[4].Width = 150;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.ColumnHeadersDefaultCellStyle = cssabecera;

                dgvCliente.AllowUserToAddRows = false;
                dgvCliente.MultiSelect = false;
                dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            { 
                throw;
            }
        }

        private void LlenarGrid() {
            try
            { int num = 0;
                dgvCliente.Rows.Clear();
                List<entCliente> Lista = negCliente.Intancia.ListarCliente();
                for (int i = 0; i < Lista.Count; i++) {
                    num++;
                    String[] fila = new String[] {Lista[i].Id_Cliente.ToString(),num.ToString(),Lista[i].Nombre_Cliente,
                    Lista[i].tipodocumento.Nombre_TipDoc,Lista[i].NumeroDoc_Cliente,Lista[i].Telefono_Cliente,Lista[i].Celular_Cliente,
                    Lista[i].Correo_Cliente,Lista[i].Direccion_Cliente};
                    dgvCliente.Rows.Add(fila);
                }
            }catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CrearGrid();
               // LlenarGrid();
                ControlBotones(true, false, false, true,false);
                txtNomRazSocial.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkBuscar_CheckedChanged(object sender, EventArgs e)
        {
            ControlBotones(true, false, false, true, false);
            if (chkBuscar.CheckState == CheckState.Checked) { txtNroDoc.Enabled = false;btnBuscar.Enabled = false;txtNomRazSocial.Enabled = true; dgvCliente.Rows.Clear();
            }else { txtNroDoc.Enabled = true; btnBuscar.Enabled = true; txtNomRazSocial.Enabled = false; }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente_01 frmModal = new frmCliente_01(idUsuario,0);
                frmModal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                ControlBotones(true, true, true, true,true);
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
                int id_Cliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                if (id_Cliente.ToString() == "" || id_Cliente.ToString()==null) {
                    MessageBox.Show("Debe seleccionar un cliente", "Mensaje",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                frmCliente_01 frmModal = new frmCliente_01(idUsuario,id_Cliente);
                frmModal.ShowDialog();
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
                entCliente c = new entCliente();
                entTipoDocumento td = new entTipoDocumento();
                c.Id_Cliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                c.tipodocumento = td;
                DialogResult i = MessageBox.Show("¿Desea eliminar registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(i == DialogResult.Yes) {
                    int result = negCliente.Intancia.MantenimientoCliente(c, 3);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                }
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                String Nro_doc = txtNroDoc.Text;
                c = negCliente.Intancia.BuscarCliente(0, Nro_doc);
                dgvCliente.Rows.Clear();
                String[] fila = new String[] {c.Id_Cliente.ToString(),1.ToString(),c.Nombre_Cliente,
                    c.tipodocumento.Nombre_TipDoc,c.NumeroDoc_Cliente,c.Telefono_Cliente,c.Celular_Cliente,
                    c.Correo_Cliente,c.Direccion_Cliente};
                dgvCliente.Rows.Add(fila);
            }catch(ApplicationException ae) { MessageBox.Show(ae.Message, "Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information); dgvCliente.Rows.Clear(); ControlBotones(true, false, false, true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomRazSocial_KeyUp(object sender, KeyEventArgs e)
        {
            try
           {
                dgvCliente.Rows.Clear();
                int num = 0;
                String Nom_cli = txtNomRazSocial.Text;
                List<entCliente> Lista = negCliente.Intancia.BuscarClienteAvanzada(Nom_cli);
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new String[] {Lista[i].Id_Cliente.ToString(),num.ToString(),Lista[i].Nombre_Cliente,
                    Lista[i].tipodocumento.Nombre_TipDoc,Lista[i].NumeroDoc_Cliente,Lista[i].Telefono_Cliente,Lista[i].Celular_Cliente,
                    Lista[i].Correo_Cliente,Lista[i].Direccion_Cliente};
                    dgvCliente.Rows.Add(fila);
                }ControlBotones(true, false, false, true, false);
            }catch(ApplicationException ae) {
                MessageBox.Show(ae.Message, "Información", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cerra venta actual", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                this.Dispose();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int id_cli = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
               // frmBoletaVenta frmbv = new frmBoletaVenta(this.idUsuario);
                LocalBD.Instancia.ReturnIdCliente(1, id_cli);
                int frminvocador = LocalBD.Instancia.Invocar(0,0);
                if (frminvocador == 1)
                {
                    LocalBD.Instancia.ReturnIdCliente(1, id_cli);
                }
                else if (frminvocador == 2)
                {
                    LocalBD.Instancia.ReturnIdClienteNV(1, id_cli);
                }
                else {
                    LocalBD.Instancia.Invocar(1, 0);
                }
                this.Close();
                ////frmbv.txtidcli.Text = id_cli.ToString();
                //foreach (Form frm in Application.OpenForms)
                //{
                //    if (frm.GetType() == typeof(frmBoletaVenta))
                //    {
                //        frm.Show();
                //        this.Visible=false;
                //        return;
                //    }
                //}
                //frmbv.Show();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.Rows.Count > 0)
                {
                    int idCli = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                    LlenarGrid();
                    foreach (DataGridViewRow fila in dgvCliente.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells[0].Value) == idCli)
                        {
                            fila.Selected = true;
                            return;
                        }
                    }
                }
                else LlenarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

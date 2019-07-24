using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;
namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        // instancia global de la clase AccionesEnControles para control de etiquetas del formulario
        AccionesEnControles ac = new AccionesEnControles();
        int id_Usuario;
        public frmUsuario(int? idusuario)
        {
            id_Usuario=(int)idusuario;
            InitializeComponent();
            
        }

        // metodos globales para etiquetas del formulario 

        public void ControlBotones(Boolean nuevo, Boolean editar, Boolean grabar, Boolean eliminar, Boolean cancelar, Boolean salir)
        {
            try
            {
                btnNuevo.Enabled = nuevo;
                btnEditar.Enabled = editar;
                btnGuardar.Enabled = grabar;
                btnEliminar.Enabled = eliminar;
                btnCancelar.Enabled = cancelar;
                btnSalir.Enabled = salir;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                String[] arrayBuscar = new String[] { "<<<< Seleccionar >>>>", "Codigo", "Login" };
                cboBuscar.Items.AddRange(arrayBuscar);
                cboBuscar.SelectedIndex = 0;
                String[] arrayDominios = new String[] { "@default.com", "@hotmail.com", "@gmail.com", "@outlook.com", "@live.com" };
                cboDominio.Items.AddRange(arrayDominios);
                cboDominio.SelectedIndex = 0;

                cboNivelAcceso.ValueMember = "Id_NivelAcc";
                cboNivelAcceso.DisplayMember = "Numero_NivelAcc";
                cboNivelAcceso.DataSource = negSeguridad.Instancia.ListarNivelAcceso();

                cboDirSucursal.ValueMember = "Id_Suc";
                cboDirSucursal.DisplayMember = "Direccion_Suc";
                cboDirSucursal.DataSource = negSeguridad.Instancia.ListarSucursal();

                ControlBotones(true, false, false, false, false, true);
                ac.BloquearText(this.panel1, false);

                // conf textbox para ser multilineas(textarea)
                txtDescNivelAcceso.ScrollBars = ScrollBars.Vertical;
                txtDescNivelAcceso.AcceptsReturn = true;
                txtDescNivelAcceso.AcceptsTab = true;
                txtDescNivelAcceso.WordWrap = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNivelAcceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 i = Convert.ToInt32(cboNivelAcceso.SelectedValue.ToString());
                entNivelAcceso na = null;
                na = negSeguridad.Instancia.ListarNivelAccesoDesc(i);
                txtDescNivelAcceso.Text = na.Descripcion_NivelAcc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ac.LimpiarText(this.panel1);
                ac.BloquearText(this.panel1, true);
                ControlBotones(false, false, true, false, true, false);
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
                ControlBotones(false, false, true, false, true, false);
                ac.BloquearText(this.panel1, true);
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
                int tipoedicion = 1;
                entUsuario u = new entUsuario();
               
                entNivelAcceso na = new entNivelAcceso();
                na.Id_NivelAcc = Convert.ToInt32(cboNivelAcceso.SelectedValue);
                u.nivel_acceso = na;
                entSucursal s = new entSucursal();
                s.Id_Suc = Convert.ToInt32(cboDirSucursal.SelectedValue);
                u.sucursal = s;
                u.Nombre_Usuario = txtnombre.Text;
                u.Login_Usuario = txtLogin.Text;
                u.Password_Usuario = txtPassword.Text;
                u.Telefono_Usuario = txtTelefono.Text;
                u.Celular_Usuario = txtCelular.Text;
                u.Correo_Usuario = txtCorreo.Text+ cboDominio.SelectedItem.ToString();
                if (rbActivo.Checked == true) u.Estado_Usuario = true;
                else u.Estado_Usuario = false;
                u.Expiracion_Usuario=dtpExpiracion.Value.ToString("yyyy/MM/dd");
                u.UsuarioCreacion_Usuario = id_Usuario;

                if (txtIdusuario.Text != "") { tipoedicion = 2; u.Id_Usuario = Convert.ToInt32(txtIdusuario.Text); } 
                int i = negSeguridad.Instancia.MantenimientoUsuario(u, tipoedicion);
                MessageBox.Show("¡Registro Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlBotones(true, false, false, false, false, true);
                ac.BloquearText(this.panel1, false);
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
                entUsuario u = new entUsuario();
                u.Estado_Usuario = true;
                entSucursal s = new entSucursal();
                if (!txtIdusuario.Equals(""))  u.Id_Usuario = Convert.ToInt32(txtIdusuario.Text);
                u.sucursal = s;
                entNivelAcceso na = new entNivelAcceso();
                u.nivel_acceso = na;
                DialogResult r = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int result = negSeguridad.Instancia.MantenimientoUsuario(u, 3);
                    MessageBox.Show("Se Elimino usuario, paso a Estado: Inactivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ControlBotones(true, false, false, false, false, true);
                ac.BloquearText(this.panel1, false);
            }
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
                ControlBotones(true, true, false, true, false, true);
                ac.BloquearText(this.panel1, false);
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
                if (res == DialogResult.Yes) {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboDirSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 idSuc = Convert.ToInt32(cboDirSucursal.SelectedValue);
                entSucursal s = null;
                s = negSeguridad.Instancia.MostrarCodSuc(idSuc);
                txtCodSucursal.Text = s.Codigo_Suc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String por = cboBuscar.SelectedItem.ToString();
                String valor = txtBuscar.Text;
                entUsuario u = null;
                u = negSeguridad.Instancia.BuscarUsario(por, valor);
                txtIdusuario.Text =u.Id_Usuario.ToString();
                txtCodUsuario.Text = u.Codigo_Usuario;
                txtnombre.Text = u.Nombre_Usuario;
                txtLogin.Text = u.Login_Usuario;
                txtPassword.Text = u.Password_Usuario;
                txtTelefono.Text = u.Telefono_Usuario;
                txtCelular.Text = u.Celular_Usuario;
                txtCorreo.Text = u.Correo_Usuario;
                dtpExpiracion.Text = u.Expiracion_Usuario;
                if (u.Estado_Usuario == true) rbActivo.Checked = true;
                else rbInactivo.Checked = true;

                cboDirSucursal.SelectedValue = u.sucursal.Id_Suc;
               cboNivelAcceso.SelectedValue = u.nivel_acceso.Id_NivelAcc;

             
                ControlBotones(true, true, false, true, false, true);
                ac.BloquearText(this.panel1, false);
            }
            catch (ApplicationException ae) {
                MessageBox.Show(ae.Message, "Aviso",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

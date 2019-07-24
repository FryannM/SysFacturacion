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
    public partial class frmCliente_01 : Form
    {
        int IdUsuario=0, IdCliente=0;
        public frmCliente_01(int? id_Usuario,int? id_Cliente)
        {
            InitializeComponent();
            IdUsuario = (int)id_Usuario;
            IdCliente = (int)id_Cliente;
        }

        AccionesEnControles ac = new AccionesEnControles();
        private void BuscarCliente() {
            try
            {
                if (IdCliente != 0)
                {
                    entCliente c = new entCliente();
                    c = negCliente.Intancia.BuscarCliente(IdCliente, 0.ToString());
                    cboTipDoc.SelectedValue = c.tipodocumento.Id_TipDoc;
                    txtNumDoc.Text = c.NumeroDoc_Cliente;
                    txtNombre.Text = c.Nombre_Cliente;
                    txtTelefono.Text = c.Telefono_Cliente;
                    txtCelular.Text = c.Celular_Cliente;
                    txtCorreo.Text = c.Correo_Cliente;
                    txtDireccion.Text = c.Direccion_Cliente;
                    dtpFechaNac.Value = Convert.ToDateTime(c.FechaNac_Cliente);
                    if (c.Sexo_Cliente == "M") rbMasculino.Checked = true; else rbFemenino.Checked = true;
                }
            }
            catch (ApplicationException) { throw; }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmCliente_01_Load(object sender, EventArgs e)
        {
            try
            {
                ac.LlenarCboTipDoc(this);rbMasculino.Checked=true;
                txtIdCliente.Text = IdCliente.ToString();
                BuscarCliente();
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                entTipoDocumento td = new entTipoDocumento();
                int tipoedicion = 1;
                if (txtIdCliente.Text != "0") { tipoedicion = 2; c.Id_Cliente = Convert.ToInt32(txtIdCliente.Text); }
                td.Id_TipDoc = Convert.ToInt32(cboTipDoc.SelectedValue);
                c.tipodocumento = td;
                c.NumeroDoc_Cliente = txtNumDoc.Text;
                c.Nombre_Cliente = txtNombre.Text;
                c.FechaNac_Cliente = dtpFechaNac.Value.ToString("yyy/MM/dd");
                if (rbMasculino.Checked == true) c.Sexo_Cliente = "M"; else c.Sexo_Cliente = "F";
                c.Telefono_Cliente = txtTelefono.Text;
                c.Celular_Cliente = txtCelular.Text;
                c.Correo_Cliente = txtCorreo.Text;
                c.Direccion_Cliente = txtDireccion.Text;
                c.UsuarioCreacion_Cliente = IdUsuario;
                c.UsuarioUpdate_Cliente = IdUsuario;
                int i = negCliente.Intancia.MantenimientoCliente(c, tipoedicion);
                MessageBox.Show("Registro Correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}

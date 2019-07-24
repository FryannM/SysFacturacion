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
    public partial class frmLogeo : Form
    {
        public frmLogeo()
        {
            InitializeComponent();
            

        }

        private void frmLogeo_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = txtUsuario.Text;
                String password = txtPassword.Text;
                entUsuario u = null;
                u = negSeguridad.Instancia.IngresoSisema(usuario,password);
                frmSelectSucursal S = new frmSelectSucursal(u);
                S.Show();
                //frmPrincipal frmprincipal = new frmPrincipal(u);
                //frmprincipal.Show();
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

        private void chkmostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmostrarPass.CheckState == CheckState.Checked){
                txtPassword.UseSystemPasswordChar = false;   
            }else {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Dispose(); // Cierra formulario libera recursos
           // Application.Exit(); - Cierra todo la aplicacion liberando recursos
        }
    }
}

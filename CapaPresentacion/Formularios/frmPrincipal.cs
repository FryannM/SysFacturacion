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
    public partial class frmPrincipal : Form
    {
        // Declaracion variables globales------------------
        entUsuario u = new entUsuario();
        public frmPrincipal(entUsuario usuario)
        {
            InitializeComponent();
            u = usuario;
        }
        private void RestriccionesUsuario() {
            try
            {
                if (u.nivel_acceso.Numero_NivelAcc == 1)
                {
                    tsmRegmovimientos.Enabled = false;
                    tsmordencompra.Enabled = false;
                    tsmfactura.Enabled = false;
                    tsmnotacargo.Enabled = false;
                    tsmnotacredito.Enabled = false;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;
                }
                if (u.nivel_acceso.Numero_NivelAcc == 2)
                {
                    tsmSeguridad.Enabled = false;
                    tsmConsultaProd.Enabled = true;
                    tsmConsultaVenta.Enabled = false;

                    tsmRegmovimientos.Enabled = false;
                    tsmordencompra.Enabled = false;
                    tsmfactura.Enabled = false;
                    tsmnotacargo.Enabled = false;
                    tsmnotacredito.Enabled = false;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private void CargarImagenFondo() {
        //    try
        //    {
        //        BackgroundImageLayout = ImageLayout.Stretch;
        //        String urllll = AppDomain.CurrentDomain.BaseDirectory;
        //        urllll = urllll.Replace("\\bin\\Debug", "");
        //        Controls.OfType<MdiClient>().First().BackgroundImage = new Bitmap(urllll + "Resources\\fondo.PNG");
               
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // recorre todos los formularios abiertos en busca de frmLogeo
                Form frmlogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLogeo);
                // si existe una instancia de frmlogeo:  visible = false (oculta)
                if (frmlogin != null)
                {
                    frmlogin.Visible = false;
                }

                Form frnselecsuc = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmSelectSucursal);
                // si existe una instancia de frmlogeo:  visible = false (oculta)
                if (frnselecsuc != null)
                {
                    frnselecsuc.Visible = false;
                }

                lblUsuario.Text = "Bienvenido: " + u.Nombre_Usuario + "    Sucursal: " + u.sucursal.Direccion_Suc
                                  + "     Nivel de acceso: Nivel " + u.nivel_acceso.Numero_NivelAcc;




                RestriccionesUsuario();
                //CargarImagenFondo();
            }
            catch (ArgumentNullException ne) {
                MessageBox.Show(ne.Message, "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la aplicación", "Mensaje", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (result==DialogResult.Yes) {
                Application.Exit(); 
            }
       

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario frmusuario = new frmUsuario(u.Id_Usuario);
                frmusuario.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmUsuario)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmusuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProducto frmProducto = new frmProducto(u.Id_Usuario);
                frmProducto.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmProducto)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmProducto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente frmCliente = new frmCliente(u.Id_Usuario);
                frmCliente.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmCliente)
                    {
                        frm.Show();
                        frm.Size= MinimumSize;
                        frm.WindowState = FormWindowState.Normal; 
                        return;
                    }
                }
                frmCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBoletaVenta frmBoletaVenta = new frmBoletaVenta(u.Id_Usuario);
                frmBoletaVenta.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmBoletaVenta)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmBoletaVenta.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmIndicadorProducto frmProducto = new frmIndicadorProducto();
                frmProducto.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmIndicadorProducto)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmProducto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaVenta frmcventa = new frmConsultaVenta();
                frmcventa.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmConsultaVenta)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmcventa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotaVenta frmNotaventa = new frmNotaVenta(u.Id_Usuario);
                frmNotaventa.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmNotaVenta)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmNotaventa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmInfoApp frminfo = new frmInfoApp();
                frminfo.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms) {
                    if (frm is frmInfoApp) {
                        frm.Show();
                        return;
                    }
                }
                frminfo.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSelectSucursal : Form
    {
        entUsuario u = new entUsuario();
        public frmSelectSucursal(entUsuario user)
        {
            InitializeComponent();
            this.u = user;
        }

        private void frmSelectSucursal_Load(object sender, EventArgs e)
        {
            cboDirSucursal.ValueMember = "Id_Suc";
            cboDirSucursal.DisplayMember = "Direccion_Suc";
            cboDirSucursal.DataSource = negSeguridad.Instancia.ListarSucursal();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LocalBD.Instancia.IdSucursal = Convert.ToInt32(cboDirSucursal.SelectedValue);
            frmPrincipal frmprincipal = new frmPrincipal(u);
            frmprincipal.Show();
        }
    }
}

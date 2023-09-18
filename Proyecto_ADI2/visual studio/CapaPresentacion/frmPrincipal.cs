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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuarios frmReg = new frmRegistrarUsuarios();
            frmReg.MdiParent = this;
            frmReg.Show();
        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoUsuarios frmListarU = new frmListadoUsuarios();
            frmListarU.MdiParent = this;
            frmListarU.Show();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarUsuario frmModU = new frmModificarUsuario();
            frmModU.MdiParent = this;
            frmModU.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread(); //cuierra todas las ventanas
        }

        private void barrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraficos frmGrafico1 = new frmGraficos();
            frmGrafico1.MdiParent = this;
            frmGrafico1.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarProductos frmReg = new frmRegistrarProductos();
            frmReg.MdiParent = this;
            frmReg.Show();
        }

       private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }
    


        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificarProducto frmModP = new frmModificarProducto();
            frmModP.MdiParent = this;
            frmModP.Show();
        }

        private void postresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProducto frmListarP2 = new frmListadoProducto();
            frmListarP2.MdiParent = this;
            frmListarP2.Show();
        }
    }
}

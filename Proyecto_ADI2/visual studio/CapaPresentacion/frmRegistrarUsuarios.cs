using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;

namespace CapaPresentacion
{
    public partial class frmRegistrarUsuarios : Form
    {
        ClassUsuarios users = new ClassUsuarios();

        public frmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                
                //users.n_id = int.Parse(txtId.Text);
                users.n_id = 1;
                users.n_nom_usr = txtNomusr.Text;
                users.n_ci_usr = txtCiusr.Text;
                users.n_nombres = txtNombres.Text;
                users.n_apellidos = txtApellidos.Text;
                users.n_pass = txtContrasena.Text;
                users.n_email = txtEmail.Text;
                users.n_img = txtImagen.Text;
                users.n_nivel = cboNivel.Text;                
                users.n_estado = rbnActivo.Checked==true ? 1 : 0;

                msj=users.registrar_usuario();
                MessageBox.Show(msj);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListadoUsuarios frListarU = new frmListadoUsuarios();            
            frListarU.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread(); //cuierra todas las ventanas
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomusr.Text = "";
            txtCiusr.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtImagen.Text = "";
            cboNivel.Text = "";
            rbnActivo.Checked=true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNomusr.Text = "";
            txtCiusr.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtImagen.Text = "";
            cboNivel.Text = "";
            rbnActivo.Checked = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

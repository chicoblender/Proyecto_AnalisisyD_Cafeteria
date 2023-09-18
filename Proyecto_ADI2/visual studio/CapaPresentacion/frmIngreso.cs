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
    public partial class frmIngreso : Form
    {
        ClassUsuarios users = new ClassUsuarios();

        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {                
                users.n_nom_usr = txtUsuario.Text;
                users.n_pass = txtPassword.Text;
                
                msj = users.verificar_usuario();
                if (msj == "1")
                {
                    MessageBox.Show("Datos correctos");
                    this.Hide();
                    //frmRegistrarUsuarios fr = new frmRegistrarUsuarios();
                    frmPrincipal fr = new frmPrincipal();
                    fr.Show();
                }
                else {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}

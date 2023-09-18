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
    public partial class frmModificarUsuario : Form
    {
        ClassUsuarios users = new ClassUsuarios();
        Int32 id;

        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim()!="")
            {
                DataTable dt = new DataTable();
                dt = users.listado_usuarios_ci(txtBuscar.Text);
                dgvUsuarios.DataSource = dt;       
            }   
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                String activo = "";                
                id = Int32.Parse(dgvUsuarios.CurrentRow.Cells["id"].Value.ToString());
                txtNomusr.Text = dgvUsuarios.CurrentRow.Cells["nom_usr"].Value.ToString();
                txtCiusr.Text = dgvUsuarios.CurrentRow.Cells["ci_usr"].Value.ToString();
                txtNombres.Text = dgvUsuarios.CurrentRow.Cells["nombres"].Value.ToString();
                txtApellidos.Text = dgvUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
                txtContrasena.Text = dgvUsuarios.CurrentRow.Cells["pass"].Value.ToString();
                txtEmail.Text = dgvUsuarios.CurrentRow.Cells["email"].Value.ToString();
                txtImagen.Text = dgvUsuarios.CurrentRow.Cells["img"].Value.ToString();
                cboNivel.Text = dgvUsuarios.CurrentRow.Cells["nivel"].Value.ToString();
                activo = dgvUsuarios.CurrentRow.Cells["estado"].Value.ToString();

                if (activo == "1")
                {
                    rbnActivo.Checked = true;
                }
                else
                {
                    rbnInactivo.Checked = true;
                }
            }
            else {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String msj = "";            
            try
            {                
                users.n_id = id;
                users.n_nom_usr = txtNomusr.Text;
                users.n_ci_usr = txtCiusr.Text;
                users.n_nombres = txtNombres.Text;
                users.n_apellidos = txtApellidos.Text;
                users.n_pass = txtContrasena.Text;
                users.n_email = txtEmail.Text;
                users.n_img = txtImagen.Text;
                users.n_nivel = cboNivel.Text;
                users.n_estado = rbnActivo.Checked == true ? 1 : 0;

                msj = users.modificar_usuario();
                
                if (msj == "1") 
                {
                    MessageBox.Show("Datos modificados correctamente");
                }
                else
                    MessageBox.Show("No se pudo modificar los datos");


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar datos por: "+ ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Int32 id_usr;
                id_usr = int.Parse(dgvUsuarios.CurrentRow.Cells["id"].Value.ToString());
                users.eliminar_usuario(id_usr);
                MessageBox.Show("Eliminado correctamente");
                DataTable dt = new DataTable();
                dt = users.listado_usuarios();
                dgvUsuarios.DataSource = dt; 
            }
            else {
                MessageBox.Show("Seleccione una fila.");
            }

        }

        private void blnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = users.listado_usuarios();
            dgvUsuarios.DataSource = dt;
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
            rbnActivo.Checked = true;

        }
    }
}

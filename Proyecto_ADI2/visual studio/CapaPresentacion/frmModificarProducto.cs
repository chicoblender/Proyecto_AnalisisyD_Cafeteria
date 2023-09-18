using CapaLogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmModificarProducto : Form
    {
        byte[] imagenByte;
        ClassProductos product= new ClassProductos();
        Int32 id;
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() != "")
            {
                DataTable dt = new DataTable();
                dt = product.listado_productos_cod(txtBuscar.Text);
                dgvProductos.DataSource = dt;
            }
        }

        private void blnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = product.listado_productos();
            dgvProductos.DataSource = dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
               
                id = Int32.Parse(dgvProductos.CurrentRow.Cells["id_prod"].Value.ToString());
                txtCod.Text = dgvProductos.CurrentRow.Cells["cod_prod"].Value.ToString();
                txtNombre.Text = dgvProductos.CurrentRow.Cells["nom_prod"].Value.ToString();
               // txtCategoria.Text = dgvProductos.CurrentRow.Cells["cate_prod"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["prec_prod"].Value.ToString();
                picImg.ImageLocation = dgvProductos.CurrentRow.Cells["Img_prod"].Value.ToString();    
               
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String msj = "";
            try
            {
                product.n_id_prod = id;
                product.n_cod_prod = txtCod.Text;
                product.n_nom_prod = txtNombre.Text;
                product.n_prec_prod = Convert.ToInt32(txtPrecio.Text);           
                product.n_Ruta_Imagen =imagenByte;


                msj = product.modificar_producto();

                if (msj == "1")
                {
                    MessageBox.Show("Datos modificados correctamente");
                }
                else
                    MessageBox.Show("No se pudo modificar los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar datos por: " + ex);
            }
        }

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                Int32 id_pro;
                id_pro = int.Parse(dgvProductos.CurrentRow.Cells["id_prod"].Value.ToString());
                product.eliminar_producto(id_pro);
                MessageBox.Show("Eliminado correctamente");
                DataTable dt = new DataTable();
                dt = product.listado_productos();
                dgvProductos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNombre.Text = "";
          
            txtPrecio.Text = "";
            picImg.Image= null;
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png|Todos los archivos|*.*";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picImg.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                picImg.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte = memoria.ToArray();
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

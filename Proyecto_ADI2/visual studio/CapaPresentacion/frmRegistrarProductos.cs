using CapaLogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistrarProductos : Form
    {
        byte[] imagenByte;
        ClassProductos produc = new ClassProductos();
        public frmRegistrarProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarProd_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                        
                produc.n_cod_prod = txtCod.Text;
                produc.n_nom_prod = txtNombre.Text;      
                produc.n_prec_prod = Convert.ToInt32(txtPrecio.Text);
                produc.n_Ruta_Imagen = imagenByte;

                msj = produc.registrar_producto();
                MessageBox.Show(msj);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void frmRegistrarProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoProd_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            picImg.Image = null;
        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            picImg.Image = null;
        }

        private void btnVerListadoProd_Click(object sender, EventArgs e)
        {
            frmListadoProducto frListarP = new frmListadoProducto();
            frListarP.ShowDialog();
        }

        private void btnSalirProd_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png|Todos los archivos|*.*";
            
            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picImg.Image = Image.FromFile(selectorImagen.FileName);
                using (MemoryStream memoria = new MemoryStream())
                {
                    picImg.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                    imagenByte = memoria.ToArray();
                }
            }
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }
    }
}

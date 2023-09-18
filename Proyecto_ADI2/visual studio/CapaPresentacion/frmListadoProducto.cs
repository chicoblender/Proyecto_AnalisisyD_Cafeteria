using CapaLogicaNegocios;
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
    public partial class frmListadoProducto : Form 
    { 
        ClassProductos produc = new ClassProductos();
    
        public frmListadoProducto()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListadoProducto_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = produc.listado_productos();
            dataGridView1.DataSource = dt;
        }
    }
}

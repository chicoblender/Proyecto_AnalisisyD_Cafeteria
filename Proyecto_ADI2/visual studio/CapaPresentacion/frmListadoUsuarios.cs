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
    public partial class frmListadoUsuarios : Form
    {
        ClassUsuarios users = new ClassUsuarios();

        public frmListadoUsuarios()
        {
            InitializeComponent();
        }

        private void frmListadoUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = users.listado_usuarios();
            dataGridView1.DataSource=dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

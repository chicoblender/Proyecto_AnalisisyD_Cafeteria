using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            string[] series={"Eduardo","Juan","Pedro" };
            int[] puntos = { 20, 50, 90 };

            //cambiar la combinación de colores
            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Edades");

            for (int i=0; i<series.Length;i++) {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
                
                 
            }

        }
    }
}

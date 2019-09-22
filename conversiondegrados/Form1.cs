using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiondegrados
{
    public partial class Form1 : Form
    {

        Grados grados = new Grados();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            grados.setNumero1(double.Parse(txtgrados.Text));
            {
                lblresultado.Text = "Resultado es:" + grados.convertir().ToString();
                lblresultado.Visible = true;

            }
        }

        
        
    }
}

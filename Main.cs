using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarconiSP2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int vDias = 0;
            int vDistancia = 0;
            int vCosto = 1500;
            int vPrecio = 0;
            int vTotal = 0;

            vDias = Convert.ToInt32(numDias.Value);
            vDistancia = Convert.ToInt32(txtDistancia.Text);
            vPrecio = vDistancia * vCosto;
            vTotal = vPrecio / 2;

            if (vDistancia >= 100 && vDias >= 7)
            {
                lblPrecioresultado.Text = ("$") + Convert.ToInt32(vPrecio);
                lblTotalresultado.Text = ("$") + vTotal.ToString() + "" + ("Su descuento es del 50%");
            }
            else
            {
                lblPrecioresultado.Text = ("$") + Convert.ToString(vPrecio);
                lblTotalresultado.Text = ("$") + Convert.ToString(vPrecio);
            }
        }
    }
}

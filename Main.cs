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
         
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                float precioTotal = Convert.ToInt32(txtDistancia.Text) * 5;
                if (int.Parse(txtDistancia.Text) >= 100 && numDias.Value >= 7)
                {
                    precioTotal = precioTotal * 0.5f;
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "2,5";
                }
                else
                {
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "5";
                }
            }
            else
            {
                txtPrecioKm.Text = "";
                txtTotal.Text = "";
            }
        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                double precioTotal = Convert.ToInt32(txtDistancia.Text) * 5;
                if (int.Parse(txtDistancia.Text) >= 100 && numDias.Value >= 7)
                {
                    precioTotal = precioTotal * 0.5;
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "2,5";
                }
                else
                {
                    txtTotal.Text = precioTotal.ToString();
                    txtPrecioKm.Text = "5";
                }
            }
            else
            {
                txtPrecioKm.Text = "";
                txtTotal.Text = "";
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

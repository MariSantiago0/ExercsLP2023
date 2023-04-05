using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpexercs2023
{
    public partial class frmposto : Form
    {
        public frmposto()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            char
                cod = Convert.ToChar(txtcod.Text);

            double quantl, valorp;
            quantl = Convert.ToDouble(txtquant.Text);

            if (cod == 'A')
            {
                if (quantl <= 20)
                {
                    valorp = (quantl / 4.90) * 3 / 100;
                    txtvalorp.Text = "$" + valorp;
                }
                else
                {
                    valorp = (quantl / 4.90) * 5 / 100;
                    txtvalorp.Text = "$" + valorp;
                }
            }

            else
                    if (cod == 'G')
            {
                if (quantl <= 20)
                {
                    valorp = (quantl / 5.50) * 4 / 100;
                    txtvalorp.Text = "$" + valorp;
                }
                else
                {
                    valorp = (quantl / 5.50) * 6 / 100;
                    txtvalorp.Text = "$" + valorp;
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtquant.Clear();
            txtvalorp.Clear();
            txtcod.Focus();
        }
    }
}

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
    public partial class frmtabfor : Form
    {
        public frmtabfor()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtnum.Text, out num))
            {
                // Lidar com o erro de conversão aqui
                return;
            }

            int i = 1;
            string tabfor = "";

            for (i = 1; i <= 10; i++)
            {
                double tabforresult = num * i;
                tabfor += tabforresult.ToString() + " \n ";
            }

            txttabforresult.Text = tabfor;
        }

            private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabforresult.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}

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
    public partial class frmtabdowhile : Form
    {
        public frmtabdowhile()
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
            string tabdowhile = "";

            do
            {
                double tabdowhileresult = num * i;
                tabdowhile += tabdowhileresult.ToString() + " \n ";
                i++;
            } while (i <= 10);

            txttabdowhileresult.Text = tabdowhile;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabdowhileresult.Clear();
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

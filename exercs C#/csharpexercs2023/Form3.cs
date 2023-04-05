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
    public partial class frmtabwhile : Form
    {
        public frmtabwhile()
        {
            InitializeComponent();
        }

        private void frmtabwhile_Load(object sender, EventArgs e)
        {

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
            string tabwhile = "";
            while (i <= 10)
            {
                double tabwhileresult = num * i;
                tabwhile += tabwhileresult.ToString() + " \n ";
                i++;
            }
            txttabwhileresult.Text = tabwhile;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabwhileresult.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}

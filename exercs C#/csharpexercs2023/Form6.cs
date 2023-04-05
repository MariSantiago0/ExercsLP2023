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
    public partial class frmvoto : Form
    {
        public frmvoto()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double vtjs = 0, vtmj = 0, vtjt = 0, pjs = 0, pmj = 0, pjt = 0, total = 0;
            int i = 0;
            string voto = "";
            voto = txtvoto.Text;
            i = 1;
            while (i > 0)
            {
                if (voto == "js")
                {
                    vtjs++;
                }
                else if (voto == "mj")
                {
                    vtmj++;
                }
                else if (voto == "jt")
                {
                    vtjt++;
                }
                total++;

                pjs = vtjs / total * 100;
                pmj = vtmj / total * 100;
                pjt = vtjt / total * 100;

                if (vtjs > vtmj && vtjs > vtjt && voto == "js")
                {
                    txtvencedor.Text = "José da Silva";
                    txtvt.Text = vtjs.ToString();
                    txtporcent.Text = pjs.ToString();
                    txttotal.Text = total.ToString();
                }
                else if (vtmj > vtjs && vtmj > vtjt && voto == "mj")
                {
                    txtvencedor.Text = "Maria Juruma";
                    txtvt.Text = vtmj.ToString();
                    txtporcent.Text = pmj.ToString();
                    txttotal.Text = total.ToString();
                }
                else if (vtjt > vtjs && vtjt > vtmj && voto == "jt")
                {
                    txtvencedor.Text = "João da Tapioca";
                    txtvt.Text = vtjt.ToString();
                    txtporcent.Text = pjt.ToString();
                    txttotal.Text = total.ToString();
                }
                else
                {
                    txtvencedor.Text = "Votação Inválida (Empate)";
                    txttotal.Text = total.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvoto.Clear();
            txtvencedor.Clear();
            txtvt.Clear();
            txtporcent.Clear();
            txttotal.Clear();
            txtvoto.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}


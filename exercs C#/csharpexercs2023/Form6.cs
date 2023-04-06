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

        double vtjs = 0, vtmj = 0, vtjt = 0, total, pjs, pmj, pjt;
        string voto;

        private void btnvotar_Click(object sender, EventArgs e)
        {
            voto = Convert.ToString(txtvoto.Text);
            if (voto == "js")
                vtjs++;
            if (voto == "mj")
                vtmj++;
            if (voto == "jt")
                vtjt++;
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            total = vtjs + vtmj + vtjt;
            pjs = (vtjs / total) * 100;
            pmj = (vtmj / total) * 100;
            pjt = (vtjt / total) * 100;
            if (vtjs > vtmj && vtjs > vtjt)
            {
                txtvencedor.Text = "José da Silva recebeu" + vtjs + " equivalente a " + pjs + "%";
                txttotal.Text = total.ToString();
            }
            if (vtmj > vtjs && vtmj > vtjt)
            {
                txtvencedor.Text = "Maria Juruma recebeu" + vtmj + " equivalente a " + pmj + "%";
                txttotal.Text = total.ToString();
            }
            if (vtjt > vtmj && vtjt > vtjs)
            {
                txtvencedor.Text = "João da Tapioca recebeu" + vtjt + " equivalente a " + pjt + "%";
                txttotal.Text = total.ToString();
            }
            else
            {
                txtvencedor.Text = "Votação Inválida (Empate)";
                txttotal.Text = total.ToString();
            }
        }







        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            txtvoto.Clear();
            txtvencedor.Clear();
            txtvt.Clear();
            txtporcent.Clear();
            txttotal.Clear();
            txtvoto.Focus();
        }

        

        public frmvoto()
        {
            InitializeComponent();
        }



       

        
    }
}

        
    


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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmposto posto = new frmposto();
            this.Hide();
            posto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtabwhile tabwhile = new frmtabwhile();
            this.Hide();
            tabwhile.Show();
        }

        private void tabuadaDowhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabdowhile tabdowhile = new frmtabdowhile();
            tabdowhile.Show();
        }

        private void tabuadaForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabfor tabfor = new frmtabfor();
            tabfor.Show();
        }

        private void votoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmvoto voto = new frmvoto();
            voto.Show();
        }

        private void votoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmvoto voto = new frmvoto();
            voto.Show();
        }

        private void votoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmvoto voto = new frmvoto();
            voto.Show();
        }
    }
}

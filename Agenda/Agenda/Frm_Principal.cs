using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void detalheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pessoaisd inst_pes = new frm_pessoaisd();
            inst_pes.MdiParent = this;
            inst_pes.Show();
        }

        private void indvidualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PessoaisI inst_ind = new frm_PessoaisI();
            inst_ind.MdiParent = this;
            inst_ind.Show();
        }
    }
}
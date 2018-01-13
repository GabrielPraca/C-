using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEscolar
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadAluno inst = new FrmCadAluno();
            inst.MdiParent = this;
            inst.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatAluno inst = new FrmRelatAluno();
            inst.MdiParent = this;
            inst.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatProf inst = new FrmRelatProf();
            inst.MdiParent = this;
            inst.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProf inst = new FrmCadProf();
            inst.MdiParent = this;
            inst.Show();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsAluno inst = new FrmConsAluno();
            inst.MdiParent = this;
            inst.Show();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmConsProf inst = new FrmConsProf();
            inst.MdiParent = this;
            inst.Show();
        }
    }
}

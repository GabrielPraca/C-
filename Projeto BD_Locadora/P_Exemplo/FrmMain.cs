using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P_Exemplo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCli inst = new FrmCadCli();
            inst.MdiParent = this;
            inst.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsCli inst = new FrmConsCli();
            inst.MdiParent = this;
            inst.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFilm inst = new FrmCadFilm();
            inst.MdiParent = this;
            inst.Show();
        }

        private void filmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsFilm inst = new FrmConsFilm();
            inst.MdiParent = this;
            inst.Show();
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadGen inst = new FrmCadGen();
            inst.MdiParent = this;
            inst.Show();
        }

        private void gêneroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsGen inst = new FrmConsGen();
            inst.MdiParent = this;
            inst.Show();
        }

        private void distribuidoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadDist inst = new FrmCadDist();
            inst.MdiParent = this;
            inst.Show();
        }

        private void distribuidoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsDist inst = new FrmConsDist();
            inst.MdiParent = this;
            inst.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFunc inst = new FrmCadFunc();
            inst.MdiParent = this;
            inst.Show();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsFunc inst = new FrmConsFunc();
            inst.MdiParent = this;
            inst.Show();
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadEmp inst = new FrmCadEmp();
            inst.MdiParent = this;
            inst.Show();
        }

        private void empréstimoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsEmp inst = new FrmConsEmp();
            inst.MdiParent = this;
            inst.Show();
        }
    }
}

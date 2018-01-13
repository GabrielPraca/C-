using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro inst = new FrmCadastro();
            inst.MdiParent = this;
            inst.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta inst = new FrmConsulta();
            inst.MdiParent = this;
            inst.Show();
        }

        private void relatórioGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio inst = new FrmRelatorio();
            inst.MdiParent = this;
            inst.Show();
        }

        private void relatórioComConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioConsulta inst = new FrmRelatorioConsulta();
            inst.MdiParent = this;
            inst.Show();
        }
    }
}

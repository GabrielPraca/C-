using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulário_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FrmMDI = new Form2();
            FrmMDI.MdiParent = this;
            FrmMDI.Show();
        }
    }
}

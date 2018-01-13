using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmFim : Form
    {
        public FrmFim()
        {
            InitializeComponent();
        }

        private void FrmFim_Load(object sender, EventArgs e)
        {
            LblAcertos.Text = "" + FrmLoadScreen.acertos;
            LblErros.Text = "" + FrmLoadScreen.erros;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

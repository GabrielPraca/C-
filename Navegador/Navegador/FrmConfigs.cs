using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Navegador.Properties;

namespace Navegador
{
    public partial class FrmConfigs : Form
    {
        public FrmConfigs()
        {
            InitializeComponent();
        }

        private void FrmConfigs_Load(object sender, EventArgs e)
        {
            LblCor.BackColor = FrmNavegador.FormNavegador.CorBarFerramentas();
            TxtHP.Text = FrmNavegador.homePage;
        }

        private void LblCor_Click(object sender, EventArgs e)
        {
            if (DigCor.ShowDialog() == DialogResult.OK)
                LblCor.BackColor = DigCor.Color;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            FrmNavegador.homePage = TxtHP.Text;
            FrmNavegador.FormNavegador.CorBarFerramentas(LblCor.BackColor);
        }

        private void BtnPadrao_Click(object sender, EventArgs e)
        {
            LblCor.BackColor = FrmNavegador.corPadrao;
            TxtHP.Text = @"http://www.google.com.br";
        }

        private void BtnUrlAtual_Click(object sender, EventArgs e)
        {
            TxtHP.Text = FrmNavegador.FormNavegador.ObterUrlAtual();
        }
    }
}

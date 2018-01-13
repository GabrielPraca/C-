using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Validacoes;

namespace ValidaCPF
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnValidaCPF_Click(object sender, EventArgs e)
        {

            if (Validar.ValidarCPF(TxtCPF.Text))
                TxtCPF.BackColor = Color.FromArgb(200, 255, 200);
            else
                TxtCPF.BackColor = Color.FromArgb(255, 200, 200);
        }

        private void BtnValidaCNPJ_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarCNPJ(TxtCNPJ.Text))
                TxtCNPJ.BackColor = Color.FromArgb(200, 255, 200);
            else
                TxtCNPJ.BackColor = Color.FromArgb(255, 200, 200);
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            TxtCPF.BackColor = Color.White;
        }

        private void TxtCNPJ_TextChanged(object sender, EventArgs e)
        {
            TxtCNPJ.BackColor = Color.White;
        }

        private void TxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnValidaCPF.PerformClick();
                e.Handled = true;
            }
        }

        private void TxtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnValidaCNPJ.PerformClick();
                e.Handled = true;
            }
        }
    }
}

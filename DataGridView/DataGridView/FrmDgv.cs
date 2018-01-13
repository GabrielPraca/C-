using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class FrmDgv : Form
    {
        public FrmDgv()
        {
            InitializeComponent();
        }

        private bool VerificaCamposVazios()
        {
            TxtNome.Text = TxtNome.Text.Trim();
            TxtTel.Text = TxtTel.Text.Trim();
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Campo nome vazio.");
                return false;
            }
            else if (TxtTel.Text == "")
            {
                MessageBox.Show("Campo telefone vazio.");
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposVazios())
                return;
            DgvDados.Rows.Add(TxtNome.Text, TxtTel.Text);
            TxtNome.Clear();
            TxtTel.Clear();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DgvDados.Rows.Remove(DgvDados.CurrentRow);
                TxtNome.Clear();
                TxtTel.Clear();
            }
            catch { }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposVazios())
                return;
            try
            {
                DgvDados.Rows[DgvDados.CurrentRow.Index].Cells[0].Value = TxtNome.Text;
                DgvDados.Rows[DgvDados.CurrentRow.Index].Cells[1].Value = TxtTel.Text;
                TxtNome.Clear();
                TxtTel.Clear();
            }
            catch { }
        }

        private void DgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNome.Text = DgvDados.Rows[DgvDados.CurrentRow.Index].Cells[0].Value.ToString();
            TxtTel.Text = DgvDados.Rows[DgvDados.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}

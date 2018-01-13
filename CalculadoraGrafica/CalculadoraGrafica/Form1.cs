using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            if (!RdbSoma.Checked && !RdbSub.Checked && !RdbMult.Checked && !RdbDiv.Checked && !RdbRaiz.Checked && !RdbExpo.Checked)
                MessageBox.Show("Escolha a operação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (TxtV1.Text == "")
            {
                MessageBox.Show("O valor 1 está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtV1.Focus();
            }
            else if (TxtV2.Text == "" && !RdbRaiz.Checked)
            {
                MessageBox.Show("O valor 2 está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtV2.Focus();
            }
            else
            {
                try
                {
                    double v1 = 0, v2 = 0, res = 0;
                    v1 = double.Parse(TxtV1.Text);
                    if (!RdbRaiz.Checked)
                        v2 = double.Parse(TxtV2.Text);
                    else if (v1 < 0)
                    {
                        MessageBox.Show("Digite um número positivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (RdbDiv.Checked && v2 <= 0)
                    {
                        MessageBox.Show("Impossível dividir por zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (RdbSoma.Checked)
                        res = v1 + v2;
                    else if (RdbSub.Checked)
                        res = v1 - v2;
                    else if (RdbMult.Checked)
                        res = v1 * v2;
                    else if (RdbDiv.Checked)
                        res = v1 / v2;
                    else if (RdbRaiz.Checked)
                        res = Math.Sqrt(v1);
                    else if (RdbExpo.Checked)
                        res = Math.Pow(v1, v2);
                    LblRes.Text = "Resultado: " + String.Format("{0:0.##}", res);
                }
                catch
                {
                    MessageBox.Show("Digite valores numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RdbSoma_CheckedChanged(object sender, EventArgs e)
        {
            TxtV2.Enabled = true;
        }

        private void RdbSub_CheckedChanged(object sender, EventArgs e)
        {
            TxtV2.Enabled = true;
        }

        private void RdbMult_CheckedChanged(object sender, EventArgs e)
        {
            TxtV2.Enabled = true;
        }

        private void RdbDiv_CheckedChanged(object sender, EventArgs e)
        {
            TxtV2.Enabled = true;
        }

        private void RdbRaiz_CheckedChanged(object sender, EventArgs e)
        {
            TxtV2.Clear();
            TxtV2.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            TxtV2.Enabled = true;
        }

        private void TxtV1_TextChanged(object sender, EventArgs e)
        {
            TxtV1.Text = removerLetras(TxtV1.Text);
            TxtV1.Select(TxtV1.Height, TxtV1.Height);
        }

        private void TxtV2_TextChanged(object sender, EventArgs e)
        {
            TxtV2.Text = removerLetras(TxtV2.Text);
            TxtV2.Select(TxtV2.Height, TxtV2.Height);
        }

        private string removerLetras(string conteudo)
        {
            string strRetorna = "";
            for (int i = 0; i < conteudo.Length; i++)
                if (conteudo[i] >= '0' && conteudo[i] <= '9' || conteudo[i] == '.' || conteudo[i] == '-')
                    strRetorna += "" + conteudo[i];
            return strRetorna;
        }
    }
}

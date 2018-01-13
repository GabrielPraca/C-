using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcClass
{
    public partial class FrmMain : Form
    {
        Calculos calc = new Calculos();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtVal1.Text = TxtVal1.Text.Trim();
            TxtVal2.Text = TxtVal2.Text.Trim();

            if (TxtVal1.Text == "")
                MessageBox.Show("Campo valor 1 vazio.");
            else if (TxtVal2.Text == "")
                MessageBox.Show("Campo valor 2 vazio.");
            else if (RdbSoma.Checked)
            {
                calc.valor1 = float.Parse(TxtVal1.Text);
                calc.valor2 = float.Parse(TxtVal2.Text);
                LblResult.Text = "" + calc.Somar();
            }
            else if (RdbSubtrair.Checked)
            {
                calc.valor1 = float.Parse(TxtVal1.Text);
                calc.valor2 = float.Parse(TxtVal2.Text);
                calc.Subtrair();
                LblResult.Text = "" + calc.result;
            }
            else if (RdbMultiplicar.Checked)
                LblResult.Text = "" + calc.Multiplicar(float.Parse(TxtVal1.Text), (float)Convert.ToDouble(TxtVal2.Text));
            else if (RdbDividir.Checked)
            {
                calc.Dividir(float.Parse(TxtVal1.Text), float.Parse(TxtVal2.Text));
                LblResult.Text = "" + calc.result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa P = new Pessoa();
            //Instacia classe
            PessoaF PF = new PessoaF();
            PF.CarregarDados();
            MessageBox.Show(PF.MostrarDados());
            MessageBox.Show(P.MostrarNome("Anderson"));
        }
    }
}

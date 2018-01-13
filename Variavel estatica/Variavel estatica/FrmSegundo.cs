using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variavel_estatica
{
    public partial class FrmSegundo : Form
    {
        int cont = 0;

        public FrmSegundo()
        {
            InitializeComponent();
        }

        private void FrmSegundo_Load(object sender, EventArgs e)
        {
            timer.Start();
            LblNome.Text = FrmPrimeiro.nome;
            LblData.Text = DateTime.Now.ToString("dd/mm/yyyy MM:HH:SS");
            LblCont.Text = "" + cont;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cont++;
            LblData.Text = DateTime.Now.ToString("dd/mm/yyyy MM:HH:SS");
            LblCont.Text = "" + cont;
        }
    }
}

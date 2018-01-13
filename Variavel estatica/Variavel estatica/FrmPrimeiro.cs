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
    public partial class FrmPrimeiro : Form
    {
        public static string nome;

        public FrmPrimeiro()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            nome = TxtNome.Text;
            FrmSegundo InsSegundo = new FrmSegundo();
            InsSegundo.Show();
        }
    }
}

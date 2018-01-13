using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            string usuario = "André",
                   senha = "1234";
            if(TxdUsuario.Text == usuario && TxtSenha.Text == senha)
                MessageBox.Show("Seja Bem Vindo!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else{
                MessageBox.Show("Usuário ou Senha errado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}

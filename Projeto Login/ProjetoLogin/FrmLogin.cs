using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProjetoLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo)==DialogResult.Yes)
                Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from TBUsuario where usuario = @usuario and senha = @senha", con.Conectar());
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = TxtUsuario.Text;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = TxtSenha.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                ProjetoLogin.Properties.Settings.Default.UsuarioLogado = dr["usuario"].ToString();
                ProjetoLogin.Properties.Settings.Default.Privilegio = dr["privilegio"].ToString();
                dr.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }

        }
    }
}

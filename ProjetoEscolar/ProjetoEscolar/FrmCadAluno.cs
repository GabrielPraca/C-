using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoEscolar
{
    public partial class FrmCadAluno : Form
    {
        Conexao con = new Conexao();

        public FrmCadAluno()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "" ||
                TxtEnd.Text == "" ||
                TxtTelefone.Text == "")
            {
                MessageBox.Show("Há campo(s) vazio(s) verifique.");
                return;
            }
            SqlCommand cmd = new SqlCommand("insert into TB_Aluno values(@Nome, @End, @Tel)", con.Conectar());
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = TxtNome.Text;
            cmd.Parameters.Add("@End", SqlDbType.VarChar).Value = TxtEnd.Text;
            cmd.Parameters.Add("@Tel", SqlDbType.VarChar).Value = TxtTelefone.Text;
            cmd.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atividade
{
    public partial class FrmCadastro : Form
    {
        Conexao con = new Conexao();

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != "" ||
                TxtEnd.Text == "" ||
                TxtBairro.Text == "" ||
                TxtCidade.Text == "" ||
                TxtEstado.Text == "" ||
                TxtCPF.Text.Replace("_", "").Replace(".", "").Replace("-", "") == "" ||
                TxtTel.Text.Replace("_", "").Replace("-", "").Replace("(", "").Replace(")", "") == "")
                MessageBox.Show("Há campo(s) vazio(s).");
            else
            {
                try {
                    SqlCommand query = new SqlCommand("insert into TBCliente values (@nome, @end, " +
                                                      "@bairro, @cidade, @estado, @cpf, @tel)",
                                                      con.Conectar());
                    query.Parameters.Add("@nome", SqlDbType.VarChar).Value = TxtNome.Text;
                    query.Parameters.Add("@end", SqlDbType.VarChar).Value = TxtEnd.Text;
                    query.Parameters.Add("@bairro", SqlDbType.VarChar).Value = TxtBairro.Text;
                    query.Parameters.Add("@cidade", SqlDbType.VarChar).Value = TxtCidade.Text;
                    query.Parameters.Add("@estado", SqlDbType.VarChar).Value = TxtEstado.Text;
                    query.Parameters.Add("@cpf", SqlDbType.VarChar).Value = TxtCPF.Text;
                    query.Parameters.Add("@tel", SqlDbType.VarChar).Value = TxtTel.Text;
                    query.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch {
                    MessageBox.Show("Cadastro falhou!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Desconectar();
            }
        }
    }
}

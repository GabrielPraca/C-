using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P_Exemplo
{
    public partial class FrmCadCli : Form
    {
        public FrmCadCli()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            TxtCod.Text = TxtCod.Text.Trim();
            TxtNome.Text = TxtNome.Text.Trim();
            TxtTel.Text = TxtTel.Text.Trim();
            if (TxtCod.Text == "")
            {
                MessageBox.Show("Campo Código está vazio");
                return;
            }
            else if (TxtNome.Text == "")
            {
                MessageBox.Show("Campo Nome está vazio");
                return;
            }
            else if (TxtTel.Text == "")
            {
                MessageBox.Show("Campo Telefone está vazio");
                return;
            }
            try
            {
                Convert.ToInt32(TxtCod.Text);
            }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código");
                return;
            }

            Conexao conn = new Conexao();
            SqlCommand cmd = new SqlCommand("insert into TB_Cliente values(@Cod, @Nome, @Tel)", conn.Conectar());
            cmd.Parameters.Add("@Cod", SqlDbType.Int).Value = TxtCod.Text;
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = TxtNome.Text;
            cmd.Parameters.Add("@Tel", SqlDbType.VarChar).Value = TxtTel.Text;

            cmd.ExecuteNonQuery();
            TxtCod.Clear();
            TxtNome.Clear();
            TxtTel.Clear();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}

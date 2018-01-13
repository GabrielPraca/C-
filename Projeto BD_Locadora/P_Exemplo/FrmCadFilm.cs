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
    public partial class FrmCadFilm : Form
    {
        Conexao conn = new Conexao();

        public FrmCadFilm()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            TxtCod.Text = TxtCod.Text.Trim();
            TxTFilme.Text = TxTFilme.Text.Trim();
            TxtCodDist.Text = TxtCodDist.Text.Trim();
            TxtDuracao.Text = TxtDuracao.Text.Trim();

            if (TxtCod.Text == "")
            {
                MessageBox.Show("Campo Código está vazio");
                return;
            }
            else if (TxTFilme.Text == "")
            {
                MessageBox.Show("Campo Filme está vazio");
                return;
            }
            else if (TxtCodGen.Text == "")
            {
                MessageBox.Show("Campo Código Gênero está vazio");
                return;
            }
            else if (TxtCodDist.Text == "")
            {
                MessageBox.Show("Campo Código Distribuidora está vazio");
                return;
            }
            else if (TxtDuracao.Text == "")
            {
                MessageBox.Show("Campo Duração");
                return;
            }
            try { Convert.ToInt32(TxtCod.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código");
                return;
            }
            try { Convert.ToInt32(TxtCodGen.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código Gênero");
                return;
            }
            try { Convert.ToInt32(TxtCodDist.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código Distribuidora");
                return;
            }
            SqlCommand cmd = new SqlCommand("insert into TB_Filme values(@Cod, @Filme, @CodGen, @CodDist, @Duracao)", conn.Conectar());
            cmd.Parameters.Add("@Cod", SqlDbType.Int).Value = TxtCod.Text;
            cmd.Parameters.Add("@Filme", SqlDbType.VarChar).Value = TxTFilme.Text;
            cmd.Parameters.Add("@CodGen", SqlDbType.Int).Value = CmbGenero.SelectedValue;
            cmd.Parameters.Add("@CodDist", SqlDbType.Int).Value = TxtCodDist.Text;
            cmd.Parameters.Add("@Duracao", SqlDbType.VarChar).Value = TxtDuracao.Text;

            cmd.ExecuteNonQuery();
            TxtCod.Clear();
            TxTFilme.Clear();
            TxtCodGen.Clear();
            TxtCodDist.Clear();
            TxtDuracao.Clear();
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void FrmCadFilm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter DA = new SqlDataAdapter("", conn.Conectar());
        }
    }
}

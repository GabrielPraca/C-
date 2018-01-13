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
    public partial class FrmCadGen : Form
    {
        public FrmCadGen()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            TxtCod.Text = TxtCod.Text.Trim();
            TxtGen.Text = TxtGen.Text.Trim();
            if (TxtCod.Text == "")
            {
                MessageBox.Show("Campo Código está vazio");
                return;
            }
            else if (TxtGen.Text == "")
            {
                MessageBox.Show("Campo Gênero está vazio");
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
            SqlCommand cmd = new SqlCommand("insert into TB_Genero values(@Cod, @Gen)", conn.Conectar());
            cmd.Parameters.Add("@Cod", SqlDbType.Int).Value = TxtCod.Text;
            cmd.Parameters.Add("@Gen", SqlDbType.VarChar).Value = TxtGen.Text;

            cmd.ExecuteNonQuery();
            TxtCod.Clear();
            TxtGen.Clear();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}

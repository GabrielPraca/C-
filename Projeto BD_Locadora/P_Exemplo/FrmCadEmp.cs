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
    public partial class FrmCadEmp : Form
    {
        public FrmCadEmp()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            TxtCod.Text = TxtCod.Text.Trim();
            TxTDataEmp.Text = TxTDataEmp.Text.Trim();
            TxtCodCli.Text = TxtCodCli.Text.Trim();
            TxtCodFunc.Text = TxtCodFunc.Text.Trim();
            TxtDataDev.Text = TxtDataDev.Text.Trim();
            TxtCodFilme.Text = TxtCodFilme.Text.Trim();

            if (TxtCod.Text == "")
            {
                MessageBox.Show("Campo Código está vazio");
                return;
            }
            else if (TxTDataEmp.Text == "")
            {
                MessageBox.Show("Campo Data Empréstimo está vazio");
                return;
            }
            else if (TxtCodCli.Text == "")
            {
                MessageBox.Show("Campo Código Cliente está vazio");
                return;
            }
            else if (TxtCodFunc.Text == "")
            {
                MessageBox.Show("Campo Código Filme está vazio");
                return;
            }
            else if (TxtDataDev.Text == "")
            {
                MessageBox.Show("Campo Data Devolução");
                return;
            }
            else if (TxtCodFilme.Text == "")
            {
                MessageBox.Show("Campo Código Filme");
                return;
            }
            try { Convert.ToInt32(TxtCod.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código");
                return;
            }
            try { Convert.ToInt32(TxtCodCli.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código Cliente");
                return;
            }
            try { Convert.ToInt32(TxtCodFunc.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código Funcionário");
                return;
            }
            try { Convert.ToInt32(TxtCodFilme.Text); }
            catch
            {
                MessageBox.Show("Digite um valor numério no campo Código Filme");
                return;
            }

            Conexao conn = new Conexao();
            SqlCommand cmd = new SqlCommand("insert into TB_Emp values(@Cod, @DataEmp, @CodCli, @CodFunc, @DataDev, @CodFilm)", conn.Conectar());
            cmd.Parameters.Add("@Cod", SqlDbType.Int).Value = TxtCod.Text;
            cmd.Parameters.Add("@DataEmp", SqlDbType.VarChar).Value = TxTDataEmp.Text;
            cmd.Parameters.Add("@CodCli", SqlDbType.Int).Value = TxtCodCli.Text;
            cmd.Parameters.Add("@CodFunc", SqlDbType.Int).Value = TxtCodFunc.Text;
            cmd.Parameters.Add("@DataDev", SqlDbType.VarChar).Value = TxtDataDev.Text;
            cmd.Parameters.Add("@CodFilm", SqlDbType.Int).Value = TxtCodFilme.Text;

            cmd.ExecuteNonQuery();
            TxtCod.Clear();
            TxTDataEmp.Clear();
            TxtCodCli.Clear();
            TxtCodFunc.Clear();
            TxtDataDev.Clear();
            TxtCodFilme.Clear();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}

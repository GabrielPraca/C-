using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjetoLivraria
{
    public partial class FrmCadastro : Form
    {
        Conexao con = new Conexao();
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadAutor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into TB_Autor Values (@nome)", con.Conectar());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = TxtNAutor.Text;
            cmd.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            TxtNAutor.Clear();
        }

        private void BtnCadCli_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into TB_Cliente Values (@nome,@tel,@cep)", con.Conectar());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = TxtNCli.Text;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = TxtTCli.Text;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = TxtCCli.Text;
            cmd.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            TxtNCli.Clear();
            TxtTCli.Clear();
            TxtCCli.Clear();
        }

        private void BtnCadEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into TB_Editora Values (@nome, @contato)", con.Conectar());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = TxtNEditora.Text;
            cmd.Parameters.Add("@contato", SqlDbType.VarChar).Value = TxtConEdit.Text;
            cmd.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            TxtNEditora.Clear();
            TxtConEdit.Clear();
           
        }

        private void BtnCadLivro_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into TB_Livro Values (@Nome, @CodAutor, @CodEdit)", con.Conectar());
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = TxtNLivro.Text;
            cmd.Parameters.Add("@CodAutor", SqlDbType.Int).Value = TxtCodAuto.Text;
            cmd.Parameters.Add("@CodEdit", SqlDbType.Int).Value = TxtCodEdit.Text;
            cmd.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            TxtNLivro.Clear();
            TxtCodAuto.Clear();
            TxtCodEdit.Clear();
        }

        private void BtnCadVenda_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into TB_Venda Values (@Data, @CodCli, @CodLivro, @Valor)", con.Conectar());
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = TxtDataVenda.Text;
            cmd.Parameters.Add("@CodAutor", SqlDbType.Int).Value = TxtCodCli.Text;
            cmd.Parameters.Add("@CodEdit", SqlDbType.Int).Value = TxtCodLivro.Text;
            cmd.Parameters.Add("@Valor", SqlDbType.Money).Value = TxtValor.Text;
            cmd.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            TxtDataVenda.Clear();
            TxtCodCli.Clear();
            TxtCodLivro.Clear();
            TxtValor.Clear();
        }
    }
}

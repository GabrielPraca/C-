using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Exercicio
{
    public partial class FrmMain : Form
    {
        Conexao conn = new Conexao();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar inst = new FrmConsultar();
            inst.ShowDialog();
        }

        public void PreencherText(string Cod, string Tipo)
        {
            switch (Tipo)
            {
                case "Uso": TxtUsuario.Text = Cod; break;
                case "Liv": TxtLivro.Text = Cod; break;
                case "Fun": TxtFuncionario.Text = Cod; break;
            }
        }

        private void BtnSelectUsu_Click(object sender, EventArgs e)
        {
            FrmSelecao inst = new FrmSelecao("Uso", this);
            inst.ShowDialog();
        }

        private void BtnSelectLivro_Click(object sender, EventArgs e)
        {
            FrmSelecao inst = new FrmSelecao("Liv", this);
            inst.ShowDialog();
        }

        private void BtnSelecFun_Click(object sender, EventArgs e)
        {
            FrmSelecao inst = new FrmSelecao("Fun", this);
            inst.ShowDialog();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            TxtLivro.Text = TxtLivro.Text.Trim();
            if (TxtLivro.Text != "")
                LstEmp.Items.Add(TxtLivro.Text);
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (TxtCodEmp.Text == "")
            {
                MessageBox.Show("Código do empréstimo vazio.");
                return;
            }
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Campo usuário vazio.");
                return;
            }
            if (TxtFuncionario.Text == "")
            {
                MessageBox.Show("Campo funcionário vazio.");
                return;
            }

            SqlCommand query = new SqlCommand("insert into TB_Emprestimo values(@codemp, @data, @codusu, @codfun)", conn.Conectar());
            query.Parameters.Add("@codemp", SqlDbType.Int).Value = TxtCodEmp.Text;
            query.Parameters.Add("@data", SqlDbType.VarChar).Value = DateTime.Today.ToString();
            query.Parameters.Add("@codusu", SqlDbType.Int).Value = TxtUsuario.Text;
            query.Parameters.Add("@codfun", SqlDbType.Int).Value = TxtFuncionario.Text;
            query.ExecuteNonQuery();

            string squery = "";
            foreach (ListViewItem item in LstEmp.Items)
            {
                squery += "insert into TB_Item values(" + TxtCodEmp.Text + ", " + item.SubItems[0].Text + ");";
            }
            query.CommandText = squery;
            query.ExecuteNonQuery();
            conn.Desconectar();
            MessageBox.Show("Cadastrado com sucesso");
            TxtCodEmp.Clear();
        }
    }
}

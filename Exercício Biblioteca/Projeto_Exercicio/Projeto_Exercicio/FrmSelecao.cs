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
    public partial class FrmSelecao : Form
    {
        FrmMain Pai;
        string tipo;
        Conexao con = new Conexao();

        public FrmSelecao(string tipo, FrmMain Pai)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.Pai = Pai;
            SqlDataAdapter DA = new SqlDataAdapter("select * from " + TabelaPorTipo(tipo), con.Conectar());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DgvItens.DataSource = DS.Tables[0];
            con.Desconectar();
        }

        private string TabelaPorTipo(string Tipo)
        {
            switch (Tipo)
            {
                case "Uso": return "TB_Usuario";
                case "Liv": return "TB_Livro";
                case "Fun": return "TB_Funcionario";
            }
            return "";
        }

        private void DgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pai.PreencherText(DgvItens.SelectedRows[0].Cells[0].Value.ToString(), tipo);
            Close();
        }
    }
}

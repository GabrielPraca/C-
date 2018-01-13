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
    public partial class FrmConsulta : Form
    {
        Conexao con = new Conexao();

        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            CmbAutor.SelectedIndex = 0;
            CmbCli.SelectedIndex = 0;
            CmbEditor.SelectedIndex = 0;
            CmbLivro.SelectedIndex = 0;
            CmbVenda.SelectedIndex = 0;
        }

        private void BtnConAutor_Click(object sender, EventArgs e)
        {
            string busca;
            string campo = "";
            if (TxtFilAutor.Text == "")
                busca = "select * from TB_Autor";
            else
            {
                switch (CmbAutor.Text)
                {
                    case "Código":
                        campo = "codautor";
                        break;
                    case "Nome":
                        campo = "nomeautor";
                        break;
                }
                busca = "select * from TB_Autor where " + campo;
            }
            SqlDataAdapter DA = new SqlDataAdapter(busca + " " + TxtFilAutor.Text, con.Conectar());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DGVConsulta.DataSource = DS.Tables[0];
        }

        private void BtnConCli_Click(object sender, EventArgs e)
        {
            string busca;
            string campo = "";
            if (TxtFilCli.Text == "")
                busca = "select * from TB_Cliente";
            else
            {
                switch (CmbCli.Text)
                {
                    case "Código":
                        campo = "codcli";
                        break;
                    case "Nome":
                        campo = "nomecli";
                        break;
                }
                busca = "select * from TB_Cliente where " + campo;
            }
            SqlDataAdapter DA = new SqlDataAdapter(busca + " " + TxtFilCli.Text, con.Conectar());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DGVConsulta.DataSource = DS.Tables[0];
        }
    }
}
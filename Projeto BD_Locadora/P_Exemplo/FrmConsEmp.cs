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
    public partial class FrmConsEmp : Form
    {
        Conexao conn = new Conexao();
        string Filtro = "cli.NomeCli";

        public FrmConsEmp()
        {
            InitializeComponent();
        }

        private void FrmConsEmp_Load(object sender, EventArgs e)
        {
            AtualizarDGV("select emp.Cod_Emp, emp.Data_Emp, cli.NomeCli, fun.Nome_Func, fil.Filme " +
	                     "from TB_Emp as emp, TB_Cliente as cli, TB_Func as fun, TB_Filme as fil " +
                         "where	emp.Cod_Cli = cli.CodCli and emp.Cod_Func = fun.Cod_Func and emp.Cod_Film = fil.Cod_Filme");
        }

        private void AtualizarDGV(string Query)
        {
            SqlDataAdapter DA = new SqlDataAdapter(Query, conn.Conectar());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DgvConsuta.DataSource = DS.Tables[0];
            conn.Desconectar();
        }

        private void RdbCli_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCli.Checked)
                LblTConsulta.Text = "cli.NomeCli";
        }

        private void RdbFil_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbFil.Checked)
                LblTConsulta.Text = "Nome do Filme";
        }

        private void RdbFun_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbFun.Checked)
                LblTConsulta.Text = "Nome do Funcionário";
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (TxtConsulta.Text != "")
                AtualizarDGV("select emp.Cod_Emp as Código, emp.Data_Emp, cli.NomeCli, fun.Nome_Func, fil.Filme " +
                             "from TB_Emp as emp, TB_Cliente as cli, TB_Func as fun, TB_Filme as fil " +
                             "where emp.Cod_Cli = cli.CodCli and emp.Cod_Func = fun.Cod_Func and emp.Cod_Film = fil.Cod_Filme and " +
                             Filtro + " like '%" + TxtConsulta.Text + "%'");
            else
                FrmConsEmp_Load(null, null);
        }
    }
}

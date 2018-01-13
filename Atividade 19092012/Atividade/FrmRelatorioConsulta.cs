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
    public partial class FrmRelatorioConsulta : Form
    {
        Conexao con = new Conexao();

        public FrmRelatorioConsulta()
        {
            InitializeComponent();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            if (TxtBusca.Text == "")
                return;
            SqlDataAdapter DA = new SqlDataAdapter("select * from TBCliente where NomeCli like @busca", con.Conectar());
            DA.SelectCommand.Parameters.Add("@busca", SqlDbType.VarChar).Value = "%" + TxtBusca.Text + "%";
            DataSet DS = new DataSet();
            DA.Fill(DS);
            CR relatorio = new CR();
            relatorio.SetDataSource(DS.Tables[0]);
            CRViewer.ReportSource = relatorio;
            con.Desconectar();
        }
    }
}

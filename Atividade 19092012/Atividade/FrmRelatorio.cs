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
    public partial class FrmRelatorio : Form
    {
        Conexao con = new Conexao();

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            SqlDataAdapter DA = new SqlDataAdapter("select * from TBCliente", con.Conectar());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            CR relatorio = new CR();
            relatorio.SetDataSource(DS.Tables[0]);
            CRViewer.ReportSource = relatorio;
            con.Desconectar();
        }
    }
}

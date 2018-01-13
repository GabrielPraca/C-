using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProjetoEscolar
{
    public partial class FrmRelatProf : Form
    {
        Conexao con = new Conexao();

        public FrmRelatProf()
        {
            InitializeComponent();
        }

        private void FrmRelatProf_Load(object sender, EventArgs e)
        {
            SqlDataAdapter qry = new SqlDataAdapter("select * from TB_Professor", con.Conectar());
            DataSet DS = new DataSet();
            qry.Fill(DS);
            CRProf relatorio = new CRProf();
            relatorio.SetDataSource(DS.Tables[0]);
            CRVProf.ReportSource = relatorio;
            con.Desconectar();
        }
    }
}

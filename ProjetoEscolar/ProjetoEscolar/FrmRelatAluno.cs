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
    public partial class FrmRelatAluno : Form
    {
        public FrmRelatAluno()
        {
            InitializeComponent();
        }

        private void FrmRelatAluno_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            SqlDataAdapter qry = new SqlDataAdapter("select * from TB_Aluno", con.Conectar());
            DataSet DS = new DataSet();
            qry.Fill(DS);
            CRAluno relatorio = new CRAluno();
            relatorio.SetDataSource(DS.Tables[0]);
            CRVAluno.ReportSource = relatorio;
            con.Desconectar();
        }
    }
}

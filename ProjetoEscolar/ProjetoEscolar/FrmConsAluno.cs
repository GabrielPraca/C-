using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoEscolar
{
    public partial class FrmConsAluno : Form
    {
        Conexao con = new Conexao();

        public FrmConsAluno()
        {
            InitializeComponent();
            BuscaTudo();
        }

        private void BuscaTudo()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from TB_Aluno", con.Conectar());
            DataSet DS = new DataSet();
            cmd.Fill(DS);
            DGVAlunos.DataSource = DS.Tables[0];
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (TxtFiltro.Text == "")
            {
                BuscaTudo();
                return;
            }

            SqlDataAdapter cmd = new SqlDataAdapter("select * from TB_Aluno where Nome_Aluno like '%" + TxtFiltro.Text + "%'", con.Conectar());
            DataSet DS = new DataSet();
            cmd.Fill(DS);
            DGVAlunos.DataSource = DS.Tables[0];
            con.Desconectar();
        }
    }
}

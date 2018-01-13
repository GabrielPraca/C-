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
    public partial class FrmConsDist : Form
    {
        Conexao conn = new Conexao();

        public FrmConsDist()
        {
            InitializeComponent();
        }

        private void AtualizarDGV(string Query)
        {
            SqlDataAdapter DA = new SqlDataAdapter(Query, conn.Conectar());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DgvConsuta.DataSource = DS.Tables[0];
            conn.Desconectar();
        }

        private void FrmConsDist_Load(object sender, EventArgs e)
        {
            AtualizarDGV("select * from TB_Distribuidora");
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != "")
                AtualizarDGV("select * from TB_Distribuidora where Nome_Dis like '%" + TxtNome.Text + "%'");
            else
                AtualizarDGV("select * from TB_Cliente");
        }
    }
}

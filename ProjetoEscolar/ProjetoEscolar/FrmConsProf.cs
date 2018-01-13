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
    public partial class FrmConsProf : Form
    {
        Conexao con = new Conexao();

        public FrmConsProf()
        {
            InitializeComponent();
            BuscaTudo();
        }

        private void BuscaTudo()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from TB_Professor", con.Conectar());
            DataSet DS = new DataSet();
            cmd.Fill(DS);
            DGVProf.DataSource = DS.Tables[0];
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (TxtFiltro.Text == "")
            {
                BuscaTudo();
                return;
            }

            SqlDataAdapter cmd = new SqlDataAdapter("select * from TB_Professor where Nome_Prof like '%"+TxtFiltro.Text+"%'", con.Conectar());
            DataSet DS = new DataSet();
            cmd.Fill(DS);
            DGVProf.DataSource = DS.Tables[0];
            con.Desconectar();
        }
    }
}

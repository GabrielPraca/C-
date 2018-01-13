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
    public partial class FrmConsulta : Form
    {
        Conexao con = new Conexao();

        public FrmConsulta()
        {
            InitializeComponent();
            CmbCampo.SelectedIndex = 0;
            AtualizaGrid("", "");
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid(CmbCampo.Text, TxtBusca.Text);
        }

        private void AtualizaGrid(string Campo, string Busca)
        {
            SqlDataAdapter DA = new SqlDataAdapter("select * from TBCliente", con.Conectar());
            if (Busca != "")
            {
                DA.SelectCommand.CommandText += " where " + Campo + "cli like @busca";
                DA.SelectCommand.Parameters.Add("@busca", SqlDbType.VarChar).Value = "%" + Busca + "%";
            }
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DgvSaida.DataSource = DS.Tables[0];
            con.Desconectar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Exercicio
{
    public partial class FrmConsultar : Form
    {
        Conexao con = new Conexao();

        public FrmConsultar()
        {
            InitializeComponent();
            BtnBuscar_Click(null, null);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("select itm.CodEmprestimo, liv.NomeLivro from TB_Emprestimo as emp " +
                                                       "join TB_Item as itm on itm.CodEmprestimo = emp.CodEmprestimo " +
                                                       "join TB_Livro as liv on liv.CodLivro = itm.CodLivro", con.Conectar());
                if (TxtCodigo.Text != "")
                    DA.SelectCommand.CommandText += "where emp.CodEmprestimo = " + TxtCodigo.Text;
                DataSet DS = new DataSet();
                DA.Fill(DS);
                DgvEmprestimos.DataSource = DS.Tables[0];
            }
            catch { }
            con.Desconectar();
        }
    }
}

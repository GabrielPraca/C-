using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Atividade
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDAtividade;Data Source=(local)");

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public SqlConnection Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}

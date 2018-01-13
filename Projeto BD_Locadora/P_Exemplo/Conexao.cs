using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace P_Exemplo
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_Locadora;Data Source=(local)");

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
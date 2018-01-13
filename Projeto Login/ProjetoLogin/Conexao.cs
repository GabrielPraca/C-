using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoLogin
{
    class Conexao
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAB1-MICRO12\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True");

        public SqlConnection Conectar()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public SqlConnection Desconectar()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return conn;
        }
    }
}

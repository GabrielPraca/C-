using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoEscolar
{
    class Conexao
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAB1-M20\SQLEXPRESS;Initial Catalog=BD_Escolar;Integrated Security=True");

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

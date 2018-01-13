using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_Exercicio
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_Biblioteca;Data Source=PCVISTA\WIN8");

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                return con;
            }
            else
            {
                return con;
            }
        }

        public SqlConnection Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                return con;
            }
            else
            {
                return con;
            }
        }
    }
}

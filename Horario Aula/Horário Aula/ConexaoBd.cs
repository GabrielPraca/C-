using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ini;
using MySql.Data.MySqlClient;

namespace Horario_Aula
{
    public static class ConexaoBd
    {
        public static MySqlConnection Conexao;
        static INI CongFile = new INI(Application.StartupPath + "\\cfg.ini");

        static ConexaoBd()
        {
            string conStr = "Server=" + CongFile.LerValor("MySql", "Server") +
                            ";Port=" + CongFile.LerValor("MySql", "Port") +
                            ";Database=" + CongFile.LerValor("MySql", "Database") +
                            ";Uid=" + CongFile.LerValor("MySql", "Uid") +
                            ";Pwd=" + CongFile.LerValor("MySql", "Pwd") + ";";
            Conexao = new MySqlConnection(conStr);
        }
    }
}
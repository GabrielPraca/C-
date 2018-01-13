using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoClasses
{
    class PessoaF:Pessoa
    {
        public string CPF { get; set; }

        public void CarregarDados()
        {
            Nome = "Anderson";
            Tel = "4444-5555";
            CPF = "123456";
        }

        public string MostrarDados()
        {
            string msg = Nome + Tel + CPF;
            return msg;
        }
    }
}
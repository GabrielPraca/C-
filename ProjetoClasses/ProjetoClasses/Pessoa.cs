using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoClasses
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string MostrarNome(string _Nome)
        {
            return _Nome;
        }
    }
}

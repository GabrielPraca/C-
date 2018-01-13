using System;
using System.Collections.Generic;
using System.Text;

namespace Endereco_IP
{
    public class Endereco
    {
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public Endereco(string Pais) : this(Pais, null) { }

        public Endereco(string Pais, string Estado) : this(Pais, Estado, null) { }

        public Endereco(string Pais, string Estado, string Cidade) : this(Pais, Estado, Cidade, null) { }

        public Endereco(string Pais, string Estado, string Cidade, string Bairro)
        {
            this.Pais = Pais;
            this.Estado = Estado;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
        }
    }
}

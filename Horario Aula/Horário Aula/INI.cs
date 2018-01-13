using System.Text;
using System.Runtime.InteropServices;

namespace System.IO.Ini
{
    class INI
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        string Caminho;

        public INI(string Caminho)
        {
            this.Caminho = Caminho;
        }

        public string LerValor(string Secao, string Entrada)
        {
            StringBuilder buffer = new StringBuilder(256);
            if (GetPrivateProfileString(Secao, Entrada, "", buffer, 256, Caminho) != 0)
                return buffer.ToString();
            else
                return null;
        }

        public bool EscreverValor(string Secao, string Entrada, string Valor)
        {
            return WritePrivateProfileString(Secao, Entrada, Valor, Caminho);
        }
    }
}

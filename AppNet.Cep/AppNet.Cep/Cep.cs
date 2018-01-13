using System;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppNet
{
    delegate void CepConcluidoEventHandler(DataTable Endereco);

    class Cep
    {
        delegate string DownloadString(string url);

        public event CepConcluidoEventHandler GetEnderecoConcluido;

        public void AsyncGetEndereco(string CEP)
        {
            Thread Th = new Thread(new ThreadStart(() => {
                DataTable Endereco = GetEndereco(CEP);

                
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        public DataTable GetEndereco(string CEP)
        {
            WebClient Cliente = new WebClient();
            DownloadString AsyncDownloadString = new DownloadString(Cliente.DownloadString);

            try
            {
                IAsyncResult AsyncResultado = AsyncDownloadString.BeginInvoke("http://www.appnet.com.br/cep/?cep=" + CEP, null, null);

                if (AsyncResultado.AsyncWaitHandle.WaitOne(15000))
                {
                    string Resultado = AsyncDownloadString.EndInvoke(AsyncResultado);
                    DataTable DT = new DataTable();
                    List<object> Itens = new List<object>();

                    try
                    {
                        int offset = Resultado.IndexOf('{') + 1;
                        char[] Numeros = { '0', '1' };

                        while (true)
                        {
                            string Nome = GetProximoItem(ref Resultado, ref offset);

                            if (Nome.ToLower() == "resultado")
                            {
                                DT.Columns.Add(Nome, typeof(bool));
                                offset = Resultado.IndexOfAny(Numeros, offset);
                                Itens.Add(Resultado[offset++] == '1' ? true : false);
                            }
                            else
                            {
                                DT.Columns.Add(Nome, typeof(string));
                                Itens.Add(GetProximoItem(ref Resultado, ref offset));
                            }

                            if (Resultado.IndexOf('\"', offset) == -1)
                                break;
                        }
                    }
                    catch { }

                    DT.Rows.Add(Itens.ToArray());
                    return DT;
                }
            }
            catch { }

            Cliente.Dispose();

            return null;
        }

        string GetProximoItem(ref string Texto, ref int offset)
        {
            offset = Texto.IndexOf('\"', offset) + 1;
            int Length = Texto.IndexOf('\"', offset) - offset;
            offset += Length + 1;

            return Texto.Substring(offset - Length - 1, Length);
        }
    }
}

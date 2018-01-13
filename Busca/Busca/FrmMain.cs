using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Busca
{
    public partial class FrmMain : Form
    {
        string caminho = "C:\\";
        Thread thBusca;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnEscolher_Click(object sender, EventArgs e)
        {
            if (FbdCaminho.ShowDialog() == DialogResult.OK)
            {
                caminho = FbdCaminho.SelectedPath;
                LblPath.Text = "Procurar em: " + caminho;
            }
        }

        private void addResultado(string[] param)
        {
            ListViewItem item = new ListViewItem(param[0]);
            item.SubItems.Add(param[1]);
            item.SubItems.Add(param[2]);
            item.SubItems.Add(param[3]);
            LstConteudo.Items.Add(item);
            Text = "Busca (" + LstConteudo.Items.Count + ") - Procurando...";
        }

        private void ThBuscar(object param)
        {
            string[] bparam = (string[])param;
            Invoke((MethodInvoker)delegate { LstConteudo.Items.Clear(); Text = "Busca (0) - Procurando..."; });

            DirectoryInfo Path = new DirectoryInfo(bparam[0]);
            Procurar(Path, bparam[1]);
            Invoke((MethodInvoker)delegate { Text = "Busca (" + LstConteudo.Items.Count + ")"; });
        }

        private void Procurar(DirectoryInfo Path, string Busca)
        {
            try
            {
                DirectoryInfo[] Pastas = Path.GetDirectories();
                FileInfo[] Arquivos = Path.GetFiles();

                foreach (FileInfo Arquivo in Arquivos)
                {
                    if (Arquivo.Name.ToLower().Contains(Busca))
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            addResultado(new string[] {
                        "(Arquivo) " + Arquivo.Name,
                        Arquivo.FullName,
                        Arquivo.Length + " bytes",
                        Arquivo.LastWriteTime.ToString() });
                        });
                    }
                }

                foreach (DirectoryInfo Pasta in Pastas)
                {
                    if (Pasta.Name.ToLower().Contains(Busca))
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            addResultado(new string[] {
                        "(Pasta) " + Pasta.Name,
                        Pasta.FullName,
                        "",
                        Pasta.LastWriteTime.ToString() });
                        });
                    }
                    Procurar(Pasta, Busca);
                }
            }
            catch { }
        }

        private void LstConteudo_DoubleClick(object sender, EventArgs e)
        {
            if (LstConteudo.SelectedItems.Count > 0)
                try { System.Diagnostics.Process.Start("explorer", "/select, \"" + LstConteudo.SelectedItems[0].SubItems[1].Text + "\""); }
                catch { }
        }

        private void PararBusca()
        {
            Invoke((MethodInvoker)delegate { LstConteudo.Items.Clear(); Text = "Busca (0)"; });
        }

        private void TxtProcura_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminho) || TxtProcura.Text == "")
            {
                if (thBusca != null)
                    thBusca.Abort();
                new Thread(new ThreadStart(PararBusca)).Start();
            }
            else
            {
                if (thBusca != null)
                    thBusca.Abort();

                thBusca = new Thread(new ParameterizedThreadStart(ThBuscar));
                thBusca.IsBackground = true;
                thBusca.Priority = ThreadPriority.BelowNormal;
                thBusca.Start(new string[] { caminho, TxtProcura.Text.ToLower() });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using MySql.Data.MySqlClient;

namespace Horario_Aula
{
    public partial class FrmLoadScreen : Form
    {
        public FrmLoadScreen()
        {
            InitializeComponent();

            Inicializar();
        }

        void Inicializar()
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                MySqlCommand query = null;
                StreamReader sReader = null;

                //Abre a conexão
                ChangeStatusText("Conectando...");
                do
                {
                    try
                    {
                        ConexaoBd.Conexao.Open();
                    }
                    catch
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            if (MessageBox.Show("Falha ao tentar se conectar com o banco de dados.", "Falha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                                Application.Exit();
                        });
                    }
                } while (ConexaoBd.Conexao.State == ConnectionState.Closed);

                //Cria a estrutura do banco se necessário
                ChangeStatusText("Fazendo manutenção...");
                try
                {
                    sReader = new StreamReader(Application.StartupPath + "\\Manutenção.sql");
                    query = new MySqlCommand(sReader.ReadToEnd(), ConexaoBd.Conexao);
                    sReader.Dispose();
                    query.ExecuteNonQuery();
                    query.Dispose();
                }
                catch(MySqlException e)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        if (MessageBox.Show("Falha ao excutar o script de manutenção.\n\nErro:\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            if (sReader != null)
                                sReader.Dispose();
                            if (query != null)
                                query.Dispose();
                        }
                    });
                    Application.Exit();
                    return;
                }

                //Abre a tela principal
                Thread ThInvis = new Thread(new ThreadStart(() =>
                {
                    ChangeFormVisible(false);
                }));

                ThInvis.Start();
                Invoke((MethodInvoker)delegate
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                });
                Application.Exit();
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        void ChangeStatusText(string Texto)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { ChangeStatusText(Texto); });
                return;
            }

            LblStatus.Text = Texto;
        }

        void ChangeFormVisible(bool Visivel)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { ChangeFormVisible(Visivel); });
                return;
            }

            this.Visible = Visivel;
        }
    }
}

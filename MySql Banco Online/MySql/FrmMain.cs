using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using MySql.Data.MySqlClient;

namespace MySql
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            MysqlConectar();
        }

        public void MysqlConectar()
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                try
                {
                    Invoke((MethodInvoker)delegate { Text = "Teste Mysql - Conectando..."; });
                    //MySQL.ConexaoBd = new MySqlConnection("Server=db4free.net;Port=3306;Database=yurisim;Uid=yurisim;Pwd=hesoyam4;");
                    MySQL.ConexaoBd = new MySqlConnection("Server=db4free.net;Port=3306;Database=horarioaula;Uid=horarioaula;Pwd=horarioaula2014;");
                    MySQL.ConexaoBd.Open();

                    Invoke((MethodInvoker)delegate { Text = "Teste Mysql - Fazendo manutenção..."; });

                    MySqlCommand query = new MySqlCommand("create table if not exists Pessoa(CodPessoa int unsigned not null auto_increment, Nome varchar(256), Idade smallint unsigned, primary key(CodPessoa))", MySQL.ConexaoBd);
                    query.ExecuteNonQuery();
                    query.Dispose();

                    MySQL.ConexaoBd.Close();

                    Invoke((MethodInvoker)delegate
                    {
                        Text = "Teste Mysql";
                        Enabled = true;
                        AtualizarLista();
                    });
                }
                catch (Exception e)
                {
                    if (MySQL.ConexaoBd != null)
                        MySQL.ConexaoBd.Close();

                    Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Não foi possível se conectar!\n " + e);
                        Application.Exit();
                    });
                }
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        public void AtualizarLista()
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    LstDados.Enabled = BtnAdicionar.Enabled = BtnAtualizar.Enabled = false;
                });

                try
                {
                    MySQL.ConexaoBd.Open();

                    MySqlDataAdapter queryDA = new MySqlDataAdapter("select * from Pessoa", MySQL.ConexaoBd);
                    DataSet DS = new DataSet();
                    queryDA.Fill(DS);
                    queryDA.Dispose();
                    MySQL.ConexaoBd.Close();

                    List<ListViewItem> itens = new List<ListViewItem>();
                    foreach (DataRow Linha in DS.Tables[0].Rows)
                        itens.Add(new ListViewItem(new string[] { Linha.ItemArray[1].ToString(), Linha.ItemArray[2].ToString() }));
                    DS.Dispose();

                    Invoke((MethodInvoker)delegate
                    {
                        LstDados.Items.Clear();
                        LstDados.Items.AddRange(itens.ToArray());
                        Text = "Teste MySql - (" + itens.Count + ") Registros"; 
                    });
                }
                catch { MySQL.ConexaoBd.Close(); }

                Invoke((MethodInvoker)delegate
                {
                    LstDados.Enabled = BtnAdicionar.Enabled = BtnAtualizar.Enabled = true;
                });
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                if (TxtNome.Text.Length == 0)
                    return;

                Invoke((MethodInvoker)delegate
                {
                    LstDados.Enabled = BtnAdicionar.Enabled = BtnAtualizar.Enabled = false;
                });

                try
                {
                    MySQL.ConexaoBd.Open();

                    MySqlCommand query = new MySqlCommand("insert into Pessoa(Nome, Idade) values(@Nome, @Idade)", MySQL.ConexaoBd);
                    query.Parameters.Add(new MySqlParameter("@Nome", MySqlDbType.VarChar)).Value = TxtNome.Text;
                    query.Parameters.Add(new MySqlParameter("@Idade", MySqlDbType.UInt16)).Value = NumIdade.Value;
                    query.ExecuteNonQuery();
                    MySQL.ConexaoBd.Close();
                }
                catch { MySQL.ConexaoBd.Close(); }

                Invoke((MethodInvoker)delegate
                {
                    AtualizarLista();
                    TxtNome.Clear();
                    NumIdade.Value = 0;
                });
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAdicionar_Click(null, null);
                e.Handled = true;
            }
        }
    }
}
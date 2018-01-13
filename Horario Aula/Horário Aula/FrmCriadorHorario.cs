using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Horario_Aula
{
    public partial class FrmCriadorHorario : Form
    {
        Label[] lblEtapas;
        byte idEtapa = 1;
        byte max_idEtapa = 1;

        uint CodHorario = 0;

        /// <summary>
        /// Cria um novo horário
        /// </summary>
        public FrmCriadorHorario()
        {
            InitializeComponent();

            lblEtapas = new Label[] { LblEtapa1, LblEtapa2, LblEtapa3, LblEtapa4 };

            CarregarEpata(idEtapa, false);
        }

        /// <summary>
        /// Edita um Horário
        /// </summary>
        /// <param name="CodHorario"></param>
        public FrmCriadorHorario(uint CodHorario)
        {
            InitializeComponent();

            lblEtapas = new Label[] { LblEtapa1, LblEtapa2, LblEtapa3, LblEtapa4 };

            this.CodHorario = CodHorario;
            CarregarEpata(idEtapa, true);
        }

        void CarregarEpata(byte idEtapa, bool CarregarValores)
        {
            this.idEtapa = idEtapa;
            if (max_idEtapa < idEtapa)
                max_idEtapa = idEtapa;
            Control frmEtapa = new FrmCarregandoEtapa();
            frmEtapa.Dock = DockStyle.Fill;
            ContainerSwitchControl(frmEtapa);
            
            Thread Th = new Thread(new ThreadStart(() =>
            {
                switch (idEtapa)
                {
                    case 1:
                        SetTitulo("Horário");
                        FrmEtapa1 frmEtapa1 = new FrmEtapa1();
                        frmEtapa = frmEtapa1;
                        frmEtapa1.OnSave += new FrmEtapa1.OnSaveEventHandler(Etapa1Onsave);
                        if (CarregarValores)
                        {
                            MySqlCommand query = new MySqlCommand("select Nome from Horario where CodHorario = @codHorario", ConexaoBd.Conexao);
                            MySqlDataReader DR = null;
                            try
                            {
                                query.Parameters.AddWithValue("@codHorario", CodHorario);
                                DR = query.ExecuteReader();
                                DR.Read();
                                if (DR.HasRows)
                                    frmEtapa1.PreencherCampos(DR.GetString("Nome"));
                            }
                            catch { }
                            if (DR != null)
                                DR.Dispose();
                            query.Dispose();
                        }
                        break;
                    case 2:
                        SetTitulo("Form 2");
                        FrmEtapa2 frmEtapa2 = new FrmEtapa2();
                        frmEtapa = frmEtapa2;
                        //frmEtapa2.OnSave += new FrmEtapa2.OnSaveEventHandler(Etapa2Onsave);
                        if (CarregarValores)
                        {
                            MySqlCommand query = new MySqlCommand("select Nome from Horario where CodHorario = @codHorario", ConexaoBd.Conexao);
                            MySqlDataReader DR = null;
                            try
                            {
                                query.Parameters.AddWithValue("@codHorario", CodHorario);
                                DR = query.ExecuteReader();
                                DR.Read();
                                if (DR.HasRows)
                                    frmEtapa2.PreencherCampos(DR.GetString("Nome"));
                            }
                            catch { }
                            if (DR != null)
                                DR.Dispose();
                            query.Dispose();
                        }
                        break;
                }

                HabilitarIndicadoresEtapas();
                //Habilita a etapa
                if (frmEtapa != null)
                {
                    frmEtapa.Dock = DockStyle.Fill;
                    ContainerSwitchControl(frmEtapa);
                }
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        void ContainerSwitchControl(Control _Control)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { ContainerSwitchControl(_Control); });
                return;
            }

            PnlContainer.Controls.Add(_Control);
            while (PnlContainer.Controls.Count > 1)
                PnlContainer.Controls[0].Dispose();
        }

        void SetTitulo(string Texto)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { SetTitulo(Texto); });
                return;
            }

            LblTitulo.Text = Texto;
        }

        private void LblTitulo_TextChanged(object sender, EventArgs e)
        {
            Label Lbl = sender as Label;
            Lbl.Left = Lbl.Parent.Width / 2 - Lbl.Width / 2;
        }

        void HabilitarIndicadoresEtapas()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { HabilitarIndicadoresEtapas(); });
                return;
            }

            for (int i = 0; i < 4; i++)
                lblEtapas[i].ForeColor = i < max_idEtapa ? Color.White : Color.Brown;

            ImgIndicadorEtapa.Top = lblEtapas[idEtapa - 1].Top;
            ImgIndicadorEtapa.Visible = true;
        }

        void Etapa1Onsave(FrmEtapa1.FrmEtapa1EventArgs e)
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                Control frmEtapa = new FrmCarregandoEtapa();
                frmEtapa.Dock = DockStyle.Fill;
                ContainerSwitchControl(frmEtapa);

                MySqlCommand query = new MySqlCommand("insert into Horario(Nome) value(@nome);", ConexaoBd.Conexao);
                try
                {
                    query.Parameters.AddWithValue("@nome", e.Nome);
                    query.ExecuteNonQuery();
                    CodHorario = (uint)query.LastInsertedId;
                }
                catch { }
                query.Dispose();

                CarregarEpata(2, true);
            }));

            Th.IsBackground = true;
            Th.Start();
        }
    }
}
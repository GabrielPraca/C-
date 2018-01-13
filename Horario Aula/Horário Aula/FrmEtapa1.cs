using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horario_Aula
{
    public partial class FrmEtapa1 : UserControl
    {
        public delegate void OnSaveEventHandler(FrmEtapa1EventArgs e);
        public OnSaveEventHandler OnSave;

        public FrmEtapa1()
        {
            InitializeComponent();
        }

        public void PreencherCampos(string Nome)
        {
            TxtNome.Text = Nome;
        }

        private void BtnSalvarContinuar_Click(object sender, EventArgs e)
        {
            FrmEtapa1EventArgs _e = new FrmEtapa1EventArgs();
            _e.Nome = TxtNome.Text;

            OnSave(_e);
        }

        public struct FrmEtapa1EventArgs
        {
            public string Nome;
        }
    }
}
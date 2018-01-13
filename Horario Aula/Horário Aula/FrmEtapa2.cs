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
    public partial class FrmEtapa2 : UserControl
    {
        public delegate void OnSaveEventHandler(FrmEtapa2EventArgs e);
        public OnSaveEventHandler OnSave;

        public FrmEtapa2()
        {
            InitializeComponent();
        }

        public void PreencherCampos(string Nome)
        {
            //TxtNome.Text = Nome;
        }

        private void BtnSalvarContinuar_Click(object sender, EventArgs e)
        {
            FrmEtapa2EventArgs _e = new FrmEtapa2EventArgs();
            //_e.Nome = TxtNome.Text;

            OnSave(_e);
        }

        public struct FrmEtapa2EventArgs
        {
            public string Nome;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horario_Aula
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnNovoHorario_MouseClick(object sender, MouseEventArgs e)
        {
            FrmCriadorHorario Frm = new FrmCriadorHorario();
            Frm.ShowDialog();
            Frm.Dispose();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traduza
{
    public partial class FrmFim : Form
    {
        public FrmFim()
        {
            InitializeComponent();
        }

        public void RecebeGanhador(string Nome1)
        {
            if (Nome1 == "Null:Null")
            {
                LblInfo.Text = "Empate";
                LblGanhador.Visible = false;
                LblInfo.Location = new Point(this.Width / 2 - LblInfo.Width / 2, this.Height / 2 - LblInfo.Height / 2);
            }
            else
                LblGanhador.Text = Nome1;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            FrmTraduza inst = new FrmTraduza();
            inst.Show();
            Dispose();
        }
    }
}

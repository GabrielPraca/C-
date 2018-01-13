using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmLoadScreen : Form
    {
        public static int acertos = 0, erros = 0;
        string statusAnim = "Opacidade++";

        public FrmLoadScreen()
        {
            InitializeComponent();
        }

        private void FrmLoadScreen_Load(object sender, EventArgs e)
        {
            Tempo.Start();
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            if (statusAnim == "Opacidade++")
            {
                this.Opacity += 0.01;
                if (this.Opacity == 1.0)
                {
                    Tempo.Interval = 30;
                    ImgRaio.Visible = true;
                    BarLoadStatus.Visible = true;
                    statusAnim = "Barra++";
                }
            }
            else
            {
                BarLoadStatus.Value = BarLoadStatus.Value + 1;
                if (BarLoadStatus.Value == 100)
                {
                    Tempo.Stop();
                    FrmPergunta1 insForm = new FrmPergunta1();
                    insForm.Show();
                    this.Hide();
                }
            }
        }
    }
}

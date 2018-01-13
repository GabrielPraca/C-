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
    public partial class FrmMain : Form
    {
        byte pedindo = 1;
        byte statusAnim = 0;
        Point posNormalTxt, posNormalLbl;

        public static string nome1, nome2;

        public FrmMain()
        {
            InitializeComponent();
            posNormalTxt = TxtNome.Location;
            posNormalLbl = LblInfo.Location;
        }

        private void TimAnim_Tick(object sender, EventArgs e)
        {
            switch (statusAnim)
            {
                case 1:
                    if (TxtNome.Location.X < this.Width)
                        TxtNome.Location = new Point(TxtNome.Location.X + 4, TxtNome.Location.Y);
                    if (LblInfo.Location.Y + LblInfo.Height > 0)
                        LblInfo.Location = new Point(LblInfo.Location.X, LblInfo.Location.Y - 1);
                    if (TxtNome.Location.X >= this.Width && LblInfo.Location.Y + LblInfo.Height <= 0)
                    {
                        statusAnim++;
                        LblInfo.Text = "Jogador 2";
                        TxtNome.Clear();
                    }
                    break;
                case 2:
                    if (TxtNome.Location.X > posNormalTxt.X)
                    {
                        TxtNome.Location = new Point(TxtNome.Location.X - 4, TxtNome.Location.Y);
                        if (TxtNome.Location.X < posNormalTxt.X)
                            new Point(posNormalTxt.X, posNormalTxt.Y);
                    }
                    if (LblInfo.Location.Y < posNormalLbl.Y)
                    {
                        LblInfo.Location = new Point(LblInfo.Location.X, LblInfo.Location.Y + 1);
                        if (LblInfo.Location.Y > posNormalLbl.Y)
                            new Point(posNormalLbl.X, posNormalLbl.Y);
                    }
                    if (TxtNome.Location == posNormalTxt && LblInfo.Location == posNormalLbl)
                        TimAnim.Stop();
                    break;
                case 3:
                    this.Opacity -= 0.1;
                    if (this.Opacity == 0)
                    {
                        FrmTraduza inst = new FrmTraduza();
                        inst.Show();
                        TimAnim.Stop();
                        Hide();
                    }
                    break;
            }
        }

        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                if (pedindo == 1)
                {
                    TxtNome.Text = TxtNome.Text.Trim();
                    if (TxtNome.Text == "")
                    {
                        TxtNome.BackColor = Color.FromArgb(255, 230, 230);
                        return;
                    }
                    TxtNome.BackColor = Color.White;
                    nome1 = TxtNome.Text;
                    statusAnim++;
                    pedindo++;
                    TimAnim.Start();
                }
                else if (pedindo == 2 && !TimAnim.Enabled)
                {
                    TxtNome.Text = TxtNome.Text.Trim();
                    if (TxtNome.Text == "")
                    {
                        TxtNome.BackColor = Color.FromArgb(255, 230, 230);
                        return;
                    }
                    nome2 = TxtNome.Text;
                    TxtNome.BackColor = Color.White;
                    statusAnim++;
                    TimAnim.Start();
                }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                e.Handled = true;
        }
    }
}

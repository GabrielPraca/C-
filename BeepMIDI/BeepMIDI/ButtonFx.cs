using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BeepMIDI
{
    public partial class ButtonFx : UserControl
    {
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateRoundRectRgn(int X, int Y, int Width, int Height, int WEllipse, int HEllipse);

        Color cor,
              pressedColor = Color.FromArgb(255, 128, 0),
              enterColor = Color.Firebrick;
        int ponta = 5;
        bool MousePressed = false;

        public ButtonFx()
        {
            InitializeComponent();
            cor = this.BackColor;
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            cor = this.BackColor;
            this.Invalidate();
        }

        [Description("Texto exibido no botão")]
        [Category("Appearance")]
        public string Texto
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                this.Invalidate();
            }
        }

        [Description("Cor do botão quando estiver pressionado")]
        [Category("Appearance")]
        public Color PressedColor
        {
            get
            {
                return pressedColor;
            }

            set
            {
                pressedColor = value;
                this.Invalidate();
            }
        }

        [Description("Cor do botão quando estiver com o mouse por cima")]
        [Category("Appearance")]
        public Color EnterColor
        {
            get
            {
                return enterColor;
            }

            set
            {
                enterColor = value;
                this.Invalidate();
            }
        }

        [Description("Tamanho do arredondamento do botão")]
        [Category("Appearance")]
        public int Ponta
        {
            get
            {
                return ponta;
            }

            set
            {
                ponta = value;
                this.Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            cor = enterColor; this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cor = pressedColor; MousePressed = true; this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cor = enterColor; MousePressed = false; this.Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            cor = this.BackColor; this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width + 1, this.Height + 1, ponta, ponta));
            LinearGradientBrush lBrush = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height / 2 + (MousePressed ? this.Height / 8 : 0)), Color.FromArgb(150, Color.White), Color.FromArgb(60, Color.White), LinearGradientMode.Vertical);
            SizeF TextoLen = e.Graphics.MeasureString(Texto, base.Font);
            Brush TextoB = new SolidBrush(base.ForeColor);

            e.Graphics.Clear(cor);
            e.Graphics.DrawString(Texto, base.Font, TextoB, this.Width / 2 - TextoLen.Width / 2, this.Height / 2 - TextoLen.Height / 2);
            e.Graphics.FillRectangle(lBrush, 0, 0, this.Width, this.Height / 2 + (MousePressed ? this.Height / 8 : 0));

            lBrush.Dispose();
            TextoB.Dispose();
            //this.Region.Dispose();
        }
    }
}

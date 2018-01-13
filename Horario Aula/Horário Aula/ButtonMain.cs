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
    public partial class ButtonMain : UserControl
    {
        bool MouseOver = false;

        string _Text;
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("ButtonMain")]
        public override string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                UpdateBuffer();
                Refresh();
            }
        }

        Color _FocusColor = Color.SkyBlue;
        [Browsable(true)]
        [Description("Cor de fundo quando o botão está em foco.")]
        [DefaultValue(typeof(Color), "SkyBlue")]
        public Color FocusColor
        {
            get { return _FocusColor; }
            set
            {
                _FocusColor = value;
                UpdateBuffer();
                Refresh();
            }
        }

        Bitmap imgBuffer;
        Graphics gBuffer;

        public ButtonMain()
        {
            InitializeComponent();

            imgBuffer = new Bitmap(this.Width, this.Height);
            gBuffer = Graphics.FromImage(imgBuffer);
            UpdateBuffer();
        }

        void UpdateBuffer()
        {
            if (this.Width == 0 || this.Height == 0)
                return;
            if (imgBuffer.Width != this.Width || imgBuffer.Height != this.Height)
            {
                imgBuffer.Dispose();
                gBuffer.Dispose();

                imgBuffer = new Bitmap(this.Width, this.Height);
                gBuffer = Graphics.FromImage(imgBuffer);
            }

            //Background Color
            gBuffer.Clear(MouseOver ? this.FocusColor : this.BackColor);

            RectangleF ImgPosition = new RectangleF();
            float Proporcao;
            Size Tamanho = this.Size;
            SizeF FontSize = gBuffer.MeasureString(Text, this.Font);
            Tamanho.Height -= (int)FontSize.Height;

            if (this.BackgroundImage != null)
            {
                if (this.BackgroundImage.Width > this.BackgroundImage.Height)
                    Proporcao = this.BackgroundImage.Width / this.BackgroundImage.Height;
                else
                    Proporcao = this.BackgroundImage.Height / this.BackgroundImage.Width;

                if (Tamanho.Width > Tamanho.Height)
                {
                    ImgPosition.Height = Tamanho.Height;
                    ImgPosition.Width = ImgPosition.Height * Proporcao;
                    ImgPosition.X = Tamanho.Width / 2 - ImgPosition.Width / 2;
                    ImgPosition.Y = 0;
                }
                else
                {
                    ImgPosition.Width = Tamanho.Width;
                    ImgPosition.Height = ImgPosition.Width * Proporcao;
                    ImgPosition.X = 0;
                    ImgPosition.Y = Tamanho.Height / 2 - ImgPosition.Height / 2;
                }
                //Desenha a imagem de fundo
                gBuffer.DrawImage(this.BackgroundImage, ImgPosition);
            }
            //Desenha o texto
            gBuffer.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.Width / 2 - FontSize.Width / 2, this.Height - FontSize.Height);

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgBuffer, e.ClipRectangle, new Rectangle(0, 0, imgBuffer.Width, imgBuffer.Height), GraphicsUnit.Pixel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            imgBuffer.Dispose();
            gBuffer.Dispose();
            base.Dispose(disposing);
        }

        //Eventos que fazem com que tenha que atualizar o Buffer de imagem
        protected override void OnMouseEnter(EventArgs e)
        {
            MouseOver = true;
            UpdateBuffer();
            Refresh();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            MouseOver = false;
            UpdateBuffer();
            Refresh();
            base.OnMouseLeave(e);
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            UpdateBuffer();
            base.OnBackgroundImageChanged(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            UpdateBuffer();
            base.OnForeColorChanged(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            UpdateBuffer();
            base.OnFontChanged(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateBuffer();
            base.OnSizeChanged(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            UpdateBuffer();
            base.OnBackColorChanged(e);
        }
    }
}

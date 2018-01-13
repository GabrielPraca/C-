using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Imagens.Properties;

namespace Imagens
{
    public partial class FrmImagem : Form
    {
        bool Trancado = false;
        bool Aberto = true;

        public FrmImagem()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (!Trancado)
            {
                Aberto = true;
                ImgPortao.Image = Resources.opened;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (Aberto)
            {
                Aberto = false;
                ImgPortao.Image = Resources.closed;
            }
        }

        private void BtnTrancar_Click(object sender, EventArgs e)
        {
            if (!Aberto)
            {
                Trancado = true;
                ImgPortao.Image = Resources.locked;
            }
        }

        private void BtnDestrancar_Click(object sender, EventArgs e)
        {
            if (Trancado)
            {
                Trancado = false;
                ImgPortao.Image = Resources.closed;
            }
        }
    }
}

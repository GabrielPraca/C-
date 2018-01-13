using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Editor_de_Texto
{
    public partial class FrmEditor : Form
    {
        string TextoAnterior = "";
        StreamWriter arquivoSalvar = null;

        public FrmEditor()
        {
            InitializeComponent();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtEdicao.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtEdicao.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtEdicao.Paste();
        }

        private void tudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtEdicao.SelectAll();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FdgFonte.ShowDialog() == DialogResult.OK)
                TxtEdicao.Font = FdgFonte.Font;
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CdgCorFonte.ShowDialog() == DialogResult.OK)
                TxtEdicao.ForeColor = CdgCorFonte.Color;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextoAnterior != TxtEdicao.Text)
                if (MessageBox.Show("Deseja salvar as alterações?", "Editor de Texto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    salvarToolStripMenuItem.PerformClick();
                else if (!DialogResult.Cancel)
                    Application.Exit();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arquivoSalvar == null)
                if (SdgSalvar.ShowDialog() != DialogResult.OK)
                    return;
            arquivoSalvar = new StreamWriter(SdgSalvar.FileName);
            arquivoSalvar.Write(TxtEdicao.Text);
            arquivoSalvar.Close();
            TextoAnterior = TxtEdicao.Text;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader arquivo;
            if (AdgAbrir.ShowDialog() == DialogResult.OK)
            {
                arquivo = new StreamReader(AdgAbrir.FileName);
                TxtEdicao.Text = arquivo.ReadToEnd();
                arquivo.Close();
                TextoAnterior = TxtEdicao.Text;
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem.PerformClick();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtEdicao.Clear();
            arquivoSalvar = null;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            novoToolStripMenuItem.PerformClick();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            recortarToolStripMenuItem.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            colarToolStripMenuItem.PerformClick();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            salvarToolStripMenuItem.PerformClick();
        }
    }
}
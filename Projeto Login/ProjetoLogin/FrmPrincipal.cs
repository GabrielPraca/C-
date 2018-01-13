using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja faze logoff", "logoff", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                consultaToolStripMenuItem.Enabled = false;
                cadastroToolStripMenuItem.Enabled = false;
                LogintoolStripMenuItem1.Enabled = true;
                logoffToolStripMenuItem.Enabled = false;
                LblUsuario.Text = "Nenhum Usuário Logado";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPrincipal_Load(null, null);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin inst = new FrmLogin();
            inst.ShowDialog();
            if (ProjetoLogin.Properties.Settings.Default.Privilegio != "n")
            {
                if (ProjetoLogin.Properties.Settings.Default.Privilegio == "urs")
                {
                    consultaToolStripMenuItem.Enabled = true;
                    logoffToolStripMenuItem.Enabled = true;
                    LogintoolStripMenuItem1.Enabled = false;
                }
                if (ProjetoLogin.Properties.Settings.Default.Privilegio == "administrador")
                {
                    consultaToolStripMenuItem.Enabled = true;
                    cadastroToolStripMenuItem.Enabled = true;
                    LogintoolStripMenuItem1.Enabled = false;
                    logoffToolStripMenuItem.Enabled = true;
                }
                LblUsuario.Text = ProjetoLogin.Properties.Settings.Default.UsuarioLogado;
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            MessageBox.Show(e.CloseReason.ToString());         
        }
    }
}

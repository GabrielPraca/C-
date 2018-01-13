namespace Navegador
{
    partial class FrmNavegador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavegador));
            this.TspFerramentas = new System.Windows.Forms.ToolStrip();
            this.BtnConfigs = new System.Windows.Forms.ToolStripButton();
            this.Separador = new System.Windows.Forms.ToolStripSeparator();
            this.TxtProcura = new System.Windows.Forms.ToolStripTextBox();
            this.BtnVotar = new System.Windows.Forms.ToolStripButton();
            this.BtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.TxtEndereco = new System.Windows.Forms.ToolStripTextBox();
            this.BtnIr = new System.Windows.Forms.ToolStripButton();
            this.BtnParAtu = new System.Windows.Forms.ToolStripButton();
            this.BtnHome = new System.Windows.Forms.ToolStripButton();
            this.BtnProcurar = new System.Windows.Forms.ToolStripButton();
            this.TimTempo = new System.Windows.Forms.Timer(this.components);
            this.WebNavegador = new System.Windows.Forms.WebBrowser();
            this.TimHome3Seg = new System.Windows.Forms.Timer(this.components);
            this.TspFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TspFerramentas
            // 
            this.TspFerramentas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TspFerramentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TspFerramentas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.TspFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConfigs,
            this.Separador,
            this.TxtProcura,
            this.BtnVotar,
            this.BtnVoltar,
            this.TxtEndereco,
            this.BtnIr,
            this.BtnParAtu,
            this.BtnHome,
            this.BtnProcurar});
            this.TspFerramentas.Location = new System.Drawing.Point(0, 415);
            this.TspFerramentas.Name = "TspFerramentas";
            this.TspFerramentas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TspFerramentas.Size = new System.Drawing.Size(874, 32);
            this.TspFerramentas.TabIndex = 0;
            this.TspFerramentas.Text = "Ferramentas";
            // 
            // BtnConfigs
            // 
            this.BtnConfigs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnConfigs.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfigs.Image")));
            this.BtnConfigs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConfigs.Name = "BtnConfigs";
            this.BtnConfigs.Size = new System.Drawing.Size(29, 29);
            this.BtnConfigs.Text = "Configurações";
            this.BtnConfigs.Click += new System.EventHandler(this.BtnConfigs_Click);
            // 
            // Separador
            // 
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(6, 32);
            // 
            // TxtProcura
            // 
            this.TxtProcura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtProcura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProcura.Name = "TxtProcura";
            this.TxtProcura.Size = new System.Drawing.Size(100, 32);
            this.TxtProcura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProcura_KeyDown);
            // 
            // BtnVotar
            // 
            this.BtnVotar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnVotar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnVotar.Image = global::Navegador.Properties.Resources.BtnAvançar;
            this.BtnVotar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVotar.Name = "BtnVotar";
            this.BtnVotar.Size = new System.Drawing.Size(29, 29);
            this.BtnVotar.Text = "Avançar";
            this.BtnVotar.Click += new System.EventHandler(this.BtnVotar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnVoltar.Image = global::Navegador.Properties.Resources.BtnVoltar;
            this.BtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(29, 29);
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TxtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(450, 32);
            this.TxtEndereco.Text = "http://www.google.com.br";
            this.TxtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEndereco_KeyDown);
            // 
            // BtnIr
            // 
            this.BtnIr.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnIr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnIr.Image = global::Navegador.Properties.Resources.BtnIr;
            this.BtnIr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIr.Name = "BtnIr";
            this.BtnIr.Size = new System.Drawing.Size(29, 29);
            this.BtnIr.Text = "Ir";
            this.BtnIr.Click += new System.EventHandler(this.BtnIr_Click);
            // 
            // BtnParAtu
            // 
            this.BtnParAtu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnParAtu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnParAtu.Image = global::Navegador.Properties.Resources.BtnAtualizar;
            this.BtnParAtu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnParAtu.Name = "BtnParAtu";
            this.BtnParAtu.Size = new System.Drawing.Size(29, 29);
            this.BtnParAtu.Text = "Atualizar";
            this.BtnParAtu.Click += new System.EventHandler(this.BtnParAtu_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnHome.Image = global::Navegador.Properties.Resources.BtnHome;
            this.BtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(29, 29);
            this.BtnHome.Text = "Página Inicial";
            this.BtnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnHome_MouseDown);
            this.BtnHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnHome_MouseUp);
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnProcurar.Image = global::Navegador.Properties.Resources.BtnProcurar;
            this.BtnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(29, 29);
            this.BtnProcurar.Text = "Procurar com Google";
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // TimTempo
            // 
            this.TimTempo.Enabled = true;
            this.TimTempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // WebNavegador
            // 
            this.WebNavegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebNavegador.Location = new System.Drawing.Point(0, 0);
            this.WebNavegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebNavegador.Name = "WebNavegador";
            this.WebNavegador.Size = new System.Drawing.Size(874, 415);
            this.WebNavegador.TabIndex = 1;
            this.WebNavegador.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebNavegador_DocumentCompleted);
            this.WebNavegador.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebNavegador_Navigating);
            this.WebNavegador.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WebNavegador_PreviewKeyDown);
            // 
            // TimHome3Seg
            // 
            this.TimHome3Seg.Interval = 3000;
            this.TimHome3Seg.Tick += new System.EventHandler(this.TimHome3Seg_Tick);
            // 
            // FrmNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 447);
            this.Controls.Add(this.WebNavegador);
            this.Controls.Add(this.TspFerramentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D# Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Navegador_Load);
            this.TspFerramentas.ResumeLayout(false);
            this.TspFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TspFerramentas;
        private System.Windows.Forms.ToolStripButton BtnVoltar;
        private System.Windows.Forms.ToolStripButton BtnVotar;
        private System.Windows.Forms.ToolStripTextBox TxtEndereco;
        private System.Windows.Forms.ToolStripButton BtnIr;
        private System.Windows.Forms.ToolStripButton BtnParAtu;
        private System.Windows.Forms.Timer TimTempo;
        private System.Windows.Forms.WebBrowser WebNavegador;
        private System.Windows.Forms.ToolStripButton BtnHome;
        private System.Windows.Forms.ToolStripTextBox TxtProcura;
        private System.Windows.Forms.ToolStripButton BtnProcurar;
        private System.Windows.Forms.ToolStripButton BtnConfigs;
        private System.Windows.Forms.ToolStripSeparator Separador;
        private System.Windows.Forms.Timer TimHome3Seg;
    }
}


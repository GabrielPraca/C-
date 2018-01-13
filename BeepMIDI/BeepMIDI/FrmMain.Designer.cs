namespace BeepMIDI
{
    partial class FrmMain
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
            this.FdOpen = new System.Windows.Forms.OpenFileDialog();
            this.NumFaixa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BarVeloc = new System.Windows.Forms.TrackBar();
            this.PnlNotas = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPlay = new BeepMIDI.ButtonFx();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarVeloc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FdOpen
            // 
            this.FdOpen.Filter = "Arquivo MIDI (*.mid)|*.mid;";
            // 
            // NumFaixa
            // 
            this.NumFaixa.Location = new System.Drawing.Point(134, 31);
            this.NumFaixa.Name = "NumFaixa";
            this.NumFaixa.Size = new System.Drawing.Size(57, 20);
            this.NumFaixa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faixa:";
            // 
            // BarVeloc
            // 
            this.BarVeloc.Location = new System.Drawing.Point(193, 23);
            this.BarVeloc.Name = "BarVeloc";
            this.BarVeloc.Size = new System.Drawing.Size(95, 45);
            this.BarVeloc.TabIndex = 4;
            this.BarVeloc.Value = 5;
            // 
            // PnlNotas
            // 
            this.PnlNotas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlNotas.Location = new System.Drawing.Point(12, 57);
            this.PnlNotas.Name = "PnlNotas";
            this.PnlNotas.Size = new System.Drawing.Size(268, 43);
            this.PnlNotas.TabIndex = 5;
            this.PnlNotas.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlNotas_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPlay.EnterColor = System.Drawing.Color.Firebrick;
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Location = new System.Drawing.Point(12, 28);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Ponta = 5;
            this.BtnPlay.PressedColor = System.Drawing.Color.Red;
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Texto = "Reproduzir";
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(292, 112);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.PnlNotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumFaixa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BarVeloc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beep MIDI";
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarVeloc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FdOpen;
        private System.Windows.Forms.NumericUpDown NumFaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar BarVeloc;
        private System.Windows.Forms.Panel PnlNotas;
        private ButtonFx BtnPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;

    }
}


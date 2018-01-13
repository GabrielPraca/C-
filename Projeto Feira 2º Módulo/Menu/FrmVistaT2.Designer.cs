namespace Menu
{
    partial class FrmVistaT2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaT2));
            this.LblTempo = new System.Windows.Forms.Label();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.BtnProx = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblLetras = new System.Windows.Forms.Label();
            this.LblCerto = new System.Windows.Forms.Label();
            this.LblInformacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.White;
            this.LblTempo.Location = new System.Drawing.Point(165, 15);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 16;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(43, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 15;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(12, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblLetras
            // 
            this.LblLetras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLetras.AutoSize = true;
            this.LblLetras.BackColor = System.Drawing.Color.Transparent;
            this.LblLetras.Location = new System.Drawing.Point(87, 112);
            this.LblLetras.Name = "LblLetras";
            this.LblLetras.Size = new System.Drawing.Size(488, 195);
            this.LblLetras.TabIndex = 20;
            this.LblLetras.Text = resources.GetString("LblLetras.Text");
            // 
            // LblCerto
            // 
            this.LblCerto.BackColor = System.Drawing.Color.Transparent;
            this.LblCerto.Location = new System.Drawing.Point(423, 229);
            this.LblCerto.Margin = new System.Windows.Forms.Padding(0);
            this.LblCerto.Name = "LblCerto";
            this.LblCerto.Size = new System.Drawing.Size(10, 14);
            this.LblCerto.TabIndex = 21;
            this.LblCerto.Text = "C";
            this.LblCerto.Click += new System.EventHandler(this.LblCerto_Click);
            // 
            // LblInformacao
            // 
            this.LblInformacao.AutoSize = true;
            this.LblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacao.ForeColor = System.Drawing.Color.White;
            this.LblInformacao.Location = new System.Drawing.Point(200, 69);
            this.LblInformacao.Name = "LblInformacao";
            this.LblInformacao.Size = new System.Drawing.Size(250, 25);
            this.LblInformacao.TabIndex = 22;
            this.LblInformacao.Text = "Ache e click na letra C";
            // 
            // FrmVistaT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.LblInformacao);
            this.Controls.Add(this.LblCerto);
            this.Controls.Add(this.LblLetras);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.BtnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVistaT2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVistaT3_Load);
            this.SizeChanged += new System.EventHandler(this.FrmVistaT3_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVistaT2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblLetras;
        private System.Windows.Forms.Label LblCerto;
        private System.Windows.Forms.Label LblInformacao;
    }
}
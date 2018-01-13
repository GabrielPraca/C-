namespace Menu
{
    partial class FrmPsicT2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPsicT2));
            this.LblFundoKick = new System.Windows.Forms.Label();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnProx = new System.Windows.Forms.Button();
            this.TimAnim = new System.Windows.Forms.Timer(this.components);
            this.LblInformacao = new System.Windows.Forms.Label();
            this.Rdb4 = new System.Windows.Forms.RadioButton();
            this.Rdb5 = new System.Windows.Forms.RadioButton();
            this.Rdb6 = new System.Windows.Forms.RadioButton();
            this.Rdb7 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LblFundoKick
            // 
            this.LblFundoKick.BackColor = System.Drawing.Color.White;
            this.LblFundoKick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFundoKick.Location = new System.Drawing.Point(260, 15);
            this.LblFundoKick.Name = "LblFundoKick";
            this.LblFundoKick.Size = new System.Drawing.Size(16, 16);
            this.LblFundoKick.TabIndex = 0;
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Enabled = true;
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.Black;
            this.LblTempo.Location = new System.Drawing.Point(121, 15);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 20;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(12, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 19;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(40, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 18;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // TimAnim
            // 
            this.TimAnim.Enabled = true;
            this.TimAnim.Interval = 10;
            this.TimAnim.Tick += new System.EventHandler(this.TimAnim_Tick);
            // 
            // LblInformacao
            // 
            this.LblInformacao.AutoSize = true;
            this.LblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacao.ForeColor = System.Drawing.Color.Black;
            this.LblInformacao.Location = new System.Drawing.Point(0, 40);
            this.LblInformacao.Name = "LblInformacao";
            this.LblInformacao.Size = new System.Drawing.Size(582, 25);
            this.LblInformacao.TabIndex = 21;
            this.LblInformacao.Text = "Quantas carteiras de motorista estão kicando na tela?";
            // 
            // Rdb4
            // 
            this.Rdb4.AutoSize = true;
            this.Rdb4.Location = new System.Drawing.Point(282, 12);
            this.Rdb4.Name = "Rdb4";
            this.Rdb4.Size = new System.Drawing.Size(75, 17);
            this.Rdb4.TabIndex = 22;
            this.Rdb4.TabStop = true;
            this.Rdb4.Text = "4 Carteiras";
            this.Rdb4.UseVisualStyleBackColor = true;
            // 
            // Rdb5
            // 
            this.Rdb5.AutoSize = true;
            this.Rdb5.Location = new System.Drawing.Point(354, 12);
            this.Rdb5.Name = "Rdb5";
            this.Rdb5.Size = new System.Drawing.Size(75, 17);
            this.Rdb5.TabIndex = 23;
            this.Rdb5.TabStop = true;
            this.Rdb5.Text = "5 Carteiras";
            this.Rdb5.UseVisualStyleBackColor = true;
            // 
            // Rdb6
            // 
            this.Rdb6.AutoSize = true;
            this.Rdb6.Location = new System.Drawing.Point(426, 12);
            this.Rdb6.Name = "Rdb6";
            this.Rdb6.Size = new System.Drawing.Size(75, 17);
            this.Rdb6.TabIndex = 24;
            this.Rdb6.TabStop = true;
            this.Rdb6.Text = "6 Carteiras";
            this.Rdb6.UseVisualStyleBackColor = true;
            // 
            // Rdb7
            // 
            this.Rdb7.AutoSize = true;
            this.Rdb7.Location = new System.Drawing.Point(498, 12);
            this.Rdb7.Name = "Rdb7";
            this.Rdb7.Size = new System.Drawing.Size(75, 17);
            this.Rdb7.TabIndex = 25;
            this.Rdb7.TabStop = true;
            this.Rdb7.Text = "7 Carteiras";
            this.Rdb7.UseVisualStyleBackColor = true;
            // 
            // FrmPsicT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 69);
            this.Controls.Add(this.Rdb7);
            this.Controls.Add(this.Rdb6);
            this.Controls.Add(this.Rdb5);
            this.Controls.Add(this.Rdb4);
            this.Controls.Add(this.LblInformacao);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.LblFundoKick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPsicT2";
            this.Text = "FrmPisicT2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FrmPsicT2_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPsicT2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFundoKick;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Timer TimAnim;
        private System.Windows.Forms.Label LblInformacao;
        private System.Windows.Forms.RadioButton Rdb4;
        private System.Windows.Forms.RadioButton Rdb5;
        private System.Windows.Forms.RadioButton Rdb6;
        private System.Windows.Forms.RadioButton Rdb7;
    }
}
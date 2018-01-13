namespace Menu
{
    partial class FrmPsicT3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPsicT3));
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblPalavra = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnProx = new System.Windows.Forms.Button();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.LblLocalTempo = new System.Windows.Forms.Label();
            this.TimLocalTempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(3, 35);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(751, 25);
            this.LblInfo.TabIndex = 0;
            this.LblInfo.Text = "Escolha a Alternativa que descreve a cor da palavra mostrada abaixo:";
            // 
            // LblPalavra
            // 
            this.LblPalavra.AutoSize = true;
            this.LblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPalavra.ForeColor = System.Drawing.Color.Blue;
            this.LblPalavra.Location = new System.Drawing.Point(110, 60);
            this.LblPalavra.Name = "LblPalavra";
            this.LblPalavra.Size = new System.Drawing.Size(231, 71);
            this.LblPalavra.TabIndex = 1;
            this.LblPalavra.Text = "Branco";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.ForeColor = System.Drawing.Color.Black;
            this.Lbl1.Location = new System.Drawing.Point(22, 131);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(192, 53);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "Amarelo";
            this.Lbl1.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.BackColor = System.Drawing.Color.Black;
            this.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl2.Location = new System.Drawing.Point(22, 184);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(167, 53);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "Branco";
            this.Lbl2.Click += new System.EventHandler(this.Lbl2_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.ForeColor = System.Drawing.Color.Red;
            this.Lbl3.Location = new System.Drawing.Point(22, 237);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(113, 53);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "Azul";
            this.Lbl3.Click += new System.EventHandler(this.Lbl3_Click);
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.BackColor = System.Drawing.Color.Black;
            this.Lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.ForeColor = System.Drawing.Color.White;
            this.Lbl4.Location = new System.Drawing.Point(305, 131);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(132, 53);
            this.Lbl4.TabIndex = 5;
            this.Lbl4.Text = "Preto";
            this.Lbl4.Click += new System.EventHandler(this.Lbl4_Click);
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.ForeColor = System.Drawing.Color.Blue;
            this.Lbl5.Location = new System.Drawing.Point(220, 184);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(217, 53);
            this.Lbl5.TabIndex = 6;
            this.Lbl5.Text = "Vermelho";
            this.Lbl5.Click += new System.EventHandler(this.Lbl5_Click);
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.ForeColor = System.Drawing.Color.Lime;
            this.Lbl6.Location = new System.Drawing.Point(293, 237);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(144, 53);
            this.Lbl6.TabIndex = 7;
            this.Lbl6.Text = "Verde";
            this.Lbl6.Click += new System.EventHandler(this.Lbl6_Click);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.Black;
            this.LblTempo.Location = new System.Drawing.Point(119, 12);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 23;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(10, 9);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 22;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(38, 9);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 21;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Enabled = true;
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // LblLocalTempo
            // 
            this.LblLocalTempo.AutoSize = true;
            this.LblLocalTempo.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalTempo.ForeColor = System.Drawing.Color.Red;
            this.LblLocalTempo.Location = new System.Drawing.Point(323, 82);
            this.LblLocalTempo.Name = "LblLocalTempo";
            this.LblLocalTempo.Size = new System.Drawing.Size(125, 41);
            this.LblLocalTempo.TabIndex = 24;
            this.LblLocalTempo.Text = "00 seg";
            // 
            // TimLocalTempo
            // 
            this.TimLocalTempo.Enabled = true;
            this.TimLocalTempo.Interval = 1000;
            this.TimLocalTempo.Tick += new System.EventHandler(this.TimLocalTempo_Tick);
            // 
            // FrmPsicT3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 302);
            this.Controls.Add(this.LblLocalTempo);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.Lbl6);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.LblPalavra);
            this.Controls.Add(this.LblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPsicT3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPsicT3_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FrmPsicT3_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblPalavra;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.Label LblLocalTempo;
        private System.Windows.Forms.Timer TimLocalTempo;
    }
}
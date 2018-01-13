namespace Quiz
{
    partial class FrmPergunta3
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
            this.LblContagem = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnReponder = new System.Windows.Forms.Button();
            this.RdbResp4 = new System.Windows.Forms.RadioButton();
            this.RdbResp3 = new System.Windows.Forms.RadioButton();
            this.RdbResp2 = new System.Windows.Forms.RadioButton();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.RdbResp1 = new System.Windows.Forms.RadioButton();
            this.LblPergunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblContagem
            // 
            this.LblContagem.AutoSize = true;
            this.LblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblContagem.Location = new System.Drawing.Point(164, 83);
            this.LblContagem.Name = "LblContagem";
            this.LblContagem.Size = new System.Drawing.Size(29, 20);
            this.LblContagem.TabIndex = 15;
            this.LblContagem.Text = "10";
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTempo.Location = new System.Drawing.Point(150, 60);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(63, 20);
            this.LblTempo.TabIndex = 14;
            this.LblTempo.Text = "Tempo";
            // 
            // BtnReponder
            // 
            this.BtnReponder.Location = new System.Drawing.Point(138, 113);
            this.BtnReponder.Name = "BtnReponder";
            this.BtnReponder.Size = new System.Drawing.Size(75, 23);
            this.BtnReponder.TabIndex = 13;
            this.BtnReponder.Text = "&Responder";
            this.BtnReponder.UseVisualStyleBackColor = true;
            this.BtnReponder.Click += new System.EventHandler(this.BtnReponder_Click);
            // 
            // RdbResp4
            // 
            this.RdbResp4.AutoSize = true;
            this.RdbResp4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp4.Location = new System.Drawing.Point(7, 119);
            this.RdbResp4.Name = "RdbResp4";
            this.RdbResp4.Size = new System.Drawing.Size(50, 17);
            this.RdbResp4.TabIndex = 12;
            this.RdbResp4.TabStop = true;
            this.RdbResp4.Text = "Rosa";
            this.RdbResp4.UseVisualStyleBackColor = true;
            // 
            // RdbResp3
            // 
            this.RdbResp3.AutoSize = true;
            this.RdbResp3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp3.Location = new System.Drawing.Point(7, 96);
            this.RdbResp3.Name = "RdbResp3";
            this.RdbResp3.Size = new System.Drawing.Size(59, 17);
            this.RdbResp3.TabIndex = 11;
            this.RdbResp3.TabStop = true;
            this.RdbResp3.Text = "Branco";
            this.RdbResp3.UseVisualStyleBackColor = true;
            // 
            // RdbResp2
            // 
            this.RdbResp2.AutoSize = true;
            this.RdbResp2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp2.Location = new System.Drawing.Point(7, 73);
            this.RdbResp2.Name = "RdbResp2";
            this.RdbResp2.Size = new System.Drawing.Size(50, 17);
            this.RdbResp2.TabIndex = 10;
            this.RdbResp2.TabStop = true;
            this.RdbResp2.Text = "Preto";
            this.RdbResp2.UseVisualStyleBackColor = true;
            // 
            // Tempo
            // 
            this.Tempo.Interval = 1000;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // RdbResp1
            // 
            this.RdbResp1.AutoSize = true;
            this.RdbResp1.Checked = true;
            this.RdbResp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp1.Location = new System.Drawing.Point(7, 50);
            this.RdbResp1.Name = "RdbResp1";
            this.RdbResp1.Size = new System.Drawing.Size(88, 17);
            this.RdbResp1.TabIndex = 9;
            this.RdbResp1.TabStop = true;
            this.RdbResp1.Text = "Transparente";
            this.RdbResp1.UseVisualStyleBackColor = true;
            // 
            // LblPergunta
            // 
            this.LblPergunta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPergunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPergunta.Location = new System.Drawing.Point(4, 11);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(221, 32);
            this.LblPergunta.TabIndex = 8;
            this.LblPergunta.Text = "Qual a cor do cavalo branco de Napoleão?";
            // 
            // FrmPergunta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(229, 146);
            this.Controls.Add(this.LblContagem);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnReponder);
            this.Controls.Add(this.RdbResp4);
            this.Controls.Add(this.RdbResp3);
            this.Controls.Add(this.RdbResp2);
            this.Controls.Add(this.RdbResp1);
            this.Controls.Add(this.LblPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPergunta3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPergunta3_FormClosed);
            this.Load += new System.EventHandler(this.FrmPergunta3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblContagem;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnReponder;
        private System.Windows.Forms.RadioButton RdbResp4;
        private System.Windows.Forms.RadioButton RdbResp3;
        private System.Windows.Forms.RadioButton RdbResp2;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.RadioButton RdbResp1;
        private System.Windows.Forms.Label LblPergunta;
    }
}
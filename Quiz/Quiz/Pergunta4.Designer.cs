namespace Quiz
{
    partial class FrmPergunta4
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
            this.RdbResp4 = new System.Windows.Forms.RadioButton();
            this.BtnReponder = new System.Windows.Forms.Button();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.RdbResp3 = new System.Windows.Forms.RadioButton();
            this.RdbResp2 = new System.Windows.Forms.RadioButton();
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
            this.LblContagem.TabIndex = 23;
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
            this.LblTempo.TabIndex = 22;
            this.LblTempo.Text = "Tempo";
            // 
            // RdbResp4
            // 
            this.RdbResp4.AutoSize = true;
            this.RdbResp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbResp4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp4.Location = new System.Drawing.Point(7, 120);
            this.RdbResp4.Name = "RdbResp4";
            this.RdbResp4.Size = new System.Drawing.Size(77, 16);
            this.RdbResp4.TabIndex = 20;
            this.RdbResp4.TabStop = true;
            this.RdbResp4.Text = "Sr. Hernadez";
            this.RdbResp4.UseVisualStyleBackColor = true;
            // 
            // BtnReponder
            // 
            this.BtnReponder.Location = new System.Drawing.Point(138, 113);
            this.BtnReponder.Name = "BtnReponder";
            this.BtnReponder.Size = new System.Drawing.Size(75, 23);
            this.BtnReponder.TabIndex = 21;
            this.BtnReponder.Text = "&Responder";
            this.BtnReponder.UseVisualStyleBackColor = true;
            this.BtnReponder.Click += new System.EventHandler(this.BtnReponder_Click);
            // 
            // Tempo
            // 
            this.Tempo.Interval = 1000;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // RdbResp3
            // 
            this.RdbResp3.AutoSize = true;
            this.RdbResp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbResp3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp3.Location = new System.Drawing.Point(7, 97);
            this.RdbResp3.Name = "RdbResp3";
            this.RdbResp3.Size = new System.Drawing.Size(141, 16);
            this.RdbResp3.TabIndex = 19;
            this.RdbResp3.TabStop = true;
            this.RdbResp3.Text = "Dr. Hernandez Emílio Aguilar";
            this.RdbResp3.UseVisualStyleBackColor = true;
            // 
            // RdbResp2
            // 
            this.RdbResp2.AutoSize = true;
            this.RdbResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbResp2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp2.Location = new System.Drawing.Point(7, 74);
            this.RdbResp2.Name = "RdbResp2";
            this.RdbResp2.Size = new System.Drawing.Size(140, 16);
            this.RdbResp2.TabIndex = 18;
            this.RdbResp2.TabStop = true;
            this.RdbResp2.Text = "Sr. Emílio Hernandez Aguilar";
            this.RdbResp2.UseVisualStyleBackColor = true;
            // 
            // RdbResp1
            // 
            this.RdbResp1.AutoSize = true;
            this.RdbResp1.Checked = true;
            this.RdbResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbResp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdbResp1.Location = new System.Drawing.Point(7, 51);
            this.RdbResp1.Name = "RdbResp1";
            this.RdbResp1.Size = new System.Drawing.Size(141, 16);
            this.RdbResp1.TabIndex = 17;
            this.RdbResp1.TabStop = true;
            this.RdbResp1.Text = "Dr. Emílio Hernandez Aguilar";
            this.RdbResp1.UseVisualStyleBackColor = true;
            // 
            // LblPergunta
            // 
            this.LblPergunta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPergunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPergunta.Location = new System.Drawing.Point(4, 11);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(221, 32);
            this.LblPergunta.TabIndex = 16;
            this.LblPergunta.Text = "Qual o nome da ETEC de Franco da Rocha?";
            // 
            // FrmPergunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(229, 146);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.LblContagem);
            this.Controls.Add(this.RdbResp4);
            this.Controls.Add(this.BtnReponder);
            this.Controls.Add(this.RdbResp3);
            this.Controls.Add(this.RdbResp2);
            this.Controls.Add(this.RdbResp1);
            this.Controls.Add(this.LblPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPergunta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPergunta4_FormClosed);
            this.Load += new System.EventHandler(this.FrmPergunta4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblContagem;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.RadioButton RdbResp4;
        private System.Windows.Forms.Button BtnReponder;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.RadioButton RdbResp3;
        private System.Windows.Forms.RadioButton RdbResp2;
        private System.Windows.Forms.RadioButton RdbResp1;
        private System.Windows.Forms.Label LblPergunta;
    }
}
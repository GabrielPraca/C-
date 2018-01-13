namespace Menu
{
    partial class FrmCFC
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
            this.LblPergunta = new System.Windows.Forms.Label();
            this.Rdb1 = new System.Windows.Forms.RadioButton();
            this.Rdb3 = new System.Windows.Forms.RadioButton();
            this.Rdb2 = new System.Windows.Forms.RadioButton();
            this.Rdb5 = new System.Windows.Forms.RadioButton();
            this.Rdb4 = new System.Windows.Forms.RadioButton();
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnProx = new System.Windows.Forms.Button();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.LblFaltaPerguntas = new System.Windows.Forms.Label();
            this.ImgPlaca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPlaca)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPergunta
            // 
            this.LblPergunta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPergunta.AutoSize = true;
            this.LblPergunta.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPergunta.ForeColor = System.Drawing.Color.White;
            this.LblPergunta.Location = new System.Drawing.Point(12, 75);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(121, 19);
            this.LblPergunta.TabIndex = 0;
            this.LblPergunta.Text = "Nº. *(Pergunta)";
            // 
            // Rdb1
            // 
            this.Rdb1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Rdb1.AutoSize = true;
            this.Rdb1.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb1.ForeColor = System.Drawing.Color.White;
            this.Rdb1.Location = new System.Drawing.Point(15, 113);
            this.Rdb1.Name = "Rdb1";
            this.Rdb1.Size = new System.Drawing.Size(131, 23);
            this.Rdb1.TabIndex = 1;
            this.Rdb1.TabStop = true;
            this.Rdb1.Text = "(Alternativa 1)";
            this.Rdb1.UseVisualStyleBackColor = true;
            // 
            // Rdb3
            // 
            this.Rdb3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Rdb3.AutoSize = true;
            this.Rdb3.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb3.ForeColor = System.Drawing.Color.White;
            this.Rdb3.Location = new System.Drawing.Point(15, 159);
            this.Rdb3.Name = "Rdb3";
            this.Rdb3.Size = new System.Drawing.Size(131, 23);
            this.Rdb3.TabIndex = 2;
            this.Rdb3.TabStop = true;
            this.Rdb3.Text = "(Alternativa 3)";
            this.Rdb3.UseVisualStyleBackColor = true;
            // 
            // Rdb2
            // 
            this.Rdb2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Rdb2.AutoSize = true;
            this.Rdb2.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb2.ForeColor = System.Drawing.Color.White;
            this.Rdb2.Location = new System.Drawing.Point(15, 136);
            this.Rdb2.Name = "Rdb2";
            this.Rdb2.Size = new System.Drawing.Size(131, 23);
            this.Rdb2.TabIndex = 3;
            this.Rdb2.TabStop = true;
            this.Rdb2.Text = "(Alternativa 2)";
            this.Rdb2.UseVisualStyleBackColor = true;
            // 
            // Rdb5
            // 
            this.Rdb5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Rdb5.AutoSize = true;
            this.Rdb5.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb5.ForeColor = System.Drawing.Color.White;
            this.Rdb5.Location = new System.Drawing.Point(15, 205);
            this.Rdb5.Name = "Rdb5";
            this.Rdb5.Size = new System.Drawing.Size(131, 23);
            this.Rdb5.TabIndex = 4;
            this.Rdb5.TabStop = true;
            this.Rdb5.Text = "(Alternativa 5)";
            this.Rdb5.UseVisualStyleBackColor = true;
            // 
            // Rdb4
            // 
            this.Rdb4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Rdb4.AutoSize = true;
            this.Rdb4.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb4.ForeColor = System.Drawing.Color.White;
            this.Rdb4.Location = new System.Drawing.Point(15, 182);
            this.Rdb4.Name = "Rdb4";
            this.Rdb4.Size = new System.Drawing.Size(131, 23);
            this.Rdb4.TabIndex = 5;
            this.Rdb4.TabStop = true;
            this.Rdb4.Text = "(Alternativa 4)";
            this.Rdb4.UseVisualStyleBackColor = true;
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.White;
            this.LblTempo.Location = new System.Drawing.Point(121, 15);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 13;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(12, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 12;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(40, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 11;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // LblFaltaPerguntas
            // 
            this.LblFaltaPerguntas.AutoSize = true;
            this.LblFaltaPerguntas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFaltaPerguntas.ForeColor = System.Drawing.Color.White;
            this.LblFaltaPerguntas.Location = new System.Drawing.Point(137, 40);
            this.LblFaltaPerguntas.Name = "LblFaltaPerguntas";
            this.LblFaltaPerguntas.Size = new System.Drawing.Size(102, 16);
            this.LblFaltaPerguntas.TabIndex = 14;
            this.LblFaltaPerguntas.Text = "Pergunta 01/15";
            // 
            // ImgPlaca
            // 
            this.ImgPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgPlaca.Location = new System.Drawing.Point(213, 113);
            this.ImgPlaca.Name = "ImgPlaca";
            this.ImgPlaca.Size = new System.Drawing.Size(67, 72);
            this.ImgPlaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgPlaca.TabIndex = 15;
            this.ImgPlaca.TabStop = false;
            // 
            // FrmCFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.ImgPlaca);
            this.Controls.Add(this.LblFaltaPerguntas);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.Rdb4);
            this.Controls.Add(this.Rdb5);
            this.Controls.Add(this.Rdb2);
            this.Controls.Add(this.Rdb3);
            this.Controls.Add(this.Rdb1);
            this.Controls.Add(this.LblPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCFC";
            this.Text = "Teste Teórico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCFC_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCFC_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCFC_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPlaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPergunta;
        private System.Windows.Forms.RadioButton Rdb1;
        private System.Windows.Forms.RadioButton Rdb3;
        private System.Windows.Forms.RadioButton Rdb2;
        private System.Windows.Forms.RadioButton Rdb5;
        private System.Windows.Forms.RadioButton Rdb4;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.Label LblFaltaPerguntas;
        private System.Windows.Forms.PictureBox ImgPlaca;
    }
}
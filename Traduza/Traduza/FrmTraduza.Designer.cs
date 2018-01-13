namespace Traduza
{
    partial class FrmTraduza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraduza));
            this.TimAnim = new System.Windows.Forms.Timer(this.components);
            this.LblJogador1 = new System.Windows.Forms.Label();
            this.LblJogador2 = new System.Windows.Forms.Label();
            this.LblPontos1 = new System.Windows.Forms.Label();
            this.LblPontos2 = new System.Windows.Forms.Label();
            this.LblSig = new System.Windows.Forms.Label();
            this.LblEmFrase = new System.Windows.Forms.Label();
            this.LblPalavraIng = new System.Windows.Forms.Label();
            this.TxtTryPTBR = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimAnim
            // 
            this.TimAnim.Enabled = true;
            this.TimAnim.Interval = 10;
            this.TimAnim.Tick += new System.EventHandler(this.TimAnim_Tick);
            // 
            // LblJogador1
            // 
            this.LblJogador1.AutoSize = true;
            this.LblJogador1.BackColor = System.Drawing.Color.Transparent;
            this.LblJogador1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJogador1.ForeColor = System.Drawing.Color.White;
            this.LblJogador1.Location = new System.Drawing.Point(107, 3);
            this.LblJogador1.Name = "LblJogador1";
            this.LblJogador1.Size = new System.Drawing.Size(168, 23);
            this.LblJogador1.TabIndex = 0;
            this.LblJogador1.Text = "NOME_JOGADOR1";
            // 
            // LblJogador2
            // 
            this.LblJogador2.AutoSize = true;
            this.LblJogador2.BackColor = System.Drawing.Color.Transparent;
            this.LblJogador2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJogador2.ForeColor = System.Drawing.Color.White;
            this.LblJogador2.Location = new System.Drawing.Point(387, 3);
            this.LblJogador2.Name = "LblJogador2";
            this.LblJogador2.Size = new System.Drawing.Size(168, 23);
            this.LblJogador2.TabIndex = 1;
            this.LblJogador2.Text = "NOME_JOGADOR2";
            // 
            // LblPontos1
            // 
            this.LblPontos1.AutoSize = true;
            this.LblPontos1.BackColor = System.Drawing.Color.Transparent;
            this.LblPontos1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPontos1.ForeColor = System.Drawing.Color.White;
            this.LblPontos1.Location = new System.Drawing.Point(180, 26);
            this.LblPontos1.Name = "LblPontos1";
            this.LblPontos1.Size = new System.Drawing.Size(21, 23);
            this.LblPontos1.TabIndex = 2;
            this.LblPontos1.Text = "0";
            // 
            // LblPontos2
            // 
            this.LblPontos2.AutoSize = true;
            this.LblPontos2.BackColor = System.Drawing.Color.Transparent;
            this.LblPontos2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPontos2.ForeColor = System.Drawing.Color.White;
            this.LblPontos2.Location = new System.Drawing.Point(461, 26);
            this.LblPontos2.Name = "LblPontos2";
            this.LblPontos2.Size = new System.Drawing.Size(21, 23);
            this.LblPontos2.TabIndex = 3;
            this.LblPontos2.Text = "0";
            // 
            // LblSig
            // 
            this.LblSig.BackColor = System.Drawing.Color.Transparent;
            this.LblSig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSig.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSig.ForeColor = System.Drawing.Color.Black;
            this.LblSig.Location = new System.Drawing.Point(12, 293);
            this.LblSig.Name = "LblSig";
            this.LblSig.Size = new System.Drawing.Size(80, 19);
            this.LblSig.TabIndex = 4;
            this.LblSig.Text = "Significado:";
            this.LblSig.MouseLeave += new System.EventHandler(this.LblSig_MouseLeave);
            this.LblSig.Click += new System.EventHandler(this.LblSig_Click);
            this.LblSig.MouseEnter += new System.EventHandler(this.LblSig_MouseEnter);
            // 
            // LblEmFrase
            // 
            this.LblEmFrase.BackColor = System.Drawing.Color.Transparent;
            this.LblEmFrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEmFrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblEmFrase.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmFrase.ForeColor = System.Drawing.Color.Black;
            this.LblEmFrase.Location = new System.Drawing.Point(12, 316);
            this.LblEmFrase.Name = "LblEmFrase";
            this.LblEmFrase.Size = new System.Drawing.Size(155, 19);
            this.LblEmFrase.TabIndex = 5;
            this.LblEmFrase.Text = "Aplicação em uma frase:";
            this.LblEmFrase.MouseLeave += new System.EventHandler(this.LblEmFrase_MouseLeave);
            this.LblEmFrase.Click += new System.EventHandler(this.LblEmFrase_Click);
            this.LblEmFrase.MouseEnter += new System.EventHandler(this.LblEmFrase_MouseEnter);
            // 
            // LblPalavraIng
            // 
            this.LblPalavraIng.AutoSize = true;
            this.LblPalavraIng.BackColor = System.Drawing.Color.Transparent;
            this.LblPalavraIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LblPalavraIng.Location = new System.Drawing.Point(153, 132);
            this.LblPalavraIng.Name = "LblPalavraIng";
            this.LblPalavraIng.Size = new System.Drawing.Size(357, 55);
            this.LblPalavraIng.TabIndex = 6;
            this.LblPalavraIng.Text = "PALAVRA_ING";
            // 
            // TxtTryPTBR
            // 
            this.TxtTryPTBR.Location = new System.Drawing.Point(186, 193);
            this.TxtTryPTBR.MaxLength = 256;
            this.TxtTryPTBR.Name = "TxtTryPTBR";
            this.TxtTryPTBR.Size = new System.Drawing.Size(295, 20);
            this.TxtTryPTBR.TabIndex = 7;
            this.TxtTryPTBR.TextChanged += new System.EventHandler(this.TxtTryPTBR_TextChanged);
            this.TxtTryPTBR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTryPTBR_KeyUp);
            this.TxtTryPTBR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTryPTBR_KeyPress);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(263, 67);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(137, 38);
            this.LblTitulo.TabIndex = 8;
            this.LblTitulo.Text = "Traduza";
            // 
            // FrmTraduza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Traduza.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 345);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtTryPTBR);
            this.Controls.Add(this.LblPalavraIng);
            this.Controls.Add(this.LblEmFrase);
            this.Controls.Add(this.LblSig);
            this.Controls.Add(this.LblPontos2);
            this.Controls.Add(this.LblPontos1);
            this.Controls.Add(this.LblJogador2);
            this.Controls.Add(this.LblJogador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTraduza";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traduza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTraduza_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimAnim;
        private System.Windows.Forms.Label LblJogador1;
        private System.Windows.Forms.Label LblJogador2;
        private System.Windows.Forms.Label LblPontos1;
        private System.Windows.Forms.Label LblPontos2;
        private System.Windows.Forms.Label LblSig;
        private System.Windows.Forms.Label LblEmFrase;
        private System.Windows.Forms.Label LblPalavraIng;
        private System.Windows.Forms.TextBox TxtTryPTBR;
        private System.Windows.Forms.Label LblTitulo;
    }
}
namespace Captura_Tela
{
    partial class FrmGravador
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
            this.ImgSaida = new System.Windows.Forms.PictureBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.BtnReproduzir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgSaida
            // 
            this.ImgSaida.BackColor = System.Drawing.Color.Black;
            this.ImgSaida.ErrorImage = null;
            this.ImgSaida.InitialImage = null;
            this.ImgSaida.Location = new System.Drawing.Point(0, 0);
            this.ImgSaida.Name = "ImgSaida";
            this.ImgSaida.Size = new System.Drawing.Size(640, 480);
            this.ImgSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgSaida.TabIndex = 0;
            this.ImgSaida.TabStop = false;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(0, 480);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(213, 51);
            this.BtnGravar.TabIndex = 1;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.Enabled = false;
            this.BtnParar.Location = new System.Drawing.Point(427, 480);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(213, 51);
            this.BtnParar.TabIndex = 2;
            this.BtnParar.Text = "&Parar";
            this.BtnParar.UseVisualStyleBackColor = true;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // BtnReproduzir
            // 
            this.BtnReproduzir.Location = new System.Drawing.Point(212, 480);
            this.BtnReproduzir.Name = "BtnReproduzir";
            this.BtnReproduzir.Size = new System.Drawing.Size(216, 51);
            this.BtnReproduzir.TabIndex = 3;
            this.BtnReproduzir.Text = "&Reproduzir último";
            this.BtnReproduzir.UseVisualStyleBackColor = true;
            this.BtnReproduzir.Click += new System.EventHandler(this.BtnReproduzir_Click);
            // 
            // FrmGravador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 530);
            this.Controls.Add(this.BtnReproduzir);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.ImgSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGravador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGravador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ImgSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgSaida;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Button BtnReproduzir;
    }
}


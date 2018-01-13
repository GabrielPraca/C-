namespace Quiz
{
    partial class FrmFim
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
            this.LblInfFim = new System.Windows.Forms.Label();
            this.LblInfResult = new System.Windows.Forms.Label();
            this.LblAcertos = new System.Windows.Forms.Label();
            this.LblErros = new System.Windows.Forms.Label();
            this.LblTxtAcertos = new System.Windows.Forms.Label();
            this.LblTxtErros = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblInfFim
            // 
            this.LblInfFim.AutoSize = true;
            this.LblInfFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfFim.ForeColor = System.Drawing.Color.White;
            this.LblInfFim.Location = new System.Drawing.Point(90, 9);
            this.LblInfFim.Name = "LblInfFim";
            this.LblInfFim.Size = new System.Drawing.Size(113, 25);
            this.LblInfFim.TabIndex = 0;
            this.LblInfFim.Text = "Fim de jogo";
            // 
            // LblInfResult
            // 
            this.LblInfResult.AutoSize = true;
            this.LblInfResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfResult.ForeColor = System.Drawing.Color.White;
            this.LblInfResult.Location = new System.Drawing.Point(94, 34);
            this.LblInfResult.Name = "LblInfResult";
            this.LblInfResult.Size = new System.Drawing.Size(105, 25);
            this.LblInfResult.TabIndex = 1;
            this.LblInfResult.Text = "Resultado:";
            // 
            // LblAcertos
            // 
            this.LblAcertos.BackColor = System.Drawing.Color.Transparent;
            this.LblAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcertos.ForeColor = System.Drawing.Color.White;
            this.LblAcertos.Image = global::Quiz.Properties.Resources.Certo;
            this.LblAcertos.Location = new System.Drawing.Point(12, 65);
            this.LblAcertos.Name = "LblAcertos";
            this.LblAcertos.Size = new System.Drawing.Size(64, 67);
            this.LblAcertos.TabIndex = 4;
            this.LblAcertos.Text = "0";
            this.LblAcertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblErros
            // 
            this.LblErros.BackColor = System.Drawing.Color.Transparent;
            this.LblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErros.ForeColor = System.Drawing.Color.White;
            this.LblErros.Image = global::Quiz.Properties.Resources.Errado;
            this.LblErros.Location = new System.Drawing.Point(12, 135);
            this.LblErros.Name = "LblErros";
            this.LblErros.Size = new System.Drawing.Size(64, 67);
            this.LblErros.TabIndex = 5;
            this.LblErros.Text = "0";
            this.LblErros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTxtAcertos
            // 
            this.LblTxtAcertos.AutoSize = true;
            this.LblTxtAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtAcertos.ForeColor = System.Drawing.Color.White;
            this.LblTxtAcertos.Location = new System.Drawing.Point(82, 71);
            this.LblTxtAcertos.Name = "LblTxtAcertos";
            this.LblTxtAcertos.Size = new System.Drawing.Size(187, 55);
            this.LblTxtAcertos.TabIndex = 6;
            this.LblTxtAcertos.Text = "Acertos";
            // 
            // LblTxtErros
            // 
            this.LblTxtErros.AutoSize = true;
            this.LblTxtErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtErros.ForeColor = System.Drawing.Color.White;
            this.LblTxtErros.Location = new System.Drawing.Point(82, 141);
            this.LblTxtErros.Name = "LblTxtErros";
            this.LblTxtErros.Size = new System.Drawing.Size(139, 55);
            this.LblTxtErros.TabIndex = 7;
            this.LblTxtErros.Text = "Erros";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(-1, -1);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(34, 21);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(292, 211);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblTxtErros);
            this.Controls.Add(this.LblTxtAcertos);
            this.Controls.Add(this.LblErros);
            this.Controls.Add(this.LblAcertos);
            this.Controls.Add(this.LblInfResult);
            this.Controls.Add(this.LblInfFim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfFim;
        private System.Windows.Forms.Label LblInfResult;
        private System.Windows.Forms.Label LblAcertos;
        private System.Windows.Forms.Label LblErros;
        private System.Windows.Forms.Label LblTxtAcertos;
        private System.Windows.Forms.Label LblTxtErros;
        private System.Windows.Forms.Button BtnSair;
    }
}
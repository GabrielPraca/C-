namespace P_Exemplo
{
    partial class FrmCadFilm
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
            this.BtnCad = new System.Windows.Forms.Button();
            this.TxtDuracao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodDist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxTFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCad
            // 
            this.BtnCad.Location = new System.Drawing.Point(99, 136);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(75, 23);
            this.BtnCad.TabIndex = 28;
            this.BtnCad.Text = "&Cadastrar";
            this.BtnCad.UseVisualStyleBackColor = true;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // TxtDuracao
            // 
            this.TxtDuracao.Location = new System.Drawing.Point(116, 110);
            this.TxtDuracao.Name = "TxtDuracao";
            this.TxtDuracao.Size = new System.Drawing.Size(146, 20);
            this.TxtDuracao.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Duração";
            // 
            // TxtCodDist
            // 
            this.TxtCodDist.Location = new System.Drawing.Point(116, 84);
            this.TxtCodDist.Name = "TxtCodDist";
            this.TxtCodDist.Size = new System.Drawing.Size(59, 20);
            this.TxtCodDist.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Código Distribuidora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Gênero";
            // 
            // TxTFilme
            // 
            this.TxTFilme.Location = new System.Drawing.Point(116, 32);
            this.TxTFilme.Name = "TxTFilme";
            this.TxTFilme.Size = new System.Drawing.Size(146, 20);
            this.TxTFilme.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filme";
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(116, 6);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(59, 20);
            this.TxtCod.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Location = new System.Drawing.Point(116, 58);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(121, 21);
            this.CmbGenero.TabIndex = 29;
            // 
            // FrmCadFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 167);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.BtnCad);
            this.Controls.Add(this.TxtDuracao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodDist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxTFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCod);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filme";
            this.Load += new System.EventHandler(this.FrmCadFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.TextBox TxtDuracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodDist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxTFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbGenero;
    }
}
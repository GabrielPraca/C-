namespace ProjetoLogin
{
    partial class FrmLogin
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
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxdUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(12, 9);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(65, 26);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(12, 46);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(75, 26);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha";
            // 
            // TxdUsuario
            // 
            this.TxdUsuario.Location = new System.Drawing.Point(95, 12);
            this.TxdUsuario.Name = "TxdUsuario";
            this.TxdUsuario.Size = new System.Drawing.Size(125, 20);
            this.TxdUsuario.TabIndex = 0;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(95, 49);
            this.TxtSenha.MaxLength = 20;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(125, 20);
            this.TxtSenha.TabIndex = 1;
            // 
            // BtnLogar
            // 
            this.BtnLogar.Location = new System.Drawing.Point(63, 116);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(112, 29);
            this.BtnLogar.TabIndex = 2;
            this.BtnLogar.Text = "&Ok";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 157);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxdUsuario);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblLogin);
            this.Name = "FrmLogin";
            this.Text = "Projeto Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxdUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnLogar;
    }
}


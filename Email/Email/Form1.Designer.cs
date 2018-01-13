namespace Email
{
    partial class FrmEnvioDeEmail
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
            this.LblDe = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblPara = new System.Windows.Forms.Label();
            this.LblAssunto = new System.Windows.Forms.Label();
            this.LblMensagem = new System.Windows.Forms.Label();
            this.LkAnexo = new System.Windows.Forms.LinkLabel();
            this.TxtDe = new System.Windows.Forms.TextBox();
            this.TxtAssunto = new System.Windows.Forms.TextBox();
            this.TxtPara = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDe
            // 
            this.LblDe.AutoSize = true;
            this.LblDe.Location = new System.Drawing.Point(12, 19);
            this.LblDe.Name = "LblDe";
            this.LblDe.Size = new System.Drawing.Size(24, 13);
            this.LblDe.TabIndex = 0;
            this.LblDe.Text = "De:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(12, 45);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(41, 13);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha:";
            // 
            // LblPara
            // 
            this.LblPara.AutoSize = true;
            this.LblPara.Location = new System.Drawing.Point(12, 72);
            this.LblPara.Name = "LblPara";
            this.LblPara.Size = new System.Drawing.Size(32, 13);
            this.LblPara.TabIndex = 2;
            this.LblPara.Text = "Para:";
            // 
            // LblAssunto
            // 
            this.LblAssunto.AutoSize = true;
            this.LblAssunto.Location = new System.Drawing.Point(12, 102);
            this.LblAssunto.Name = "LblAssunto";
            this.LblAssunto.Size = new System.Drawing.Size(48, 13);
            this.LblAssunto.TabIndex = 3;
            this.LblAssunto.Text = "Assunto:";
            // 
            // LblMensagem
            // 
            this.LblMensagem.AutoSize = true;
            this.LblMensagem.Location = new System.Drawing.Point(12, 152);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(59, 13);
            this.LblMensagem.TabIndex = 4;
            this.LblMensagem.Text = "Mensagem";
            // 
            // LkAnexo
            // 
            this.LkAnexo.AutoSize = true;
            this.LkAnexo.Location = new System.Drawing.Point(96, 237);
            this.LkAnexo.Name = "LkAnexo";
            this.LkAnexo.Size = new System.Drawing.Size(37, 13);
            this.LkAnexo.TabIndex = 5;
            this.LkAnexo.TabStop = true;
            this.LkAnexo.Text = "Anexo";
            this.LkAnexo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkAnexo_LinkClicked);
            // 
            // TxtDe
            // 
            this.TxtDe.Location = new System.Drawing.Point(90, 16);
            this.TxtDe.Name = "TxtDe";
            this.TxtDe.Size = new System.Drawing.Size(179, 20);
            this.TxtDe.TabIndex = 6;
            // 
            // TxtAssunto
            // 
            this.TxtAssunto.Location = new System.Drawing.Point(90, 98);
            this.TxtAssunto.Name = "TxtAssunto";
            this.TxtAssunto.Size = new System.Drawing.Size(179, 20);
            this.TxtAssunto.TabIndex = 8;
            // 
            // TxtPara
            // 
            this.TxtPara.Location = new System.Drawing.Point(90, 72);
            this.TxtPara.Name = "TxtPara";
            this.TxtPara.Size = new System.Drawing.Size(179, 20);
            this.TxtPara.TabIndex = 9;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(90, 45);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(179, 20);
            this.TxtSenha.TabIndex = 10;
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Location = new System.Drawing.Point(90, 149);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMensagem.Size = new System.Drawing.Size(203, 85);
            this.TxtMensagem.TabIndex = 11;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(90, 263);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(75, 23);
            this.BtnRemover.TabIndex = 12;
            this.BtnRemover.Text = "&Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(175, 263);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(118, 23);
            this.BtnEnviar.TabIndex = 13;
            this.BtnEnviar.Text = "&Enviar E-mail";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // FrmEnvioDeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 298);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.TxtMensagem);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtPara);
            this.Controls.Add(this.TxtAssunto);
            this.Controls.Add(this.TxtDe);
            this.Controls.Add(this.LkAnexo);
            this.Controls.Add(this.LblMensagem);
            this.Controls.Add(this.LblAssunto);
            this.Controls.Add(this.LblPara);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblDe);
            this.Name = "FrmEnvioDeEmail";
            this.Text = "e-mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDe;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.Label LblAssunto;
        private System.Windows.Forms.Label LblMensagem;
        private System.Windows.Forms.LinkLabel LkAnexo;
        private System.Windows.Forms.TextBox TxtDe;
        private System.Windows.Forms.TextBox TxtAssunto;
        private System.Windows.Forms.TextBox TxtPara;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnEnviar;
    }
}


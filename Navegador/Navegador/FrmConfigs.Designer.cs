namespace Navegador
{
    partial class FrmConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigs));
            this.LblCorInfo = new System.Windows.Forms.Label();
            this.LblCor = new System.Windows.Forms.Label();
            this.DigCor = new System.Windows.Forms.ColorDialog();
            this.LblHP = new System.Windows.Forms.Label();
            this.TxtHP = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnPadrao = new System.Windows.Forms.Button();
            this.BtnUrlAtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCorInfo
            // 
            this.LblCorInfo.AutoSize = true;
            this.LblCorInfo.Location = new System.Drawing.Point(12, 9);
            this.LblCorInfo.Name = "LblCorInfo";
            this.LblCorInfo.Size = new System.Drawing.Size(141, 13);
            this.LblCorInfo.TabIndex = 0;
            this.LblCorInfo.Text = "Cor da barra de ferramentas:";
            // 
            // LblCor
            // 
            this.LblCor.BackColor = System.Drawing.Color.Magenta;
            this.LblCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCor.Location = new System.Drawing.Point(159, 9);
            this.LblCor.Name = "LblCor";
            this.LblCor.Size = new System.Drawing.Size(56, 13);
            this.LblCor.TabIndex = 1;
            this.LblCor.Click += new System.EventHandler(this.LblCor_Click);
            // 
            // LblHP
            // 
            this.LblHP.AutoSize = true;
            this.LblHP.Location = new System.Drawing.Point(12, 31);
            this.LblHP.Name = "LblHP";
            this.LblHP.Size = new System.Drawing.Size(72, 13);
            this.LblHP.TabIndex = 2;
            this.LblHP.Text = "Página inicial:";
            // 
            // TxtHP
            // 
            this.TxtHP.Location = new System.Drawing.Point(90, 28);
            this.TxtHP.Name = "TxtHP";
            this.TxtHP.Size = new System.Drawing.Size(125, 20);
            this.TxtHP.TabIndex = 3;
            this.TxtHP.Text = "http://*.com";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(164, 60);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnPadrao
            // 
            this.BtnPadrao.Location = new System.Drawing.Point(58, 60);
            this.BtnPadrao.Name = "BtnPadrao";
            this.BtnPadrao.Size = new System.Drawing.Size(75, 23);
            this.BtnPadrao.TabIndex = 5;
            this.BtnPadrao.Text = "&Padrão";
            this.BtnPadrao.UseVisualStyleBackColor = true;
            this.BtnPadrao.Click += new System.EventHandler(this.BtnPadrao_Click);
            // 
            // BtnUrlAtual
            // 
            this.BtnUrlAtual.Location = new System.Drawing.Point(221, 28);
            this.BtnUrlAtual.Name = "BtnUrlAtual";
            this.BtnUrlAtual.Size = new System.Drawing.Size(64, 20);
            this.BtnUrlAtual.TabIndex = 6;
            this.BtnUrlAtual.Text = "Usar atual";
            this.BtnUrlAtual.UseVisualStyleBackColor = true;
            this.BtnUrlAtual.Click += new System.EventHandler(this.BtnUrlAtual_Click);
            // 
            // FrmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 95);
            this.Controls.Add(this.BtnUrlAtual);
            this.Controls.Add(this.BtnPadrao);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtHP);
            this.Controls.Add(this.LblHP);
            this.Controls.Add(this.LblCor);
            this.Controls.Add(this.LblCorInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConfigs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfigs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCorInfo;
        private System.Windows.Forms.Label LblCor;
        private System.Windows.Forms.ColorDialog DigCor;
        private System.Windows.Forms.Label LblHP;
        private System.Windows.Forms.TextBox TxtHP;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnPadrao;
        private System.Windows.Forms.Button BtnUrlAtual;
    }
}
namespace Joquempo_Multiplayer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnHost = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(54, 36);
            this.TxtNome.MaxLength = 30;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(89, 20);
            this.TxtNome.TabIndex = 13;
            this.TxtNome.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ou";
            // 
            // BtnHost
            // 
            this.BtnHost.Enabled = false;
            this.BtnHost.Location = new System.Drawing.Point(10, 116);
            this.BtnHost.Name = "BtnHost";
            this.BtnHost.Size = new System.Drawing.Size(133, 30);
            this.BtnHost.TabIndex = 10;
            this.BtnHost.Text = "Ser o servidor";
            this.BtnHost.UseVisualStyleBackColor = true;
            this.BtnHost.Click += new System.EventHandler(this.BtnHost_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Enabled = false;
            this.BtnConectar.Location = new System.Drawing.Point(10, 67);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(133, 30);
            this.BtnConectar.TabIndex = 9;
            this.BtnConectar.Text = "Conectar-se";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TxtIp
            // 
            this.TxtIp.Location = new System.Drawing.Point(54, 10);
            this.TxtIp.MaxLength = 15;
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(89, 20);
            this.TxtIp.TabIndex = 8;
            this.TxtIp.Text = "127.0.0.1";
            this.TxtIp.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 156);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnHost);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.TxtIp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joquempô";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnHost;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.Label label1;
    }
}
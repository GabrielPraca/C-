namespace Imagens
{
    partial class FrmImagem
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ImgPortao = new System.Windows.Forms.PictureBox();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnTrancar = new System.Windows.Forms.Button();
            this.BtnDestrancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPortao)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgPortao
            // 
            this.ImgPortao.Image = global::Imagens.Properties.Resources.opened;
            this.ImgPortao.Location = new System.Drawing.Point(115, 12);
            this.ImgPortao.Name = "ImgPortao";
            this.ImgPortao.Size = new System.Drawing.Size(120, 120);
            this.ImgPortao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPortao.TabIndex = 0;
            this.ImgPortao.TabStop = false;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(16, 143);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrir.TabIndex = 1;
            this.BtnAbrir.Text = "&Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(97, 143);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnTrancar
            // 
            this.BtnTrancar.Location = new System.Drawing.Point(178, 143);
            this.BtnTrancar.Name = "BtnTrancar";
            this.BtnTrancar.Size = new System.Drawing.Size(75, 23);
            this.BtnTrancar.TabIndex = 3;
            this.BtnTrancar.Text = "&Trancar";
            this.BtnTrancar.UseVisualStyleBackColor = true;
            this.BtnTrancar.Click += new System.EventHandler(this.BtnTrancar_Click);
            // 
            // BtnDestrancar
            // 
            this.BtnDestrancar.Location = new System.Drawing.Point(259, 143);
            this.BtnDestrancar.Name = "BtnDestrancar";
            this.BtnDestrancar.Size = new System.Drawing.Size(75, 23);
            this.BtnDestrancar.TabIndex = 4;
            this.BtnDestrancar.Text = "&Destrancar";
            this.BtnDestrancar.UseVisualStyleBackColor = true;
            this.BtnDestrancar.Click += new System.EventHandler(this.BtnDestrancar_Click);
            // 
            // FrmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 178);
            this.Controls.Add(this.BtnDestrancar);
            this.Controls.Add(this.BtnTrancar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.ImgPortao);
            this.Name = "FrmImagem";
            this.Text = "Portão";
            ((System.ComponentModel.ISupportInitialize)(this.ImgPortao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgPortao;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnTrancar;
        private System.Windows.Forms.Button BtnDestrancar;

    }
}


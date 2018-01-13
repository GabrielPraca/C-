namespace Menu
{
    partial class FrmPsicT1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPsicT1));
            this.LblInformacao = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnProx = new System.Windows.Forms.Button();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.Rdb1 = new System.Windows.Forms.RadioButton();
            this.Rdb2 = new System.Windows.Forms.RadioButton();
            this.Rdb3 = new System.Windows.Forms.RadioButton();
            this.Rdb4 = new System.Windows.Forms.RadioButton();
            this.Rdb5 = new System.Windows.Forms.RadioButton();
            this.Img11 = new System.Windows.Forms.PictureBox();
            this.ImgDomino = new System.Windows.Forms.PictureBox();
            this.Img12 = new System.Windows.Forms.PictureBox();
            this.Img22 = new System.Windows.Forms.PictureBox();
            this.Img21 = new System.Windows.Forms.PictureBox();
            this.Img32 = new System.Windows.Forms.PictureBox();
            this.Img31 = new System.Windows.Forms.PictureBox();
            this.Img42 = new System.Windows.Forms.PictureBox();
            this.Img41 = new System.Windows.Forms.PictureBox();
            this.Img52 = new System.Windows.Forms.PictureBox();
            this.Img51 = new System.Windows.Forms.PictureBox();
            this.LblFundoCor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDomino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img51)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInformacao
            // 
            this.LblInformacao.AutoSize = true;
            this.LblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacao.ForeColor = System.Drawing.Color.Black;
            this.LblInformacao.Location = new System.Drawing.Point(137, 41);
            this.LblInformacao.Name = "LblInformacao";
            this.LblInformacao.Size = new System.Drawing.Size(289, 25);
            this.LblInformacao.TabIndex = 14;
            this.LblInformacao.Text = "Descubra a peça que falta";
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.Black;
            this.LblTempo.Location = new System.Drawing.Point(210, 25);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 17;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(15, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(43, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 15;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Enabled = true;
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // Rdb1
            // 
            this.Rdb1.AutoSize = true;
            this.Rdb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rdb1.Location = new System.Drawing.Point(479, 69);
            this.Rdb1.Name = "Rdb1";
            this.Rdb1.Size = new System.Drawing.Size(35, 17);
            this.Rdb1.TabIndex = 18;
            this.Rdb1.TabStop = true;
            this.Rdb1.Text = "*|*";
            this.Rdb1.UseVisualStyleBackColor = false;
            // 
            // Rdb2
            // 
            this.Rdb2.AutoSize = true;
            this.Rdb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rdb2.Location = new System.Drawing.Point(479, 92);
            this.Rdb2.Name = "Rdb2";
            this.Rdb2.Size = new System.Drawing.Size(35, 17);
            this.Rdb2.TabIndex = 19;
            this.Rdb2.TabStop = true;
            this.Rdb2.Text = "*|*";
            this.Rdb2.UseVisualStyleBackColor = false;
            // 
            // Rdb3
            // 
            this.Rdb3.AutoSize = true;
            this.Rdb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rdb3.Location = new System.Drawing.Point(479, 115);
            this.Rdb3.Name = "Rdb3";
            this.Rdb3.Size = new System.Drawing.Size(35, 17);
            this.Rdb3.TabIndex = 20;
            this.Rdb3.TabStop = true;
            this.Rdb3.Text = "*|*";
            this.Rdb3.UseVisualStyleBackColor = false;
            // 
            // Rdb4
            // 
            this.Rdb4.AutoSize = true;
            this.Rdb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rdb4.Location = new System.Drawing.Point(479, 138);
            this.Rdb4.Name = "Rdb4";
            this.Rdb4.Size = new System.Drawing.Size(35, 17);
            this.Rdb4.TabIndex = 21;
            this.Rdb4.TabStop = true;
            this.Rdb4.Text = "*|*";
            this.Rdb4.UseVisualStyleBackColor = false;
            // 
            // Rdb5
            // 
            this.Rdb5.AutoSize = true;
            this.Rdb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rdb5.Location = new System.Drawing.Point(479, 161);
            this.Rdb5.Name = "Rdb5";
            this.Rdb5.Size = new System.Drawing.Size(35, 17);
            this.Rdb5.TabIndex = 22;
            this.Rdb5.TabStop = true;
            this.Rdb5.Text = "*|*";
            this.Rdb5.UseVisualStyleBackColor = false;
            // 
            // Img11
            // 
            this.Img11.ErrorImage = null;
            this.Img11.Image = ((System.Drawing.Image)(resources.GetObject("Img11.Image")));
            this.Img11.InitialImage = null;
            this.Img11.Location = new System.Drawing.Point(479, 184);
            this.Img11.Name = "Img11";
            this.Img11.Size = new System.Drawing.Size(64, 64);
            this.Img11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img11.TabIndex = 23;
            this.Img11.TabStop = false;
            // 
            // ImgDomino
            // 
            this.ImgDomino.ErrorImage = null;
            this.ImgDomino.Image = global::Menu.Properties.Resources.Dominó1;
            this.ImgDomino.InitialImage = null;
            this.ImgDomino.Location = new System.Drawing.Point(43, 69);
            this.ImgDomino.Name = "ImgDomino";
            this.ImgDomino.Size = new System.Drawing.Size(430, 385);
            this.ImgDomino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgDomino.TabIndex = 2;
            this.ImgDomino.TabStop = false;
            // 
            // Img12
            // 
            this.Img12.ErrorImage = null;
            this.Img12.Image = ((System.Drawing.Image)(resources.GetObject("Img12.Image")));
            this.Img12.InitialImage = null;
            this.Img12.Location = new System.Drawing.Point(479, 246);
            this.Img12.Name = "Img12";
            this.Img12.Size = new System.Drawing.Size(64, 64);
            this.Img12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img12.TabIndex = 24;
            this.Img12.TabStop = false;
            // 
            // Img22
            // 
            this.Img22.ErrorImage = null;
            this.Img22.Image = ((System.Drawing.Image)(resources.GetObject("Img22.Image")));
            this.Img22.InitialImage = null;
            this.Img22.Location = new System.Drawing.Point(488, 254);
            this.Img22.Name = "Img22";
            this.Img22.Size = new System.Drawing.Size(64, 64);
            this.Img22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img22.TabIndex = 26;
            this.Img22.TabStop = false;
            // 
            // Img21
            // 
            this.Img21.ErrorImage = null;
            this.Img21.Image = ((System.Drawing.Image)(resources.GetObject("Img21.Image")));
            this.Img21.InitialImage = null;
            this.Img21.Location = new System.Drawing.Point(488, 192);
            this.Img21.Name = "Img21";
            this.Img21.Size = new System.Drawing.Size(64, 64);
            this.Img21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img21.TabIndex = 25;
            this.Img21.TabStop = false;
            // 
            // Img32
            // 
            this.Img32.ErrorImage = null;
            this.Img32.Image = ((System.Drawing.Image)(resources.GetObject("Img32.Image")));
            this.Img32.InitialImage = null;
            this.Img32.Location = new System.Drawing.Point(497, 262);
            this.Img32.Name = "Img32";
            this.Img32.Size = new System.Drawing.Size(64, 64);
            this.Img32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img32.TabIndex = 28;
            this.Img32.TabStop = false;
            // 
            // Img31
            // 
            this.Img31.ErrorImage = null;
            this.Img31.Image = ((System.Drawing.Image)(resources.GetObject("Img31.Image")));
            this.Img31.InitialImage = null;
            this.Img31.Location = new System.Drawing.Point(497, 200);
            this.Img31.Name = "Img31";
            this.Img31.Size = new System.Drawing.Size(64, 64);
            this.Img31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img31.TabIndex = 27;
            this.Img31.TabStop = false;
            // 
            // Img42
            // 
            this.Img42.ErrorImage = null;
            this.Img42.Image = ((System.Drawing.Image)(resources.GetObject("Img42.Image")));
            this.Img42.InitialImage = null;
            this.Img42.Location = new System.Drawing.Point(506, 270);
            this.Img42.Name = "Img42";
            this.Img42.Size = new System.Drawing.Size(64, 64);
            this.Img42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img42.TabIndex = 30;
            this.Img42.TabStop = false;
            // 
            // Img41
            // 
            this.Img41.ErrorImage = null;
            this.Img41.Image = ((System.Drawing.Image)(resources.GetObject("Img41.Image")));
            this.Img41.InitialImage = null;
            this.Img41.Location = new System.Drawing.Point(506, 209);
            this.Img41.Name = "Img41";
            this.Img41.Size = new System.Drawing.Size(64, 64);
            this.Img41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img41.TabIndex = 29;
            this.Img41.TabStop = false;
            // 
            // Img52
            // 
            this.Img52.ErrorImage = null;
            this.Img52.Image = ((System.Drawing.Image)(resources.GetObject("Img52.Image")));
            this.Img52.InitialImage = null;
            this.Img52.Location = new System.Drawing.Point(515, 281);
            this.Img52.Name = "Img52";
            this.Img52.Size = new System.Drawing.Size(64, 64);
            this.Img52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img52.TabIndex = 32;
            this.Img52.TabStop = false;
            // 
            // Img51
            // 
            this.Img51.ErrorImage = null;
            this.Img51.Image = ((System.Drawing.Image)(resources.GetObject("Img51.Image")));
            this.Img51.InitialImage = null;
            this.Img51.Location = new System.Drawing.Point(515, 219);
            this.Img51.Name = "Img51";
            this.Img51.Size = new System.Drawing.Size(64, 64);
            this.Img51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img51.TabIndex = 31;
            this.Img51.TabStop = false;
            // 
            // LblFundoCor
            // 
            this.LblFundoCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblFundoCor.Location = new System.Drawing.Point(432, 27);
            this.LblFundoCor.Name = "LblFundoCor";
            this.LblFundoCor.Size = new System.Drawing.Size(82, 39);
            this.LblFundoCor.TabIndex = 33;
            // 
            // FrmPsicT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 456);
            this.Controls.Add(this.LblFundoCor);
            this.Controls.Add(this.Img52);
            this.Controls.Add(this.Img51);
            this.Controls.Add(this.Img42);
            this.Controls.Add(this.Img41);
            this.Controls.Add(this.Img32);
            this.Controls.Add(this.Img31);
            this.Controls.Add(this.Img22);
            this.Controls.Add(this.Img21);
            this.Controls.Add(this.Img12);
            this.Controls.Add(this.Img11);
            this.Controls.Add(this.Rdb5);
            this.Controls.Add(this.Rdb4);
            this.Controls.Add(this.Rdb3);
            this.Controls.Add(this.Rdb2);
            this.Controls.Add(this.Rdb1);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.LblInformacao);
            this.Controls.Add(this.ImgDomino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPsicT1";
            this.Text = "FrmPsicT1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPsicT1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FrmPsicT1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Img11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDomino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img51)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgDomino;
        private System.Windows.Forms.Label LblInformacao;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.RadioButton Rdb1;
        private System.Windows.Forms.RadioButton Rdb2;
        private System.Windows.Forms.RadioButton Rdb3;
        private System.Windows.Forms.RadioButton Rdb4;
        private System.Windows.Forms.RadioButton Rdb5;
        private System.Windows.Forms.PictureBox Img11;
        private System.Windows.Forms.PictureBox Img12;
        private System.Windows.Forms.PictureBox Img22;
        private System.Windows.Forms.PictureBox Img21;
        private System.Windows.Forms.PictureBox Img32;
        private System.Windows.Forms.PictureBox Img31;
        private System.Windows.Forms.PictureBox Img42;
        private System.Windows.Forms.PictureBox Img41;
        private System.Windows.Forms.PictureBox Img52;
        private System.Windows.Forms.PictureBox Img51;
        private System.Windows.Forms.Label LblFundoCor;
    }
}
namespace Menu
{
    partial class FrmVistaT5
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
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.BtnProx = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblTempo = new System.Windows.Forms.Label();
            this.LblInformacao = new System.Windows.Forms.Label();
            this.Txt29 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt5 = new System.Windows.Forms.TextBox();
            this.Img29 = new System.Windows.Forms.PictureBox();
            this.Img2 = new System.Windows.Forms.PictureBox();
            this.Img5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Img29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img5)).BeginInit();
            this.SuspendLayout();
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(43, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 3;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(12, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.Black;
            this.LblTempo.Location = new System.Drawing.Point(135, 15);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 24;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // LblInformacao
            // 
            this.LblInformacao.AutoSize = true;
            this.LblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacao.ForeColor = System.Drawing.Color.Black;
            this.LblInformacao.Location = new System.Drawing.Point(98, 58);
            this.LblInformacao.Name = "LblInformacao";
            this.LblInformacao.Size = new System.Drawing.Size(381, 25);
            this.LblInformacao.TabIndex = 25;
            this.LblInformacao.Text = "Digite o número que você enxergar";
            // 
            // Txt29
            // 
            this.Txt29.Location = new System.Drawing.Point(485, 355);
            this.Txt29.Name = "Txt29";
            this.Txt29.Size = new System.Drawing.Size(38, 20);
            this.Txt29.TabIndex = 2;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(287, 355);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(38, 20);
            this.Txt2.TabIndex = 1;
            // 
            // Txt5
            // 
            this.Txt5.Location = new System.Drawing.Point(68, 355);
            this.Txt5.Name = "Txt5";
            this.Txt5.Size = new System.Drawing.Size(38, 20);
            this.Txt5.TabIndex = 0;
            // 
            // Img29
            // 
            this.Img29.Image = global::Menu.Properties.Resources.DaltonN29;
            this.Img29.Location = new System.Drawing.Point(381, 86);
            this.Img29.Name = "Img29";
            this.Img29.Size = new System.Drawing.Size(262, 262);
            this.Img29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img29.TabIndex = 28;
            this.Img29.TabStop = false;
            // 
            // Img2
            // 
            this.Img2.Image = global::Menu.Properties.Resources.DaltonN2;
            this.Img2.Location = new System.Drawing.Point(173, 86);
            this.Img2.Name = "Img2";
            this.Img2.Size = new System.Drawing.Size(262, 262);
            this.Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img2.TabIndex = 27;
            this.Img2.TabStop = false;
            // 
            // Img5
            // 
            this.Img5.Image = global::Menu.Properties.Resources.DaltonN5;
            this.Img5.Location = new System.Drawing.Point(-34, 86);
            this.Img5.Name = "Img5";
            this.Img5.Size = new System.Drawing.Size(262, 262);
            this.Img5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img5.TabIndex = 26;
            this.Img5.TabStop = false;
            // 
            // FrmVistaT5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 387);
            this.Controls.Add(this.Txt29);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt5);
            this.Controls.Add(this.Img29);
            this.Controls.Add(this.Img2);
            this.Controls.Add(this.Img5);
            this.Controls.Add(this.LblInformacao);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.BtnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaT5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVistaT5_FormClosing);
            this.Load += new System.EventHandler(this.FrmVistaT5_Load);
            this.SizeChanged += new System.EventHandler(this.FrmVistaT5_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Img29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label LblInformacao;
        private System.Windows.Forms.TextBox Txt29;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt5;
        private System.Windows.Forms.PictureBox Img29;
        private System.Windows.Forms.PictureBox Img2;
        private System.Windows.Forms.PictureBox Img5;
    }
}
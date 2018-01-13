namespace Menu
{
    partial class FrmVistaT4
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
            this.LblInformacao = new System.Windows.Forms.Label();
            this.ImgE = new System.Windows.Forms.PictureBox();
            this.ImgH = new System.Windows.Forms.PictureBox();
            this.ImgZ = new System.Windows.Forms.PictureBox();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.TxtH = new System.Windows.Forms.TextBox();
            this.TxtZ = new System.Windows.Forms.TextBox();
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnProx = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImgE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgZ)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInformacao
            // 
            this.LblInformacao.AutoSize = true;
            this.LblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacao.ForeColor = System.Drawing.Color.Black;
            this.LblInformacao.Location = new System.Drawing.Point(178, 26);
            this.LblInformacao.Name = "LblInformacao";
            this.LblInformacao.Size = new System.Drawing.Size(350, 25);
            this.LblInformacao.TabIndex = 13;
            this.LblInformacao.Text = "Digite a letra que você enxergar";
            // 
            // ImgE
            // 
            this.ImgE.Image = global::Menu.Properties.Resources.grade_e;
            this.ImgE.Location = new System.Drawing.Point(12, 54);
            this.ImgE.Name = "ImgE";
            this.ImgE.Size = new System.Drawing.Size(202, 198);
            this.ImgE.TabIndex = 14;
            this.ImgE.TabStop = false;
            // 
            // ImgH
            // 
            this.ImgH.Image = global::Menu.Properties.Resources.grade_h;
            this.ImgH.Location = new System.Drawing.Point(219, 54);
            this.ImgH.Name = "ImgH";
            this.ImgH.Size = new System.Drawing.Size(202, 198);
            this.ImgH.TabIndex = 15;
            this.ImgH.TabStop = false;
            // 
            // ImgZ
            // 
            this.ImgZ.Image = global::Menu.Properties.Resources.grade_z;
            this.ImgZ.Location = new System.Drawing.Point(426, 54);
            this.ImgZ.Name = "ImgZ";
            this.ImgZ.Size = new System.Drawing.Size(202, 198);
            this.ImgZ.TabIndex = 16;
            this.ImgZ.TabStop = false;
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(93, 258);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(38, 20);
            this.TxtE.TabIndex = 0;
            this.TxtE.TextChanged += new System.EventHandler(this.TxtE_TextChanged);
            // 
            // TxtH
            // 
            this.TxtH.Location = new System.Drawing.Point(302, 258);
            this.TxtH.Name = "TxtH";
            this.TxtH.Size = new System.Drawing.Size(38, 20);
            this.TxtH.TabIndex = 1;
            this.TxtH.TextChanged += new System.EventHandler(this.TxtH_TextChanged);
            // 
            // TxtZ
            // 
            this.TxtZ.Location = new System.Drawing.Point(510, 258);
            this.TxtZ.Name = "TxtZ";
            this.TxtZ.Size = new System.Drawing.Size(38, 20);
            this.TxtZ.TabIndex = 2;
            this.TxtZ.TextChanged += new System.EventHandler(this.TxtZ_TextChanged);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.Black;
            this.LblTempo.Location = new System.Drawing.Point(142, 15);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 22;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(44, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 3;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(13, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // FrmVistaT4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 285);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtZ);
            this.Controls.Add(this.TxtH);
            this.Controls.Add(this.TxtE);
            this.Controls.Add(this.ImgZ);
            this.Controls.Add(this.ImgH);
            this.Controls.Add(this.ImgE);
            this.Controls.Add(this.LblInformacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaT4";
            this.Text = "FrmVista4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVistaT4_FormClosing);
            this.Load += new System.EventHandler(this.FrmVistaT4_Load);
            this.SizeChanged += new System.EventHandler(this.FrmVistaT4_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ImgE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInformacao;
        private System.Windows.Forms.PictureBox ImgE;
        private System.Windows.Forms.PictureBox ImgH;
        private System.Windows.Forms.PictureBox ImgZ;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.TextBox TxtH;
        private System.Windows.Forms.TextBox TxtZ;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Timer TimAtualizarTempo;
    }
}
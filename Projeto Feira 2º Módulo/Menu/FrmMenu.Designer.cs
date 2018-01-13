namespace Menu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnParar = new System.Windows.Forms.Button();
            this.TimTempoCount = new System.Windows.Forms.Timer(this.components);
            this.LblTempo = new System.Windows.Forms.Label();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.ImgCadeado = new System.Windows.Forms.PictureBox();
            this.Img4 = new System.Windows.Forms.PictureBox();
            this.Img3 = new System.Windows.Forms.PictureBox();
            this.Img2 = new System.Windows.Forms.PictureBox();
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.TimPosVolante = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCadeado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblInfo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(474, 383);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(256, 256);
            this.LblInfo.TabIndex = 5;
            this.LblInfo.Text = "Descrição";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnParar
            // 
            this.BtnParar.Location = new System.Drawing.Point(597, 0);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(75, 23);
            this.BtnParar.TabIndex = 6;
            this.BtnParar.Text = "&Parar";
            this.BtnParar.UseVisualStyleBackColor = true;
            this.BtnParar.Visible = false;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // TimTempoCount
            // 
            this.TimTempoCount.Interval = 1000;
            this.TimTempoCount.Tick += new System.EventHandler(this.TimTempoCount_Tick);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.White;
            this.LblTempo.Location = new System.Drawing.Point(12, 9);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 25;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Enabled = true;
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // ImgCadeado
            // 
            this.ImgCadeado.BackColor = System.Drawing.Color.Transparent;
            this.ImgCadeado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgCadeado.ErrorImage = null;
            this.ImgCadeado.Image = global::Menu.Properties.Resources.Cadeado;
            this.ImgCadeado.InitialImage = null;
            this.ImgCadeado.Location = new System.Drawing.Point(78, 380);
            this.ImgCadeado.Name = "ImgCadeado";
            this.ImgCadeado.Size = new System.Drawing.Size(128, 128);
            this.ImgCadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgCadeado.TabIndex = 26;
            this.ImgCadeado.TabStop = false;
            this.ImgCadeado.MouseEnter += new System.EventHandler(this.ImgCadeado_MouseEnter);
            // 
            // Img4
            // 
            this.Img4.BackColor = System.Drawing.Color.Transparent;
            this.Img4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img4.ErrorImage = null;
            this.Img4.Image = global::Menu.Properties.Resources.ImgVista0;
            this.Img4.InitialImage = null;
            this.Img4.Location = new System.Drawing.Point(-50, 124);
            this.Img4.Name = "Img4";
            this.Img4.Size = new System.Drawing.Size(256, 256);
            this.Img4.TabIndex = 4;
            this.Img4.TabStop = false;
            this.Img4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img4_MouseDown);
            this.Img4.MouseEnter += new System.EventHandler(this.Img4_MouseEnter);
            this.Img4.MouseLeave += new System.EventHandler(this.Img4_MouseLeave);
            this.Img4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Img4_MouseUp);
            // 
            // Img3
            // 
            this.Img3.BackColor = System.Drawing.Color.Transparent;
            this.Img3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img3.ErrorImage = null;
            this.Img3.Image = global::Menu.Properties.Resources.ImgVolante0;
            this.Img3.InitialImage = null;
            this.Img3.Location = new System.Drawing.Point(212, 252);
            this.Img3.Name = "Img3";
            this.Img3.Size = new System.Drawing.Size(256, 256);
            this.Img3.TabIndex = 3;
            this.Img3.TabStop = false;
            this.Img3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img3_MouseDown);
            this.Img3.MouseEnter += new System.EventHandler(this.Img3_MouseEnter);
            this.Img3.MouseLeave += new System.EventHandler(this.Img3_MouseLeave);
            this.Img3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Img3_MouseUp);
            // 
            // Img2
            // 
            this.Img2.BackColor = System.Drawing.Color.Transparent;
            this.Img2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img2.ErrorImage = null;
            this.Img2.Image = global::Menu.Properties.Resources.ImgPisic0;
            this.Img2.InitialImage = null;
            this.Img2.Location = new System.Drawing.Point(474, 124);
            this.Img2.Name = "Img2";
            this.Img2.Size = new System.Drawing.Size(256, 256);
            this.Img2.TabIndex = 2;
            this.Img2.TabStop = false;
            this.Img2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img2_MouseDown);
            this.Img2.MouseEnter += new System.EventHandler(this.Img2_MouseEnter);
            this.Img2.MouseLeave += new System.EventHandler(this.Img2_MouseLeave);
            this.Img2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Img2_MouseUp);
            // 
            // Img1
            // 
            this.Img1.BackColor = System.Drawing.Color.Transparent;
            this.Img1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img1.ErrorImage = null;
            this.Img1.Image = global::Menu.Properties.Resources.ImgCFC0;
            this.Img1.InitialImage = null;
            this.Img1.Location = new System.Drawing.Point(212, -10);
            this.Img1.Name = "Img1";
            this.Img1.Size = new System.Drawing.Size(256, 256);
            this.Img1.TabIndex = 1;
            this.Img1.TabStop = false;
            this.Img1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img1_MouseDown);
            this.Img1.MouseEnter += new System.EventHandler(this.Img1_MouseEnter);
            this.Img1.MouseLeave += new System.EventHandler(this.Img1_MouseLeave);
            this.Img1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Img1_MouseUp);
            // 
            // TimPosVolante
            // 
            this.TimPosVolante.Interval = 10000;
            this.TimPosVolante.Tick += new System.EventHandler(this.TimPosVolante_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 530);
            this.Controls.Add(this.ImgCadeado);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.Img4);
            this.Controls.Add(this.Img3);
            this.Controls.Add(this.Img2);
            this.Controls.Add(this.Img1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMenu_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.FrmMenu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCadeado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img1;
        private System.Windows.Forms.PictureBox Img2;
        private System.Windows.Forms.PictureBox Img3;
        private System.Windows.Forms.PictureBox Img4;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Timer TimTempoCount;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.PictureBox ImgCadeado;
        private System.Windows.Forms.Timer TimPosVolante;


    }
}


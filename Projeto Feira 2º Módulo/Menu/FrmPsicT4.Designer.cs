namespace Menu
{
    partial class FrmPsicT4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPsicT4));
            this.LblTempo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnProx = new System.Windows.Forms.Button();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.TimMouseArrasto = new System.Windows.Forms.Timer(this.components);
            this.ImgHexagono = new System.Windows.Forms.PictureBox();
            this.ImgTriangulo = new System.Windows.Forms.PictureBox();
            this.ImgQuadrado = new System.Windows.Forms.PictureBox();
            this.ImgEncaixes = new System.Windows.Forms.PictureBox();
            this.ImgCirculo = new System.Windows.Forms.PictureBox();
            this.TimFim = new System.Windows.Forms.Timer(this.components);
            this.LblInformacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHexagono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgQuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEncaixes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCirculo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.Black;
            this.LblTempo.Location = new System.Drawing.Point(117, 9);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 26;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(8, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 25;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(36, 6);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 24;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Enabled = true;
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // TimMouseArrasto
            // 
            this.TimMouseArrasto.Enabled = true;
            this.TimMouseArrasto.Interval = 10;
            this.TimMouseArrasto.Tick += new System.EventHandler(this.TimMouseArrasto_Tick);
            // 
            // ImgHexagono
            // 
            this.ImgHexagono.BackColor = System.Drawing.Color.Transparent;
            this.ImgHexagono.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ImgHexagono.ErrorImage = null;
            this.ImgHexagono.Image = global::Menu.Properties.Resources.Hexágono;
            this.ImgHexagono.InitialImage = null;
            this.ImgHexagono.Location = new System.Drawing.Point(269, 28);
            this.ImgHexagono.Name = "ImgHexagono";
            this.ImgHexagono.Size = new System.Drawing.Size(128, 111);
            this.ImgHexagono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgHexagono.TabIndex = 32;
            this.ImgHexagono.TabStop = false;
            this.ImgHexagono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgHexagono_MouseDown);
            this.ImgHexagono.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgHexagono_MouseUp);
            // 
            // ImgTriangulo
            // 
            this.ImgTriangulo.BackColor = System.Drawing.Color.Transparent;
            this.ImgTriangulo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ImgTriangulo.ErrorImage = null;
            this.ImgTriangulo.Image = global::Menu.Properties.Resources.Triângulo;
            this.ImgTriangulo.InitialImage = null;
            this.ImgTriangulo.Location = new System.Drawing.Point(403, 28);
            this.ImgTriangulo.Name = "ImgTriangulo";
            this.ImgTriangulo.Size = new System.Drawing.Size(128, 128);
            this.ImgTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgTriangulo.TabIndex = 31;
            this.ImgTriangulo.TabStop = false;
            this.ImgTriangulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgTriangulo_MouseDown);
            this.ImgTriangulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgTriangulo_MouseUp);
            // 
            // ImgQuadrado
            // 
            this.ImgQuadrado.BackColor = System.Drawing.Color.Transparent;
            this.ImgQuadrado.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ImgQuadrado.ErrorImage = null;
            this.ImgQuadrado.Image = global::Menu.Properties.Resources.Quadrado;
            this.ImgQuadrado.InitialImage = null;
            this.ImgQuadrado.Location = new System.Drawing.Point(537, 28);
            this.ImgQuadrado.Name = "ImgQuadrado";
            this.ImgQuadrado.Size = new System.Drawing.Size(128, 128);
            this.ImgQuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgQuadrado.TabIndex = 30;
            this.ImgQuadrado.TabStop = false;
            this.ImgQuadrado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgQuadrado_MouseDown);
            this.ImgQuadrado.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgQuadrado_MouseUp);
            // 
            // ImgEncaixes
            // 
            this.ImgEncaixes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgEncaixes.ErrorImage = null;
            this.ImgEncaixes.Image = global::Menu.Properties.Resources.Encaixes;
            this.ImgEncaixes.InitialImage = null;
            this.ImgEncaixes.Location = new System.Drawing.Point(8, 169);
            this.ImgEncaixes.Name = "ImgEncaixes";
            this.ImgEncaixes.Size = new System.Drawing.Size(157, 128);
            this.ImgEncaixes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgEncaixes.TabIndex = 28;
            this.ImgEncaixes.TabStop = false;
            // 
            // ImgCirculo
            // 
            this.ImgCirculo.BackColor = System.Drawing.Color.Transparent;
            this.ImgCirculo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ImgCirculo.ErrorImage = null;
            this.ImgCirculo.Image = global::Menu.Properties.Resources.Circulo;
            this.ImgCirculo.InitialImage = null;
            this.ImgCirculo.Location = new System.Drawing.Point(135, 28);
            this.ImgCirculo.Name = "ImgCirculo";
            this.ImgCirculo.Size = new System.Drawing.Size(128, 128);
            this.ImgCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgCirculo.TabIndex = 27;
            this.ImgCirculo.TabStop = false;
            this.ImgCirculo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgCirculo_MouseDown);
            this.ImgCirculo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgCirculo_MouseUp);
            // 
            // TimFim
            // 
            this.TimFim.Interval = 500;
            this.TimFim.Tick += new System.EventHandler(this.TimFim_Tick);
            // 
            // LblInformacao
            // 
            this.LblInformacao.AutoSize = true;
            this.LblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacao.ForeColor = System.Drawing.Color.Black;
            this.LblInformacao.Location = new System.Drawing.Point(171, 169);
            this.LblInformacao.Name = "LblInformacao";
            this.LblInformacao.Size = new System.Drawing.Size(467, 25);
            this.LblInformacao.TabIndex = 33;
            this.LblInformacao.Text = "Encaixe as peças em seus devidos lugares";
            // 
            // FrmPsicT4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(677, 306);
            this.Controls.Add(this.LblInformacao);
            this.Controls.Add(this.ImgHexagono);
            this.Controls.Add(this.ImgTriangulo);
            this.Controls.Add(this.ImgQuadrado);
            this.Controls.Add(this.ImgEncaixes);
            this.Controls.Add(this.ImgCirculo);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnProx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPsicT4";
            this.Text = "FrmPsicT4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPsicT4_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FrmPsicT4_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHexagono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgQuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEncaixes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCirculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.PictureBox ImgCirculo;
        private System.Windows.Forms.Timer TimMouseArrasto;
        private System.Windows.Forms.PictureBox ImgEncaixes;
        private System.Windows.Forms.PictureBox ImgQuadrado;
        private System.Windows.Forms.PictureBox ImgTriangulo;
        private System.Windows.Forms.PictureBox ImgHexagono;
        private System.Windows.Forms.Timer TimFim;
        private System.Windows.Forms.Label LblInformacao;
    }
}
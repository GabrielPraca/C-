namespace Joquempo_Multiplayer
{
    partial class FrmJP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJP));
            this.LblNome2 = new System.Windows.Forms.Label();
            this.LblNome1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVitorias2 = new System.Windows.Forms.Label();
            this.LblVitorias1 = new System.Windows.Forms.Label();
            this.BtnPedra = new System.Windows.Forms.Button();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.BtnPapel = new System.Windows.Forms.Button();
            this.BtnTesoura = new System.Windows.Forms.Button();
            this.TimTrocaImg = new System.Windows.Forms.Timer(this.components);
            this.LblEspera2 = new System.Windows.Forms.Label();
            this.LblEspera1 = new System.Windows.Forms.Label();
            this.TimResetaJogada = new System.Windows.Forms.Timer(this.components);
            this.LblGanhador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome2
            // 
            this.LblNome2.AutoSize = true;
            this.LblNome2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome2.ForeColor = System.Drawing.Color.White;
            this.LblNome2.Location = new System.Drawing.Point(12, 9);
            this.LblNome2.Name = "LblNome2";
            this.LblNome2.Size = new System.Drawing.Size(174, 19);
            this.LblNome2.TabIndex = 0;
            this.LblNome2.Text = "Aguardando jogador...";
            // 
            // LblNome1
            // 
            this.LblNome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNome1.AutoSize = true;
            this.LblNome1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome1.ForeColor = System.Drawing.Color.White;
            this.LblNome1.Location = new System.Drawing.Point(351, 9);
            this.LblNome1.Name = "LblNome1";
            this.LblNome1.Size = new System.Drawing.Size(174, 19);
            this.LblNome1.TabIndex = 1;
            this.LblNome1.Text = "Aguardando jogador...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "VS";
            // 
            // LblVitorias2
            // 
            this.LblVitorias2.AutoSize = true;
            this.LblVitorias2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVitorias2.ForeColor = System.Drawing.Color.White;
            this.LblVitorias2.Location = new System.Drawing.Point(13, 28);
            this.LblVitorias2.Name = "LblVitorias2";
            this.LblVitorias2.Size = new System.Drawing.Size(77, 16);
            this.LblVitorias2.TabIndex = 3;
            this.LblVitorias2.Text = "Vitórias: 0";
            // 
            // LblVitorias1
            // 
            this.LblVitorias1.AutoSize = true;
            this.LblVitorias1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVitorias1.ForeColor = System.Drawing.Color.White;
            this.LblVitorias1.Location = new System.Drawing.Point(448, 28);
            this.LblVitorias1.Name = "LblVitorias1";
            this.LblVitorias1.Size = new System.Drawing.Size(77, 16);
            this.LblVitorias1.TabIndex = 4;
            this.LblVitorias1.Text = "Vitórias: 0";
            // 
            // BtnPedra
            // 
            this.BtnPedra.BackColor = System.Drawing.Color.Transparent;
            this.BtnPedra.BackgroundImage = global::Joquempo_Multiplayer.Properties.Resources.BtnFundo;
            this.BtnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPedra.FlatAppearance.BorderSize = 0;
            this.BtnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedra.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedra.ForeColor = System.Drawing.Color.White;
            this.BtnPedra.Location = new System.Drawing.Point(166, 236);
            this.BtnPedra.Name = "BtnPedra";
            this.BtnPedra.Size = new System.Drawing.Size(64, 64);
            this.BtnPedra.TabIndex = 7;
            this.BtnPedra.Text = "Pedra";
            this.BtnPedra.UseVisualStyleBackColor = false;
            this.BtnPedra.Click += new System.EventHandler(this.BtnPedra_Click);
            this.BtnPedra.MouseEnter += new System.EventHandler(this.Botao_MouseEnter);
            this.BtnPedra.MouseLeave += new System.EventHandler(this.Botao_MouseLeave);
            // 
            // Pic1
            // 
            this.Pic1.Image = global::Joquempo_Multiplayer.Properties.Resources.Papel;
            this.Pic1.Location = new System.Drawing.Point(337, 74);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(128, 128);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 6;
            this.Pic1.TabStop = false;
            this.Pic1.Visible = false;
            // 
            // Pic2
            // 
            this.Pic2.Image = global::Joquempo_Multiplayer.Properties.Resources.Pedra;
            this.Pic2.Location = new System.Drawing.Point(71, 74);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(128, 128);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 5;
            this.Pic2.TabStop = false;
            this.Pic2.Visible = false;
            // 
            // BtnPapel
            // 
            this.BtnPapel.BackColor = System.Drawing.Color.Transparent;
            this.BtnPapel.BackgroundImage = global::Joquempo_Multiplayer.Properties.Resources.BtnFundo;
            this.BtnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPapel.FlatAppearance.BorderSize = 0;
            this.BtnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPapel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPapel.ForeColor = System.Drawing.Color.White;
            this.BtnPapel.Location = new System.Drawing.Point(236, 236);
            this.BtnPapel.Name = "BtnPapel";
            this.BtnPapel.Size = new System.Drawing.Size(64, 64);
            this.BtnPapel.TabIndex = 8;
            this.BtnPapel.Text = "Papel";
            this.BtnPapel.UseVisualStyleBackColor = false;
            this.BtnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            this.BtnPapel.MouseEnter += new System.EventHandler(this.Botao_MouseEnter);
            this.BtnPapel.MouseLeave += new System.EventHandler(this.Botao_MouseLeave);
            // 
            // BtnTesoura
            // 
            this.BtnTesoura.BackColor = System.Drawing.Color.Transparent;
            this.BtnTesoura.BackgroundImage = global::Joquempo_Multiplayer.Properties.Resources.BtnFundo;
            this.BtnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTesoura.FlatAppearance.BorderSize = 0;
            this.BtnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTesoura.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTesoura.ForeColor = System.Drawing.Color.White;
            this.BtnTesoura.Location = new System.Drawing.Point(306, 236);
            this.BtnTesoura.Name = "BtnTesoura";
            this.BtnTesoura.Size = new System.Drawing.Size(64, 64);
            this.BtnTesoura.TabIndex = 9;
            this.BtnTesoura.Text = "Tesoura";
            this.BtnTesoura.UseVisualStyleBackColor = false;
            this.BtnTesoura.Click += new System.EventHandler(this.BtnTesoura_Click);
            this.BtnTesoura.MouseEnter += new System.EventHandler(this.Botao_MouseEnter);
            this.BtnTesoura.MouseLeave += new System.EventHandler(this.Botao_MouseLeave);
            // 
            // TimTrocaImg
            // 
            this.TimTrocaImg.Enabled = true;
            this.TimTrocaImg.Tick += new System.EventHandler(this.TimTrocaImg_Tick);
            // 
            // LblEspera2
            // 
            this.LblEspera2.AutoSize = true;
            this.LblEspera2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspera2.ForeColor = System.Drawing.Color.White;
            this.LblEspera2.Location = new System.Drawing.Point(83, 205);
            this.LblEspera2.Name = "LblEspera2";
            this.LblEspera2.Size = new System.Drawing.Size(105, 16);
            this.LblEspera2.TabIndex = 10;
            this.LblEspera2.Text = "Aguardando...";
            this.LblEspera2.Visible = false;
            // 
            // LblEspera1
            // 
            this.LblEspera1.AutoSize = true;
            this.LblEspera1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspera1.ForeColor = System.Drawing.Color.White;
            this.LblEspera1.Location = new System.Drawing.Point(349, 205);
            this.LblEspera1.Name = "LblEspera1";
            this.LblEspera1.Size = new System.Drawing.Size(105, 16);
            this.LblEspera1.TabIndex = 11;
            this.LblEspera1.Text = "Aguardando...";
            this.LblEspera1.Visible = false;
            // 
            // TimResetaJogada
            // 
            this.TimResetaJogada.Interval = 4000;
            this.TimResetaJogada.Tick += new System.EventHandler(this.TimResetaJogada_Tick);
            // 
            // LblGanhador
            // 
            this.LblGanhador.AutoSize = true;
            this.LblGanhador.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGanhador.ForeColor = System.Drawing.Color.White;
            this.LblGanhador.Location = new System.Drawing.Point(223, 56);
            this.LblGanhador.Name = "LblGanhador";
            this.LblGanhador.Size = new System.Drawing.Size(91, 16);
            this.LblGanhador.TabIndex = 12;
            this.LblGanhador.Text = "LblGanhador";
            this.LblGanhador.Visible = false;
            // 
            // FrmJP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 312);
            this.Controls.Add(this.LblGanhador);
            this.Controls.Add(this.LblEspera1);
            this.Controls.Add(this.LblEspera2);
            this.Controls.Add(this.BtnTesoura);
            this.Controls.Add(this.BtnPapel);
            this.Controls.Add(this.BtnPedra);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.LblVitorias1);
            this.Controls.Add(this.LblVitorias2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNome1);
            this.Controls.Add(this.LblNome2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmJP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joguempô";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmJP_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVitorias2;
        private System.Windows.Forms.Label LblVitorias1;
        public System.Windows.Forms.Label LblNome2;
        public System.Windows.Forms.Label LblNome1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Button BtnPedra;
        private System.Windows.Forms.Button BtnPapel;
        private System.Windows.Forms.Button BtnTesoura;
        private System.Windows.Forms.Timer TimTrocaImg;
        private System.Windows.Forms.Label LblEspera2;
        private System.Windows.Forms.Label LblEspera1;
        private System.Windows.Forms.Timer TimResetaJogada;
        private System.Windows.Forms.Label LblGanhador;
    }
}
namespace Menu
{
    partial class FrmPsicFim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPsicFim));
            this.LblInfoPass = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblAcertos = new System.Windows.Forms.Label();
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.TimHabBtn = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblInfoPass
            // 
            this.LblInfoPass.AutoSize = true;
            this.LblInfoPass.BackColor = System.Drawing.Color.Transparent;
            this.LblInfoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblInfoPass.Location = new System.Drawing.Point(-49, 50);
            this.LblInfoPass.Name = "LblInfoPass";
            this.LblInfoPass.Size = new System.Drawing.Size(724, 26);
            this.LblInfoPass.TabIndex = 17;
            this.LblInfoPass.Text = "Para passar nesta prova é necessário acertar pelo menos 60% dos testes";
            // 
            // BtnMenu
            // 
            this.BtnMenu.Enabled = false;
            this.BtnMenu.Location = new System.Drawing.Point(539, 444);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 16;
            this.BtnMenu.Text = "&Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.BackColor = System.Drawing.Color.Transparent;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblResult.Location = new System.Drawing.Point(160, 210);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(307, 71);
            this.LblResult.TabIndex = 15;
            this.LblResult.Text = "Resultado";
            // 
            // LblAcertos
            // 
            this.LblAcertos.AutoSize = true;
            this.LblAcertos.BackColor = System.Drawing.Color.Transparent;
            this.LblAcertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblAcertos.Location = new System.Drawing.Point(281, 281);
            this.LblAcertos.Name = "LblAcertos";
            this.LblAcertos.Size = new System.Drawing.Size(64, 13);
            this.LblAcertos.TabIndex = 14;
            this.LblAcertos.Text = "Acertou: 0%";
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbltitulo.Location = new System.Drawing.Point(37, 9);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(553, 39);
            this.Lbltitulo.TabIndex = 13;
            this.Lbltitulo.Text = "Resultado do Teste Psicotécnico";
            // 
            // TimHabBtn
            // 
            this.TimHabBtn.Interval = 3000;
            this.TimHabBtn.Tick += new System.EventHandler(this.TimHabBtn_Tick);
            // 
            // FrmPsicFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.FundoFim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 491);
            this.Controls.Add(this.LblInfoPass);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblAcertos);
            this.Controls.Add(this.Lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPsicFim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FrmPsicFim_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfoPass;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblAcertos;
        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.Timer TimHabBtn;
    }
}
namespace Cimg
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
            this.PnlTela = new System.Windows.Forms.Panel();
            this.BtnRet = new System.Windows.Forms.Button();
            this.BtnCirc = new System.Windows.Forms.Button();
            this.BtnPolig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTamanho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlCor = new System.Windows.Forms.Panel();
            this.CDSelec = new System.Windows.Forms.ColorDialog();
            this.CbMPontos = new System.Windows.Forms.CheckBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.CbFill = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PnlTela
            // 
            this.PnlTela.AllowDrop = true;
            this.PnlTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTela.BackColor = System.Drawing.Color.Gray;
            this.PnlTela.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PnlTela.Location = new System.Drawing.Point(0, 38);
            this.PnlTela.Name = "PnlTela";
            this.PnlTela.Size = new System.Drawing.Size(632, 409);
            this.PnlTela.TabIndex = 0;
            this.PnlTela.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlTela_DragDrop);
            this.PnlTela.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlTela_DragEnter);
            this.PnlTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTela_MouseDown);
            this.PnlTela.MouseEnter += new System.EventHandler(this.PnlTela_MouseEnter);
            this.PnlTela.MouseLeave += new System.EventHandler(this.PnlTela_MouseLeave);
            this.PnlTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTela_MouseMove);
            // 
            // BtnRet
            // 
            this.BtnRet.Image = ((System.Drawing.Image)(resources.GetObject("BtnRet.Image")));
            this.BtnRet.Location = new System.Drawing.Point(0, 0);
            this.BtnRet.Name = "BtnRet";
            this.BtnRet.Size = new System.Drawing.Size(38, 38);
            this.BtnRet.TabIndex = 2;
            this.BtnRet.UseVisualStyleBackColor = true;
            this.BtnRet.Click += new System.EventHandler(this.BtnRet_Click);
            // 
            // BtnCirc
            // 
            this.BtnCirc.Image = ((System.Drawing.Image)(resources.GetObject("BtnCirc.Image")));
            this.BtnCirc.Location = new System.Drawing.Point(37, 0);
            this.BtnCirc.Name = "BtnCirc";
            this.BtnCirc.Size = new System.Drawing.Size(38, 38);
            this.BtnCirc.TabIndex = 3;
            this.BtnCirc.UseVisualStyleBackColor = true;
            this.BtnCirc.Click += new System.EventHandler(this.BtnCirc_Click);
            // 
            // BtnPolig
            // 
            this.BtnPolig.Image = ((System.Drawing.Image)(resources.GetObject("BtnPolig.Image")));
            this.BtnPolig.Location = new System.Drawing.Point(74, 0);
            this.BtnPolig.Name = "BtnPolig";
            this.BtnPolig.Size = new System.Drawing.Size(38, 38);
            this.BtnPolig.TabIndex = 4;
            this.BtnPolig.UseVisualStyleBackColor = true;
            this.BtnPolig.Click += new System.EventHandler(this.BtnPolig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamanho:";
            // 
            // TxtTamanho
            // 
            this.TxtTamanho.Location = new System.Drawing.Point(179, 10);
            this.TxtTamanho.Name = "TxtTamanho";
            this.TxtTamanho.Size = new System.Drawing.Size(31, 20);
            this.TxtTamanho.TabIndex = 7;
            this.TxtTamanho.Text = "1";
            this.TxtTamanho.TextChanged += new System.EventHandler(this.TxtTamanho_TextChanged);
            this.TxtTamanho.Leave += new System.EventHandler(this.TxtTamanho_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cor:";
            // 
            // PnlCor
            // 
            this.PnlCor.BackColor = System.Drawing.Color.Black;
            this.PnlCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlCor.Location = new System.Drawing.Point(248, 8);
            this.PnlCor.Name = "PnlCor";
            this.PnlCor.Size = new System.Drawing.Size(42, 23);
            this.PnlCor.TabIndex = 9;
            this.PnlCor.Click += new System.EventHandler(this.PnlCor_Click);
            // 
            // CDSelec
            // 
            this.CDSelec.AnyColor = true;
            this.CDSelec.FullOpen = true;
            // 
            // CbMPontos
            // 
            this.CbMPontos.AutoSize = true;
            this.CbMPontos.Location = new System.Drawing.Point(296, 13);
            this.CbMPontos.Name = "CbMPontos";
            this.CbMPontos.Size = new System.Drawing.Size(97, 17);
            this.CbMPontos.TabIndex = 11;
            this.CbMPontos.Text = "Mostrar Pontos";
            this.CbMPontos.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(594, 0);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(38, 38);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.Location = new System.Drawing.Point(557, 0);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(38, 38);
            this.BtnAbrir.TabIndex = 13;
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // CbFill
            // 
            this.CbFill.AutoSize = true;
            this.CbFill.Location = new System.Drawing.Point(399, 13);
            this.CbFill.Name = "CbFill";
            this.CbFill.Size = new System.Drawing.Size(75, 17);
            this.CbFill.TabIndex = 14;
            this.CbFill.Text = "Preencher";
            this.CbFill.UseVisualStyleBackColor = true;
            this.CbFill.CheckedChanged += new System.EventHandler(this.CbFill_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 447);
            this.Controls.Add(this.CbFill);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CbMPontos);
            this.Controls.Add(this.PnlCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTamanho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPolig);
            this.Controls.Add(this.BtnCirc);
            this.Controls.Add(this.BtnRet);
            this.Controls.Add(this.PnlTela);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagem de Coordenada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTela;
        private System.Windows.Forms.Button BtnRet;
        private System.Windows.Forms.Button BtnCirc;
        private System.Windows.Forms.Button BtnPolig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTamanho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlCor;
        private System.Windows.Forms.ColorDialog CDSelec;
        private System.Windows.Forms.CheckBox CbMPontos;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.CheckBox CbFill;
    }
}


namespace Busca
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
            this.LblPath = new System.Windows.Forms.Label();
            this.BtnEscolher = new System.Windows.Forms.Button();
            this.FbdCaminho = new System.Windows.Forms.FolderBrowserDialog();
            this.LstConteudo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtProcura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPath
            // 
            this.LblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(93, 194);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(85, 13);
            this.LblPath.TabIndex = 0;
            this.LblPath.Text = "Procurar em: C:\\";
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEscolher.Location = new System.Drawing.Point(12, 189);
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Size = new System.Drawing.Size(75, 23);
            this.BtnEscolher.TabIndex = 1;
            this.BtnEscolher.Text = "&Escolher";
            this.BtnEscolher.UseVisualStyleBackColor = true;
            this.BtnEscolher.Click += new System.EventHandler(this.BtnEscolher_Click);
            // 
            // FbdCaminho
            // 
            this.FbdCaminho.ShowNewFolderButton = false;
            // 
            // LstConteudo
            // 
            this.LstConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LstConteudo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LstConteudo.FullRowSelect = true;
            this.LstConteudo.GridLines = true;
            this.LstConteudo.Location = new System.Drawing.Point(12, 12);
            this.LstConteudo.Name = "LstConteudo";
            this.LstConteudo.Size = new System.Drawing.Size(561, 167);
            this.LstConteudo.TabIndex = 2;
            this.LstConteudo.UseCompatibleStateImageBehavior = false;
            this.LstConteudo.View = System.Windows.Forms.View.Details;
            this.LstConteudo.DoubleClick += new System.EventHandler(this.LstConteudo_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Caminho";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tamanho";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data de modificação";
            this.columnHeader4.Width = 139;
            // 
            // TxtProcura
            // 
            this.TxtProcura.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtProcura.Location = new System.Drawing.Point(173, 220);
            this.TxtProcura.Name = "TxtProcura";
            this.TxtProcura.Size = new System.Drawing.Size(239, 20);
            this.TxtProcura.TabIndex = 4;
            this.TxtProcura.TextChanged += new System.EventHandler(this.TxtProcura_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProcura);
            this.Controls.Add(this.LstConteudo);
            this.Controls.Add(this.BtnEscolher);
            this.Controls.Add(this.LblPath);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca (0)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Button BtnEscolher;
        private System.Windows.Forms.FolderBrowserDialog FbdCaminho;
        private System.Windows.Forms.ListView LstConteudo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox TxtProcura;
        private System.Windows.Forms.Label label1;
    }
}


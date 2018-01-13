namespace ProjetoLivraria
{
    partial class FrmConsulta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.CmbAutor = new System.Windows.Forms.ComboBox();
            this.BtnConAutor = new System.Windows.Forms.Button();
            this.TxtFilAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbCli = new System.Windows.Forms.ComboBox();
            this.BtnConCli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFilCli = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnEditRel = new System.Windows.Forms.Button();
            this.CmbEditor = new System.Windows.Forms.ComboBox();
            this.BtnConEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFilEditora = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BtnLivroRel = new System.Windows.Forms.Button();
            this.CmbLivro = new System.Windows.Forms.ComboBox();
            this.BtnConLivro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFilLivro = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnVendaRel = new System.Windows.Forms.Button();
            this.CmbVenda = new System.Windows.Forms.ComboBox();
            this.BtnConVenda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFilVenda = new System.Windows.Forms.TextBox();
            this.DGVConsulta = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 257);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.CmbAutor);
            this.tabPage1.Controls.Add(this.BtnConAutor);
            this.tabPage1.Controls.Add(this.TxtFilAutor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Gerar Relatório";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CmbAutor
            // 
            this.CmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAutor.FormattingEnabled = true;
            this.CmbAutor.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.CmbAutor.Location = new System.Drawing.Point(157, 6);
            this.CmbAutor.Name = "CmbAutor";
            this.CmbAutor.Size = new System.Drawing.Size(121, 21);
            this.CmbAutor.TabIndex = 26;
            // 
            // BtnConAutor
            // 
            this.BtnConAutor.Location = new System.Drawing.Point(284, 5);
            this.BtnConAutor.Name = "BtnConAutor";
            this.BtnConAutor.Size = new System.Drawing.Size(75, 23);
            this.BtnConAutor.TabIndex = 4;
            this.BtnConAutor.Text = "Filtrar";
            this.BtnConAutor.UseVisualStyleBackColor = true;
            this.BtnConAutor.Click += new System.EventHandler(this.BtnConAutor_Click);
            // 
            // TxtFilAutor
            // 
            this.TxtFilAutor.Location = new System.Drawing.Point(51, 6);
            this.TxtFilAutor.Name = "TxtFilAutor";
            this.TxtFilAutor.Size = new System.Drawing.Size(100, 20);
            this.TxtFilAutor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.CmbCli);
            this.tabPage2.Controls.Add(this.BtnConCli);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtFilCli);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmbCli
            // 
            this.CmbCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCli.FormattingEnabled = true;
            this.CmbCli.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.CmbCli.Location = new System.Drawing.Point(157, 6);
            this.CmbCli.Name = "CmbCli";
            this.CmbCli.Size = new System.Drawing.Size(121, 21);
            this.CmbCli.TabIndex = 26;
            // 
            // BtnConCli
            // 
            this.BtnConCli.Location = new System.Drawing.Point(284, 5);
            this.BtnConCli.Name = "BtnConCli";
            this.BtnConCli.Size = new System.Drawing.Size(75, 23);
            this.BtnConCli.TabIndex = 6;
            this.BtnConCli.Text = "Filtrar";
            this.BtnConCli.UseVisualStyleBackColor = true;
            this.BtnConCli.Click += new System.EventHandler(this.BtnConCli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Busca";
            // 
            // TxtFilCli
            // 
            this.TxtFilCli.Location = new System.Drawing.Point(51, 6);
            this.TxtFilCli.Name = "TxtFilCli";
            this.TxtFilCli.Size = new System.Drawing.Size(100, 20);
            this.TxtFilCli.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnEditRel);
            this.tabPage3.Controls.Add(this.CmbEditor);
            this.tabPage3.Controls.Add(this.BtnConEdit);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.TxtFilEditora);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(475, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Editora";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnEditRel
            // 
            this.BtnEditRel.Location = new System.Drawing.Point(362, 5);
            this.BtnEditRel.Name = "BtnEditRel";
            this.BtnEditRel.Size = new System.Drawing.Size(90, 23);
            this.BtnEditRel.TabIndex = 28;
            this.BtnEditRel.Text = "Gerar Relatório";
            this.BtnEditRel.UseVisualStyleBackColor = true;
            // 
            // CmbEditor
            // 
            this.CmbEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEditor.FormattingEnabled = true;
            this.CmbEditor.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.CmbEditor.Location = new System.Drawing.Point(157, 6);
            this.CmbEditor.Name = "CmbEditor";
            this.CmbEditor.Size = new System.Drawing.Size(121, 21);
            this.CmbEditor.TabIndex = 26;
            // 
            // BtnConEdit
            // 
            this.BtnConEdit.Location = new System.Drawing.Point(284, 5);
            this.BtnConEdit.Name = "BtnConEdit";
            this.BtnConEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnConEdit.TabIndex = 10;
            this.BtnConEdit.Text = "Filtrar";
            this.BtnConEdit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Busca";
            // 
            // TxtFilEditora
            // 
            this.TxtFilEditora.Location = new System.Drawing.Point(51, 6);
            this.TxtFilEditora.Name = "TxtFilEditora";
            this.TxtFilEditora.Size = new System.Drawing.Size(100, 20);
            this.TxtFilEditora.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BtnLivroRel);
            this.tabPage4.Controls.Add(this.CmbLivro);
            this.tabPage4.Controls.Add(this.BtnConLivro);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.TxtFilLivro);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(475, 231);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Livro";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtnLivroRel
            // 
            this.BtnLivroRel.Location = new System.Drawing.Point(362, 5);
            this.BtnLivroRel.Name = "BtnLivroRel";
            this.BtnLivroRel.Size = new System.Drawing.Size(90, 23);
            this.BtnLivroRel.TabIndex = 27;
            this.BtnLivroRel.Text = "Gerar Relatório";
            this.BtnLivroRel.UseVisualStyleBackColor = true;
            // 
            // CmbLivro
            // 
            this.CmbLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLivro.FormattingEnabled = true;
            this.CmbLivro.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.CmbLivro.Location = new System.Drawing.Point(157, 6);
            this.CmbLivro.Name = "CmbLivro";
            this.CmbLivro.Size = new System.Drawing.Size(121, 21);
            this.CmbLivro.TabIndex = 26;
            // 
            // BtnConLivro
            // 
            this.BtnConLivro.Location = new System.Drawing.Point(284, 5);
            this.BtnConLivro.Name = "BtnConLivro";
            this.BtnConLivro.Size = new System.Drawing.Size(75, 23);
            this.BtnConLivro.TabIndex = 16;
            this.BtnConLivro.Text = "Filtrar";
            this.BtnConLivro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Busca";
            // 
            // TxtFilLivro
            // 
            this.TxtFilLivro.Location = new System.Drawing.Point(51, 6);
            this.TxtFilLivro.Name = "TxtFilLivro";
            this.TxtFilLivro.Size = new System.Drawing.Size(100, 20);
            this.TxtFilLivro.TabIndex = 10;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.BtnVendaRel);
            this.tabPage5.Controls.Add(this.CmbVenda);
            this.tabPage5.Controls.Add(this.BtnConVenda);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.TxtFilVenda);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(475, 231);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Venda";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // BtnVendaRel
            // 
            this.BtnVendaRel.Location = new System.Drawing.Point(362, 5);
            this.BtnVendaRel.Name = "BtnVendaRel";
            this.BtnVendaRel.Size = new System.Drawing.Size(92, 23);
            this.BtnVendaRel.TabIndex = 26;
            this.BtnVendaRel.Text = "Gerar Relatório";
            this.BtnVendaRel.UseVisualStyleBackColor = true;
            // 
            // CmbVenda
            // 
            this.CmbVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVenda.FormattingEnabled = true;
            this.CmbVenda.Items.AddRange(new object[] {
            "Valor",
            "Data"});
            this.CmbVenda.Location = new System.Drawing.Point(157, 6);
            this.CmbVenda.Name = "CmbVenda";
            this.CmbVenda.Size = new System.Drawing.Size(121, 21);
            this.CmbVenda.TabIndex = 25;
            // 
            // BtnConVenda
            // 
            this.BtnConVenda.Location = new System.Drawing.Point(284, 5);
            this.BtnConVenda.Name = "BtnConVenda";
            this.BtnConVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnConVenda.TabIndex = 24;
            this.BtnConVenda.Text = "Filtrar";
            this.BtnConVenda.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Busca";
            // 
            // TxtFilVenda
            // 
            this.TxtFilVenda.Location = new System.Drawing.Point(51, 6);
            this.TxtFilVenda.Name = "TxtFilVenda";
            this.TxtFilVenda.Size = new System.Drawing.Size(100, 20);
            this.TxtFilVenda.TabIndex = 16;
            // 
            // DGVConsulta
            // 
            this.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsulta.Location = new System.Drawing.Point(12, 55);
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.Size = new System.Drawing.Size(459, 191);
            this.DGVConsulta.TabIndex = 2;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 256);
            this.Controls.Add(this.DGVConsulta);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnConAutor;
        private System.Windows.Forms.TextBox TxtFilAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnConCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFilCli;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnConEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFilEditora;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtnConLivro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFilLivro;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button BtnConVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFilVenda;
        private System.Windows.Forms.DataGridView DGVConsulta;
        private System.Windows.Forms.ComboBox CmbAutor;
        private System.Windows.Forms.ComboBox CmbCli;
        private System.Windows.Forms.ComboBox CmbEditor;
        private System.Windows.Forms.ComboBox CmbLivro;
        private System.Windows.Forms.ComboBox CmbVenda;
        private System.Windows.Forms.Button BtnVendaRel;
        private System.Windows.Forms.Button BtnLivroRel;
        private System.Windows.Forms.Button BtnEditRel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
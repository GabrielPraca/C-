namespace ProjetoLivraria
{
    partial class FrmCadastro
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
            this.BtnCadAutor = new System.Windows.Forms.Button();
            this.TxtNAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnCadCli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCCli = new System.Windows.Forms.TextBox();
            this.TxtTCli = new System.Windows.Forms.TextBox();
            this.TxtNCli = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnCadEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtConEdit = new System.Windows.Forms.TextBox();
            this.TxtNEditora = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BtnCadLivro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodAuto = new System.Windows.Forms.TextBox();
            this.TxtNLivro = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnCadVenda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodLivro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCodCli = new System.Windows.Forms.TextBox();
            this.TxtDataVenda = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(312, 184);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnCadAutor);
            this.tabPage1.Controls.Add(this.TxtNAutor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnCadAutor
            // 
            this.BtnCadAutor.Location = new System.Drawing.Point(183, 19);
            this.BtnCadAutor.Name = "BtnCadAutor";
            this.BtnCadAutor.Size = new System.Drawing.Size(75, 23);
            this.BtnCadAutor.TabIndex = 4;
            this.BtnCadAutor.Text = "Cadastrar";
            this.BtnCadAutor.UseVisualStyleBackColor = true;
            this.BtnCadAutor.Click += new System.EventHandler(this.BtnCadAutor_Click);
            // 
            // TxtNAutor
            // 
            this.TxtNAutor.Location = new System.Drawing.Point(77, 21);
            this.TxtNAutor.Name = "TxtNAutor";
            this.TxtNAutor.Size = new System.Drawing.Size(100, 20);
            this.TxtNAutor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Autor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnCadCli);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TxtCCli);
            this.tabPage2.Controls.Add(this.TxtTCli);
            this.tabPage2.Controls.Add(this.TxtNCli);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 158);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCadCli
            // 
            this.BtnCadCli.Location = new System.Drawing.Point(212, 17);
            this.BtnCadCli.Name = "BtnCadCli";
            this.BtnCadCli.Size = new System.Drawing.Size(75, 23);
            this.BtnCadCli.TabIndex = 6;
            this.BtnCadCli.Text = "Cadastrar";
            this.BtnCadCli.UseVisualStyleBackColor = true;
            this.BtnCadCli.Click += new System.EventHandler(this.BtnCadCli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP";
            // 
            // TxtCCli
            // 
            this.TxtCCli.Location = new System.Drawing.Point(89, 83);
            this.TxtCCli.Name = "TxtCCli";
            this.TxtCCli.Size = new System.Drawing.Size(100, 20);
            this.TxtCCli.TabIndex = 2;
            // 
            // TxtTCli
            // 
            this.TxtTCli.Location = new System.Drawing.Point(89, 50);
            this.TxtTCli.Name = "TxtTCli";
            this.TxtTCli.Size = new System.Drawing.Size(100, 20);
            this.TxtTCli.TabIndex = 1;
            // 
            // TxtNCli
            // 
            this.TxtNCli.Location = new System.Drawing.Point(89, 19);
            this.TxtNCli.Name = "TxtNCli";
            this.TxtNCli.Size = new System.Drawing.Size(100, 20);
            this.TxtNCli.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnCadEdit);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.TxtConEdit);
            this.tabPage3.Controls.Add(this.TxtNEditora);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(304, 158);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Editora";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnCadEdit
            // 
            this.BtnCadEdit.Location = new System.Drawing.Point(191, 11);
            this.BtnCadEdit.Name = "BtnCadEdit";
            this.BtnCadEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnCadEdit.TabIndex = 10;
            this.BtnCadEdit.Text = "Cadastrar";
            this.BtnCadEdit.UseVisualStyleBackColor = true;
            this.BtnCadEdit.Click += new System.EventHandler(this.BtnCadEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contato";
            // 
            // TxtConEdit
            // 
            this.TxtConEdit.Location = new System.Drawing.Point(85, 40);
            this.TxtConEdit.Name = "TxtConEdit";
            this.TxtConEdit.Size = new System.Drawing.Size(100, 20);
            this.TxtConEdit.TabIndex = 7;
            // 
            // TxtNEditora
            // 
            this.TxtNEditora.Location = new System.Drawing.Point(85, 13);
            this.TxtNEditora.Name = "TxtNEditora";
            this.TxtNEditora.Size = new System.Drawing.Size(100, 20);
            this.TxtNEditora.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BtnCadLivro);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.TxtCodEdit);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.TxtCodAuto);
            this.tabPage4.Controls.Add(this.TxtNLivro);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(304, 158);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Livro";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtnCadLivro
            // 
            this.BtnCadLivro.Location = new System.Drawing.Point(181, 12);
            this.BtnCadLivro.Name = "BtnCadLivro";
            this.BtnCadLivro.Size = new System.Drawing.Size(75, 23);
            this.BtnCadLivro.TabIndex = 16;
            this.BtnCadLivro.Text = "Cadastrar";
            this.BtnCadLivro.UseVisualStyleBackColor = true;
            this.BtnCadLivro.Click += new System.EventHandler(this.BtnCadLivro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cod Editora";
            // 
            // TxtCodEdit
            // 
            this.TxtCodEdit.Location = new System.Drawing.Point(75, 66);
            this.TxtCodEdit.Name = "TxtCodEdit";
            this.TxtCodEdit.Size = new System.Drawing.Size(100, 20);
            this.TxtCodEdit.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome Livro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cod Autor";
            // 
            // TxtCodAuto
            // 
            this.TxtCodAuto.Location = new System.Drawing.Point(75, 40);
            this.TxtCodAuto.Name = "TxtCodAuto";
            this.TxtCodAuto.Size = new System.Drawing.Size(100, 20);
            this.TxtCodAuto.TabIndex = 11;
            // 
            // TxtNLivro
            // 
            this.TxtNLivro.Location = new System.Drawing.Point(75, 14);
            this.TxtNLivro.Name = "TxtNLivro";
            this.TxtNLivro.Size = new System.Drawing.Size(100, 20);
            this.TxtNLivro.TabIndex = 10;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.BtnCadVenda);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.TxtValor);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.TxtCodLivro);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.TxtCodCli);
            this.tabPage5.Controls.Add(this.TxtDataVenda);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(304, 158);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Venda";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // BtnCadVenda
            // 
            this.BtnCadVenda.Location = new System.Drawing.Point(200, 8);
            this.BtnCadVenda.Name = "BtnCadVenda";
            this.BtnCadVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnCadVenda.TabIndex = 24;
            this.BtnCadVenda.Text = "Cadastrar";
            this.BtnCadVenda.UseVisualStyleBackColor = true;
            this.BtnCadVenda.Click += new System.EventHandler(this.BtnCadVenda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Valor Total";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(94, 95);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Codigo Livro";
            // 
            // TxtCodLivro
            // 
            this.TxtCodLivro.Location = new System.Drawing.Point(94, 69);
            this.TxtCodLivro.Name = "TxtCodLivro";
            this.TxtCodLivro.Size = new System.Drawing.Size(100, 20);
            this.TxtCodLivro.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Data Venda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Codigo Cliente";
            // 
            // TxtCodCli
            // 
            this.TxtCodCli.Location = new System.Drawing.Point(94, 39);
            this.TxtCodCli.Name = "TxtCodCli";
            this.TxtCodCli.Size = new System.Drawing.Size(100, 20);
            this.TxtCodCli.TabIndex = 17;
            // 
            // TxtDataVenda
            // 
            this.TxtDataVenda.Location = new System.Drawing.Point(94, 10);
            this.TxtDataVenda.Name = "TxtDataVenda";
            this.TxtDataVenda.Size = new System.Drawing.Size(100, 20);
            this.TxtDataVenda.TabIndex = 16;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 184);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtNAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCCli;
        private System.Windows.Forms.TextBox TxtTCli;
        private System.Windows.Forms.TextBox TxtNCli;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtConEdit;
        private System.Windows.Forms.TextBox TxtNEditora;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCodEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodAuto;
        private System.Windows.Forms.TextBox TxtNLivro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodLivro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCodCli;
        private System.Windows.Forms.TextBox TxtDataVenda;
        private System.Windows.Forms.Button BtnCadAutor;
        private System.Windows.Forms.Button BtnCadCli;
        private System.Windows.Forms.Button BtnCadEdit;
        private System.Windows.Forms.Button BtnCadLivro;
        private System.Windows.Forms.Button BtnCadVenda;
    }
}
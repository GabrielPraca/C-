namespace Projeto_Exercicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSelectUsu = new System.Windows.Forms.Button();
            this.BtnSelectLivro = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtLivro = new System.Windows.Forms.TextBox();
            this.TxtCodEmp = new System.Windows.Forms.TextBox();
            this.TxtFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LstEmp = new System.Windows.Forms.ListView();
            this.Livro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSelecFun = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultaToolStripMenuItem.Text = "Consultar";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // BtnSelectUsu
            // 
            this.BtnSelectUsu.Location = new System.Drawing.Point(238, 51);
            this.BtnSelectUsu.Name = "BtnSelectUsu";
            this.BtnSelectUsu.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectUsu.TabIndex = 1;
            this.BtnSelectUsu.Text = "Selecionar";
            this.BtnSelectUsu.UseVisualStyleBackColor = true;
            this.BtnSelectUsu.Click += new System.EventHandler(this.BtnSelectUsu_Click);
            // 
            // BtnSelectLivro
            // 
            this.BtnSelectLivro.Location = new System.Drawing.Point(238, 77);
            this.BtnSelectLivro.Name = "BtnSelectLivro";
            this.BtnSelectLivro.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectLivro.TabIndex = 2;
            this.BtnSelectLivro.Text = "Selecionar";
            this.BtnSelectLivro.UseVisualStyleBackColor = true;
            this.BtnSelectLivro.Click += new System.EventHandler(this.BtnSelectLivro_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(12, 131);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 3;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(93, 131);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalizar.TabIndex = 4;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código do Emprestimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(129, 53);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 8;
            // 
            // TxtLivro
            // 
            this.TxtLivro.Location = new System.Drawing.Point(129, 79);
            this.TxtLivro.Name = "TxtLivro";
            this.TxtLivro.Size = new System.Drawing.Size(100, 20);
            this.TxtLivro.TabIndex = 9;
            // 
            // TxtCodEmp
            // 
            this.TxtCodEmp.Location = new System.Drawing.Point(129, 27);
            this.TxtCodEmp.Name = "TxtCodEmp";
            this.TxtCodEmp.Size = new System.Drawing.Size(100, 20);
            this.TxtCodEmp.TabIndex = 11;
            // 
            // TxtFuncionario
            // 
            this.TxtFuncionario.Location = new System.Drawing.Point(129, 105);
            this.TxtFuncionario.Name = "TxtFuncionario";
            this.TxtFuncionario.Size = new System.Drawing.Size(100, 20);
            this.TxtFuncionario.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Funcionário";
            // 
            // LstEmp
            // 
            this.LstEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Livro});
            this.LstEmp.FullRowSelect = true;
            this.LstEmp.GridLines = true;
            this.LstEmp.Location = new System.Drawing.Point(12, 160);
            this.LstEmp.Name = "LstEmp";
            this.LstEmp.Size = new System.Drawing.Size(436, 162);
            this.LstEmp.TabIndex = 14;
            this.LstEmp.UseCompatibleStateImageBehavior = false;
            this.LstEmp.View = System.Windows.Forms.View.Details;
            // 
            // Livro
            // 
            this.Livro.Text = "Livro";
            this.Livro.Width = 65;
            // 
            // BtnSelecFun
            // 
            this.BtnSelecFun.Location = new System.Drawing.Point(238, 103);
            this.BtnSelecFun.Name = "BtnSelecFun";
            this.BtnSelecFun.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecFun.TabIndex = 15;
            this.BtnSelecFun.Text = "Selecionar";
            this.BtnSelecFun.UseVisualStyleBackColor = true;
            this.BtnSelecFun.Click += new System.EventHandler(this.BtnSelecFun_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 334);
            this.Controls.Add(this.BtnSelecFun);
            this.Controls.Add(this.LstEmp);
            this.Controls.Add(this.TxtFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCodEmp);
            this.Controls.Add(this.TxtLivro);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnSelectLivro);
            this.Controls.Add(this.BtnSelectUsu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.Button BtnSelectUsu;
        private System.Windows.Forms.Button BtnSelectLivro;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtLivro;
        private System.Windows.Forms.TextBox TxtCodEmp;
        private System.Windows.Forms.TextBox TxtFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LstEmp;
        private System.Windows.Forms.ColumnHeader Livro;
        private System.Windows.Forms.Button BtnSelecFun;
    }
}


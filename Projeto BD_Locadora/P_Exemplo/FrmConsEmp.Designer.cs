namespace P_Exemplo
{
    partial class FrmConsEmp
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
            this.DgvConsuta = new System.Windows.Forms.DataGridView();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.LblTConsulta = new System.Windows.Forms.Label();
            this.RdbCli = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RdbFil = new System.Windows.Forms.RadioButton();
            this.RdbFun = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsuta)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsuta
            // 
            this.DgvConsuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsuta.Location = new System.Drawing.Point(15, 59);
            this.DgvConsuta.Name = "DgvConsuta";
            this.DgvConsuta.Size = new System.Drawing.Size(327, 221);
            this.DgvConsuta.TabIndex = 7;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(264, 4);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 6;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(125, 6);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(133, 20);
            this.TxtConsulta.TabIndex = 5;
            // 
            // LblTConsulta
            // 
            this.LblTConsulta.AutoSize = true;
            this.LblTConsulta.Location = new System.Drawing.Point(12, 9);
            this.LblTConsulta.Name = "LblTConsulta";
            this.LblTConsulta.Size = new System.Drawing.Size(85, 13);
            this.LblTConsulta.TabIndex = 4;
            this.LblTConsulta.Text = "Nome do Cliente";
            // 
            // RdbCli
            // 
            this.RdbCli.AutoSize = true;
            this.RdbCli.Checked = true;
            this.RdbCli.Location = new System.Drawing.Point(92, 36);
            this.RdbCli.Name = "RdbCli";
            this.RdbCli.Size = new System.Drawing.Size(57, 17);
            this.RdbCli.TabIndex = 8;
            this.RdbCli.TabStop = true;
            this.RdbCli.Text = "Cliente";
            this.RdbCli.UseVisualStyleBackColor = true;
            this.RdbCli.CheckedChanged += new System.EventHandler(this.RdbCli_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar por:";
            // 
            // RdbFil
            // 
            this.RdbFil.AutoSize = true;
            this.RdbFil.Location = new System.Drawing.Point(155, 36);
            this.RdbFil.Name = "RdbFil";
            this.RdbFil.Size = new System.Drawing.Size(49, 17);
            this.RdbFil.TabIndex = 10;
            this.RdbFil.Text = "Filme";
            this.RdbFil.UseVisualStyleBackColor = true;
            this.RdbFil.CheckedChanged += new System.EventHandler(this.RdbFil_CheckedChanged);
            // 
            // RdbFun
            // 
            this.RdbFun.AutoSize = true;
            this.RdbFun.Location = new System.Drawing.Point(209, 36);
            this.RdbFun.Name = "RdbFun";
            this.RdbFun.Size = new System.Drawing.Size(80, 17);
            this.RdbFun.TabIndex = 11;
            this.RdbFun.Text = "Funcionário";
            this.RdbFun.UseVisualStyleBackColor = true;
            this.RdbFun.CheckedChanged += new System.EventHandler(this.RdbFun_CheckedChanged);
            // 
            // FrmConsEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 292);
            this.Controls.Add(this.RdbFun);
            this.Controls.Add(this.RdbFil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RdbCli);
            this.Controls.Add(this.DgvConsuta);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.LblTConsulta);
            this.Name = "FrmConsEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsEmp";
            this.Load += new System.EventHandler(this.FrmConsEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsuta;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.Label LblTConsulta;
        private System.Windows.Forms.RadioButton RdbCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdbFil;
        private System.Windows.Forms.RadioButton RdbFun;
    }
}
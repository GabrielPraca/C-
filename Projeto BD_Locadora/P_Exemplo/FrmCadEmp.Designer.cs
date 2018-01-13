namespace P_Exemplo
{
    partial class FrmCadEmp
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
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxTDataEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDataDev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodFilme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(116, 6);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(59, 20);
            this.TxtCod.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // TxTDataEmp
            // 
            this.TxTDataEmp.Location = new System.Drawing.Point(116, 32);
            this.TxTDataEmp.Name = "TxTDataEmp";
            this.TxTDataEmp.Size = new System.Drawing.Size(146, 20);
            this.TxTDataEmp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Empréstimo";
            // 
            // TxtCodCli
            // 
            this.TxtCodCli.Location = new System.Drawing.Point(116, 58);
            this.TxtCodCli.Name = "TxtCodCli";
            this.TxtCodCli.Size = new System.Drawing.Size(59, 20);
            this.TxtCodCli.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código Cliente";
            // 
            // TxtCodFunc
            // 
            this.TxtCodFunc.Location = new System.Drawing.Point(116, 84);
            this.TxtCodFunc.Name = "TxtCodFunc";
            this.TxtCodFunc.Size = new System.Drawing.Size(59, 20);
            this.TxtCodFunc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código Funcionário";
            // 
            // TxtDataDev
            // 
            this.TxtDataDev.Location = new System.Drawing.Point(116, 110);
            this.TxtDataDev.Name = "TxtDataDev";
            this.TxtDataDev.Size = new System.Drawing.Size(146, 20);
            this.TxtDataDev.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Devolução";
            // 
            // TxtCodFilme
            // 
            this.TxtCodFilme.Location = new System.Drawing.Point(116, 136);
            this.TxtCodFilme.Name = "TxtCodFilme";
            this.TxtCodFilme.Size = new System.Drawing.Size(59, 20);
            this.TxtCodFilme.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Código Filme";
            // 
            // BtnCad
            // 
            this.BtnCad.Location = new System.Drawing.Point(100, 167);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(75, 23);
            this.BtnCad.TabIndex = 15;
            this.BtnCad.Text = "&Cadastrar";
            this.BtnCad.UseVisualStyleBackColor = true;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // FrmCadEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 202);
            this.Controls.Add(this.BtnCad);
            this.Controls.Add(this.TxtCodFilme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDataDev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCodCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxTDataEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCod);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTDataEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDataDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCad;

    }
}
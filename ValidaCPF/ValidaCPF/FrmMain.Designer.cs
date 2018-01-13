namespace ValidaCPF
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
            this.BtnValidaCPF = new System.Windows.Forms.Button();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.BtnValidaCNPJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnValidaCPF
            // 
            this.BtnValidaCPF.Location = new System.Drawing.Point(155, 4);
            this.BtnValidaCPF.Name = "BtnValidaCPF";
            this.BtnValidaCPF.Size = new System.Drawing.Size(80, 23);
            this.BtnValidaCPF.TabIndex = 1;
            this.BtnValidaCPF.Text = "Validar CPF";
            this.BtnValidaCPF.UseVisualStyleBackColor = true;
            this.BtnValidaCPF.Click += new System.EventHandler(this.BtnValidaCPF_Click);
            // 
            // TxtCPF
            // 
            this.TxtCPF.BackColor = System.Drawing.Color.White;
            this.TxtCPF.Location = new System.Drawing.Point(45, 6);
            this.TxtCPF.Mask = "000,000,000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(104, 20);
            this.TxtCPF.TabIndex = 0;
            this.TxtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCPF_KeyPress);
            this.TxtCPF.TextChanged += new System.EventHandler(this.TxtCPF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CNPJ";
            // 
            // TxtCNPJ
            // 
            this.TxtCNPJ.BackColor = System.Drawing.Color.White;
            this.TxtCNPJ.Location = new System.Drawing.Point(45, 32);
            this.TxtCNPJ.Mask = "00,000,000/0000-00";
            this.TxtCNPJ.Name = "TxtCNPJ";
            this.TxtCNPJ.Size = new System.Drawing.Size(104, 20);
            this.TxtCNPJ.TabIndex = 2;
            this.TxtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCNPJ_KeyPress);
            this.TxtCNPJ.TextChanged += new System.EventHandler(this.TxtCNPJ_TextChanged);
            // 
            // BtnValidaCNPJ
            // 
            this.BtnValidaCNPJ.Location = new System.Drawing.Point(155, 30);
            this.BtnValidaCNPJ.Name = "BtnValidaCNPJ";
            this.BtnValidaCNPJ.Size = new System.Drawing.Size(80, 23);
            this.BtnValidaCNPJ.TabIndex = 3;
            this.BtnValidaCNPJ.Text = "Validar CNPJ";
            this.BtnValidaCNPJ.UseVisualStyleBackColor = true;
            this.BtnValidaCNPJ.Click += new System.EventHandler(this.BtnValidaCNPJ_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 58);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCNPJ);
            this.Controls.Add(this.BtnValidaCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.BtnValidaCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar CPF/CNPJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValidaCPF;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtCNPJ;
        private System.Windows.Forms.Button BtnValidaCNPJ;

    }
}


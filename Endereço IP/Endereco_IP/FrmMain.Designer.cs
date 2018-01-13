namespace Endereco_IP
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
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLocalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.FdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.LblCidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(38, 12);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(90, 20);
            this.TxtIP.TabIndex = 0;
            this.TxtIP.Text = "0.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.Location = new System.Drawing.Point(134, 10);
            this.BtnLocalizar.Name = "BtnLocalizar";
            this.BtnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnLocalizar.TabIndex = 2;
            this.BtnLocalizar.Text = "Localizar";
            this.BtnLocalizar.UseVisualStyleBackColor = true;
            this.BtnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "País:";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.Location = new System.Drawing.Point(75, 44);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(14, 15);
            this.LblPais.TabIndex = 4;
            this.LblPais.Text = "?";
            // 
            // FdArquivo
            // 
            this.FdArquivo.Filter = "CSV (*.csv)|*.csv|Todos os Arquivos (*.*)|*.*";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.Location = new System.Drawing.Point(75, 61);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(14, 15);
            this.LblCidade.TabIndex = 8;
            this.LblCidade.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cidade:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 82);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLocalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço pelo IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLocalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.OpenFileDialog FdArquivo;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label label6;
    }
}


namespace Teste_socket_Cliente
{
    partial class FrmCliente
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
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.PnlTela = new System.Windows.Forms.Panel();
            this.TxtConsole = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(0, 38);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(153, 23);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(35, 12);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(102, 20);
            this.TxtIP.TabIndex = 1;
            this.TxtIP.Text = "127.0.0.1:7777";
            // 
            // PnlTela
            // 
            this.PnlTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlTela.Location = new System.Drawing.Point(1, 115);
            this.PnlTela.Name = "PnlTela";
            this.PnlTela.Size = new System.Drawing.Size(151, 151);
            this.PnlTela.TabIndex = 2;
            this.PnlTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTela_MouseMove);
            // 
            // TxtConsole
            // 
            this.TxtConsole.BackColor = System.Drawing.Color.Black;
            this.TxtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConsole.Dock = System.Windows.Forms.DockStyle.Right;
            this.TxtConsole.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TxtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtConsole.Location = new System.Drawing.Point(153, 0);
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ReadOnly = true;
            this.TxtConsole.Size = new System.Drawing.Size(475, 267);
            this.TxtConsole.TabIndex = 3;
            this.TxtConsole.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtConsole);
            this.Controls.Add(this.PnlTela);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.BtnConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Panel PnlTela;
        private System.Windows.Forms.RichTextBox TxtConsole;
        private System.Windows.Forms.Label label1;
    }
}


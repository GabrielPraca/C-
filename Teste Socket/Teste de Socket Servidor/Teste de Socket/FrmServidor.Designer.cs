namespace Teste_de_Socket
{
    partial class FrmServidor
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
            this.BtnTestar = new System.Windows.Forms.Button();
            this.TxtConsole = new System.Windows.Forms.RichTextBox();
            this.LblPorta = new System.Windows.Forms.Label();
            this.TxtPorta = new System.Windows.Forms.TextBox();
            this.BtnLigar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTestar
            // 
            this.BtnTestar.Location = new System.Drawing.Point(0, 54);
            this.BtnTestar.Name = "BtnTestar";
            this.BtnTestar.Size = new System.Drawing.Size(153, 23);
            this.BtnTestar.TabIndex = 0;
            this.BtnTestar.Text = "Testar";
            this.BtnTestar.UseVisualStyleBackColor = true;
            this.BtnTestar.Click += new System.EventHandler(this.BtnTestar_Click);
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
            this.TxtConsole.TabIndex = 1;
            this.TxtConsole.Text = "";
            // 
            // LblPorta
            // 
            this.LblPorta.AutoSize = true;
            this.LblPorta.Location = new System.Drawing.Point(9, 9);
            this.LblPorta.Name = "LblPorta";
            this.LblPorta.Size = new System.Drawing.Size(32, 13);
            this.LblPorta.TabIndex = 2;
            this.LblPorta.Text = "Porta";
            // 
            // TxtPorta
            // 
            this.TxtPorta.Location = new System.Drawing.Point(47, 6);
            this.TxtPorta.Name = "TxtPorta";
            this.TxtPorta.Size = new System.Drawing.Size(100, 20);
            this.TxtPorta.TabIndex = 3;
            this.TxtPorta.Text = "7777";
            // 
            // BtnLigar
            // 
            this.BtnLigar.Location = new System.Drawing.Point(0, 32);
            this.BtnLigar.Name = "BtnLigar";
            this.BtnLigar.Size = new System.Drawing.Size(153, 23);
            this.BtnLigar.TabIndex = 4;
            this.BtnLigar.Text = "Colocar Online";
            this.BtnLigar.UseVisualStyleBackColor = true;
            this.BtnLigar.Click += new System.EventHandler(this.BtnLigar_Click);
            // 
            // FrmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 267);
            this.Controls.Add(this.BtnLigar);
            this.Controls.Add(this.TxtPorta);
            this.Controls.Add(this.LblPorta);
            this.Controls.Add(this.TxtConsole);
            this.Controls.Add(this.BtnTestar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmServidor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTestar;
        private System.Windows.Forms.RichTextBox TxtConsole;
        private System.Windows.Forms.Label LblPorta;
        private System.Windows.Forms.TextBox TxtPorta;
        private System.Windows.Forms.Button BtnLigar;
    }
}


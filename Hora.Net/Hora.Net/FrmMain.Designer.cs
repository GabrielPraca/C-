namespace Hora.Net
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
            this.LblServidor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblServidor
            // 
            this.LblServidor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblServidor.AutoEllipsis = true;
            this.LblServidor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServidor.ForeColor = System.Drawing.Color.White;
            this.LblServidor.Location = new System.Drawing.Point(12, 15);
            this.LblServidor.Name = "LblServidor";
            this.LblServidor.Size = new System.Drawing.Size(376, 14);
            this.LblServidor.TabIndex = 1;
            this.LblServidor.Text = "Status";
            this.LblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(400, 44);
            this.Controls.Add(this.LblServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horário da Internet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblServidor;

    }
}


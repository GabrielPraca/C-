namespace Carro
{
    partial class FrmCarro
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
            this.components = new System.ComponentModel.Container();
            this.TimControle = new System.Windows.Forms.Timer(this.components);
            this.TimFPS = new System.Windows.Forms.Timer(this.components);
            this.LblFPS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimControle
            // 
            this.TimControle.Interval = 10;
            this.TimControle.Tick += new System.EventHandler(this.TimControle_Tick);
            // 
            // TimFPS
            // 
            this.TimFPS.Interval = 1000;
            this.TimFPS.Tick += new System.EventHandler(this.TimFPS_Tick);
            // 
            // LblFPS
            // 
            this.LblFPS.AutoSize = true;
            this.LblFPS.BackColor = System.Drawing.Color.Transparent;
            this.LblFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFPS.ForeColor = System.Drawing.Color.White;
            this.LblFPS.Location = new System.Drawing.Point(12, 9);
            this.LblFPS.Name = "LblFPS";
            this.LblFPS.Size = new System.Drawing.Size(56, 17);
            this.LblFPS.TabIndex = 0;
            this.LblFPS.Text = "FPS: 0";
            // 
            // FrmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(653, 279);
            this.Controls.Add(this.LblFPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarro";
            this.Text = "Carro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimControle;
        private System.Windows.Forms.Timer TimFPS;
        private System.Windows.Forms.Label LblFPS;
    }
}


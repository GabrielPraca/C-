namespace Traduza
{
    partial class FrmFim
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
            this.LblGanhador = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGanhador
            // 
            this.LblGanhador.AutoSize = true;
            this.LblGanhador.Location = new System.Drawing.Point(112, 80);
            this.LblGanhador.Name = "LblGanhador";
            this.LblGanhador.Size = new System.Drawing.Size(69, 13);
            this.LblGanhador.TabIndex = 0;
            this.LblGanhador.Text = "GANHADOR";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(56, 49);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(180, 31);
            this.LblInfo.TabIndex = 1;
            this.LblInfo.Text = "GANHADOR";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(106, 108);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Recomeçar";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 143);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblGanhador);
            this.Name = "FrmFim";
            this.Text = "FrmFim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGanhador;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnReset;
    }
}
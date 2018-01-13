namespace Teste_de_Thread
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
            this.PgbStatus = new System.Windows.Forms.ProgressBar();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PgbStatus
            // 
            this.PgbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PgbStatus.Location = new System.Drawing.Point(0, 0);
            this.PgbStatus.Name = "PgbStatus";
            this.PgbStatus.Size = new System.Drawing.Size(344, 30);
            this.PgbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgbStatus.TabIndex = 0;
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCopiar.Location = new System.Drawing.Point(0, 30);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(344, 36);
            this.BtnCopiar.TabIndex = 1;
            this.BtnCopiar.Text = "Gerar";
            this.BtnCopiar.UseVisualStyleBackColor = true;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 66);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.PgbStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Escrita";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PgbStatus;
        private System.Windows.Forms.Button BtnCopiar;
    }
}


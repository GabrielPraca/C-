namespace Teste_Thread
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
            this.PnlGraf = new System.Windows.Forms.Panel();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.BtnOrgBubble = new System.Windows.Forms.Button();
            this.BtnOrgSelec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PnlGraf
            // 
            this.PnlGraf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlGraf.BackColor = System.Drawing.Color.Black;
            this.PnlGraf.Location = new System.Drawing.Point(0, 41);
            this.PnlGraf.Name = "PnlGraf";
            this.PnlGraf.Size = new System.Drawing.Size(994, 258);
            this.PnlGraf.TabIndex = 0;
            this.PnlGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGraf_Paint);
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(12, 12);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGerar.TabIndex = 1;
            this.BtnGerar.Text = "Bagunçar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // BtnOrgBubble
            // 
            this.BtnOrgBubble.Location = new System.Drawing.Point(93, 12);
            this.BtnOrgBubble.Name = "BtnOrgBubble";
            this.BtnOrgBubble.Size = new System.Drawing.Size(145, 23);
            this.BtnOrgBubble.TabIndex = 2;
            this.BtnOrgBubble.Text = "Organizar (Bubble Sort)";
            this.BtnOrgBubble.UseVisualStyleBackColor = true;
            this.BtnOrgBubble.Click += new System.EventHandler(this.BtnOrgBubble_Click);
            // 
            // BtnOrgSelec
            // 
            this.BtnOrgSelec.Location = new System.Drawing.Point(244, 12);
            this.BtnOrgSelec.Name = "BtnOrgSelec";
            this.BtnOrgSelec.Size = new System.Drawing.Size(145, 23);
            this.BtnOrgSelec.TabIndex = 3;
            this.BtnOrgSelec.Text = "Organizar (Selection Sort)";
            this.BtnOrgSelec.UseVisualStyleBackColor = true;
            this.BtnOrgSelec.Click += new System.EventHandler(this.BtnOrgSelec_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 299);
            this.Controls.Add(this.BtnOrgSelec);
            this.Controls.Add(this.BtnOrgBubble);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.PnlGraf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Thread";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGraf;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button BtnOrgBubble;
        private System.Windows.Forms.Button BtnOrgSelec;
    }
}


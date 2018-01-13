namespace Variavel_estatica
{
    partial class FrmSegundo
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
            this.LblNome = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LblData = new System.Windows.Forms.Label();
            this.LblCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(71, 17);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(25, 40);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(126, 13);
            this.LblData.TabIndex = 1;
            this.LblData.Text = "dd/mm/aaaa MM:HH:SS";
            // 
            // LblCont
            // 
            this.LblCont.AutoSize = true;
            this.LblCont.Location = new System.Drawing.Point(71, 63);
            this.LblCont.Name = "LblCont";
            this.LblCont.Size = new System.Drawing.Size(29, 13);
            this.LblCont.TabIndex = 2;
            this.LblCont.Text = "Cont";
            // 
            // FrmSegundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 92);
            this.Controls.Add(this.LblCont);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSegundo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário 2";
            this.Load += new System.EventHandler(this.FrmSegundo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblCont;
    }
}
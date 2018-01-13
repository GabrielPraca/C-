namespace ProjetoEscolar
{
    partial class FrmRelatProf
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
            this.CRVProf = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVProf
            // 
            this.CRVProf.ActiveViewIndex = -1;
            this.CRVProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVProf.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVProf.Location = new System.Drawing.Point(0, 0);
            this.CRVProf.Name = "CRVProf";
            this.CRVProf.Size = new System.Drawing.Size(663, 428);
            this.CRVProf.TabIndex = 0;
            this.CRVProf.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmRelatProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 428);
            this.Controls.Add(this.CRVProf);
            this.Name = "FrmRelatProf";
            this.Text = "FrmRelatProf";
            this.Load += new System.EventHandler(this.FrmRelatProf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVProf;
    }
}
namespace Atividade
{
    partial class FrmRelatorioConsulta
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
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(53, 3);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(100, 20);
            this.TxtBusca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Location = new System.Drawing.Point(0, 25);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.SelectionFormula = "";
            this.CRViewer.Size = new System.Drawing.Size(861, 413);
            this.CRViewer.TabIndex = 2;
            this.CRViewer.ViewTimeSelectionFormula = "";
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(159, 1);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGerar.TabIndex = 3;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // FrmRelatorioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 438);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.CRViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBusca);
            this.Name = "FrmRelatorioConsulta";
            this.Text = "FrmRelatorioConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private System.Windows.Forms.Button BtnGerar;
    }
}
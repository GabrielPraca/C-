namespace Projeto_Graficos
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
            this.components = new System.ComponentModel.Container();
            this.PnlGrafico = new System.Windows.Forms.Panel();
            this.TimMovimento = new System.Windows.Forms.Timer(this.components);
            this.btnGerar = new System.Windows.Forms.Button();
            this.LblOffset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PnlGrafico
            // 
            this.PnlGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlGrafico.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.PnlGrafico.Location = new System.Drawing.Point(0, 0);
            this.PnlGrafico.Name = "PnlGrafico";
            this.PnlGrafico.Size = new System.Drawing.Size(622, 157);
            this.PnlGrafico.TabIndex = 0;
            this.PnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGrafico_Paint);
            this.PnlGrafico.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlGrafico_MouseMove);
            // 
            // TimMovimento
            // 
            this.TimMovimento.Enabled = true;
            this.TimMovimento.Interval = 10;
            this.TimMovimento.Tick += new System.EventHandler(this.TimMovimento_Tick);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(274, 163);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // LblOffset
            // 
            this.LblOffset.AutoSize = true;
            this.LblOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOffset.ForeColor = System.Drawing.Color.White;
            this.LblOffset.Location = new System.Drawing.Point(12, 168);
            this.LblOffset.Name = "LblOffset";
            this.LblOffset.Size = new System.Drawing.Size(69, 13);
            this.LblOffset.TabIndex = 2;
            this.LblOffset.Text = "OFFSET: 0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(622, 190);
            this.Controls.Add(this.LblOffset);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.PnlGrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGrafico;
        private System.Windows.Forms.Timer TimMovimento;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label LblOffset;
    }
}


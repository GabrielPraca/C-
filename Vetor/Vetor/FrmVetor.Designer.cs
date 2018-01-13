namespace Vetor
{
    partial class FrmVetor
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
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.BtnMostra = new System.Windows.Forms.Button();
            this.LstMostrar = new System.Windows.Forms.ListBox();
            this.CbMostrar = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TimAnim = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Location = new System.Drawing.Point(12, 58);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(75, 23);
            this.BtnCarregar.TabIndex = 0;
            this.BtnCarregar.Text = "&Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = true;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // BtnMostra
            // 
            this.BtnMostra.Location = new System.Drawing.Point(12, 87);
            this.BtnMostra.Name = "BtnMostra";
            this.BtnMostra.Size = new System.Drawing.Size(75, 23);
            this.BtnMostra.TabIndex = 1;
            this.BtnMostra.Text = "&Mostrar";
            this.BtnMostra.UseVisualStyleBackColor = true;
            this.BtnMostra.Click += new System.EventHandler(this.BtnMostra_Click);
            // 
            // LstMostrar
            // 
            this.LstMostrar.FormattingEnabled = true;
            this.LstMostrar.Location = new System.Drawing.Point(133, 14);
            this.LstMostrar.Name = "LstMostrar";
            this.LstMostrar.Size = new System.Drawing.Size(120, 95);
            this.LstMostrar.TabIndex = 2;
            // 
            // CbMostrar
            // 
            this.CbMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMostrar.FormattingEnabled = true;
            this.CbMostrar.Location = new System.Drawing.Point(133, 109);
            this.CbMostrar.Name = "CbMostrar";
            this.CbMostrar.Size = new System.Drawing.Size(120, 21);
            this.CbMostrar.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(12, 12);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 4;
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // TimAnim
            // 
            this.TimAnim.Interval = 10;
            this.TimAnim.Tick += new System.EventHandler(this.TimAnim_Tick);
            // 
            // FrmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 145);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.CbMostrar);
            this.Controls.Add(this.LstMostrar);
            this.Controls.Add(this.BtnMostra);
            this.Controls.Add(this.BtnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmVetor";
            this.Text = "Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Button BtnMostra;
        private System.Windows.Forms.ListBox LstMostrar;
        private System.Windows.Forms.ComboBox CbMostrar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Timer TimAnim;
    }
}


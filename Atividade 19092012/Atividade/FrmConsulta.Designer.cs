namespace Atividade
{
    partial class FrmConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.DgvSaida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(204, 6);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(150, 20);
            this.TxtBusca.TabIndex = 1;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // CmbCampo
            // 
            this.CmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCampo.FormattingEnabled = true;
            this.CmbCampo.Items.AddRange(new object[] {
            "Nome",
            "Bairro"});
            this.CmbCampo.Location = new System.Drawing.Point(77, 6);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(121, 21);
            this.CmbCampo.TabIndex = 0;
            // 
            // DgvSaida
            // 
            this.DgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaida.Location = new System.Drawing.Point(12, 33);
            this.DgvSaida.Name = "DgvSaida";
            this.DgvSaida.Size = new System.Drawing.Size(516, 221);
            this.DgvSaida.TabIndex = 3;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 266);
            this.Controls.Add(this.DgvSaida);
            this.Controls.Add(this.CmbCampo);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.ComboBox CmbCampo;
        private System.Windows.Forms.DataGridView DgvSaida;
    }
}
namespace Projeto_Exercicio
{
    partial class FrmSelecao
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
            this.DgvItens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvItens
            // 
            this.DgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvItens.Location = new System.Drawing.Point(0, 0);
            this.DgvItens.Name = "DgvItens";
            this.DgvItens.ReadOnly = true;
            this.DgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItens.Size = new System.Drawing.Size(417, 306);
            this.DgvItens.TabIndex = 0;
            this.DgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellDoubleClick);
            // 
            // FrmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 306);
            this.Controls.Add(this.DgvItens);
            this.Name = "FrmSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione";
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvItens;
    }
}
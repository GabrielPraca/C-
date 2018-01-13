namespace Horario_Aula
{
    partial class FrmEtapa1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalvarContinuar = new Horario_Aula.ButtonMain();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Horário:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(162, 30);
            this.TxtNome.MaxLength = 30;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(220, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(388, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ex: Manhã - PEB I";
            // 
            // BtnSalvarContinuar
            // 
            this.BtnSalvarContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvarContinuar.BackgroundImage = global::Horario_Aula.Properties.Resources.Salvar_Continuar;
            this.BtnSalvarContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarContinuar.Location = new System.Drawing.Point(423, 200);
            this.BtnSalvarContinuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvarContinuar.Name = "BtnSalvarContinuar";
            this.BtnSalvarContinuar.Size = new System.Drawing.Size(150, 64);
            this.BtnSalvarContinuar.TabIndex = 3;
            this.BtnSalvarContinuar.Text = "Salvar e continuar";
            this.BtnSalvarContinuar.Click += new System.EventHandler(this.BtnSalvarContinuar_Click);
            // 
            // FrmEtapa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnSalvarContinuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmEtapa1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 5, 5);
            this.Size = new System.Drawing.Size(582, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private ButtonMain BtnSalvarContinuar;


    }
}

namespace Horario_Aula
{
    partial class FrmEtapa2
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
            this.BtnSalvarContinuar = new Horario_Aula.ButtonMain();
            this.SuspendLayout();
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
            // FrmEtapa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnSalvarContinuar);
            this.Name = "FrmEtapa2";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 5, 5);
            this.Size = new System.Drawing.Size(582, 274);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonMain BtnSalvarContinuar;


    }
}

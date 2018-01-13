namespace CalcClass
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
            this.RdbSoma = new System.Windows.Forms.RadioButton();
            this.RdbSubtrair = new System.Windows.Forms.RadioButton();
            this.RdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.RdbDividir = new System.Windows.Forms.RadioButton();
            this.TxtVal1 = new System.Windows.Forms.TextBox();
            this.TxtVal2 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RdbSoma
            // 
            this.RdbSoma.AutoSize = true;
            this.RdbSoma.Checked = true;
            this.RdbSoma.Location = new System.Drawing.Point(12, 12);
            this.RdbSoma.Name = "RdbSoma";
            this.RdbSoma.Size = new System.Drawing.Size(55, 17);
            this.RdbSoma.TabIndex = 0;
            this.RdbSoma.TabStop = true;
            this.RdbSoma.Text = "Somar";
            this.RdbSoma.UseVisualStyleBackColor = true;
            // 
            // RdbSubtrair
            // 
            this.RdbSubtrair.AutoSize = true;
            this.RdbSubtrair.Location = new System.Drawing.Point(12, 35);
            this.RdbSubtrair.Name = "RdbSubtrair";
            this.RdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.RdbSubtrair.TabIndex = 1;
            this.RdbSubtrair.Text = "Subtrair";
            this.RdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // RdbMultiplicar
            // 
            this.RdbMultiplicar.AutoSize = true;
            this.RdbMultiplicar.Location = new System.Drawing.Point(12, 58);
            this.RdbMultiplicar.Name = "RdbMultiplicar";
            this.RdbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.RdbMultiplicar.TabIndex = 2;
            this.RdbMultiplicar.Text = "Multiplicar";
            this.RdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // RdbDividir
            // 
            this.RdbDividir.AutoSize = true;
            this.RdbDividir.Location = new System.Drawing.Point(12, 81);
            this.RdbDividir.Name = "RdbDividir";
            this.RdbDividir.Size = new System.Drawing.Size(54, 17);
            this.RdbDividir.TabIndex = 3;
            this.RdbDividir.Text = "Dividir";
            this.RdbDividir.UseVisualStyleBackColor = true;
            // 
            // TxtVal1
            // 
            this.TxtVal1.Location = new System.Drawing.Point(137, 11);
            this.TxtVal1.Name = "TxtVal1";
            this.TxtVal1.Size = new System.Drawing.Size(100, 20);
            this.TxtVal1.TabIndex = 4;
            // 
            // TxtVal2
            // 
            this.TxtVal2.Location = new System.Drawing.Point(137, 37);
            this.TxtVal2.Name = "TxtVal2";
            this.TxtVal2.Size = new System.Drawing.Size(100, 20);
            this.TxtVal2.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(150, 63);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "&Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(12, 106);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(61, 13);
            this.LblResult.TabIndex = 7;
            this.LblResult.Text = "Resultado: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 128);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtVal2);
            this.Controls.Add(this.TxtVal1);
            this.Controls.Add(this.RdbDividir);
            this.Controls.Add(this.RdbMultiplicar);
            this.Controls.Add(this.RdbSubtrair);
            this.Controls.Add(this.RdbSoma);
            this.Name = "FrmMain";
            this.Text = "Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbSoma;
        private System.Windows.Forms.RadioButton RdbSubtrair;
        private System.Windows.Forms.RadioButton RdbMultiplicar;
        private System.Windows.Forms.RadioButton RdbDividir;
        private System.Windows.Forms.TextBox TxtVal1;
        private System.Windows.Forms.TextBox TxtVal2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblResult;

    }
}


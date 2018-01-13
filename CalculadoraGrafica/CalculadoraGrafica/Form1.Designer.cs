namespace CalculadoraGrafica
{
    partial class Form1
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
            this.LblV1 = new System.Windows.Forms.Label();
            this.LblV2 = new System.Windows.Forms.Label();
            this.TxtV2 = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnCalcula = new System.Windows.Forms.Button();
            this.RdbSoma = new System.Windows.Forms.RadioButton();
            this.RdbSub = new System.Windows.Forms.RadioButton();
            this.RdbMult = new System.Windows.Forms.RadioButton();
            this.RdbDiv = new System.Windows.Forms.RadioButton();
            this.RdbRaiz = new System.Windows.Forms.RadioButton();
            this.RdbExpo = new System.Windows.Forms.RadioButton();
            this.TxtV1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblV1
            // 
            this.LblV1.AutoSize = true;
            this.LblV1.Location = new System.Drawing.Point(12, 9);
            this.LblV1.Name = "LblV1";
            this.LblV1.Size = new System.Drawing.Size(40, 13);
            this.LblV1.TabIndex = 9;
            this.LblV1.Text = "Valor 1";
            // 
            // LblV2
            // 
            this.LblV2.AutoSize = true;
            this.LblV2.Location = new System.Drawing.Point(12, 31);
            this.LblV2.Name = "LblV2";
            this.LblV2.Size = new System.Drawing.Size(40, 13);
            this.LblV2.TabIndex = 10;
            this.LblV2.Text = "Valor 2";
            // 
            // TxtV2
            // 
            this.TxtV2.Location = new System.Drawing.Point(53, 28);
            this.TxtV2.Name = "TxtV2";
            this.TxtV2.Size = new System.Drawing.Size(100, 20);
            this.TxtV2.TabIndex = 1;
            this.TxtV2.TextChanged += new System.EventHandler(this.TxtV2_TextChanged);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(61, 63);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(58, 13);
            this.LblRes.TabIndex = 11;
            this.LblRes.Text = "Resultado:";
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.Location = new System.Drawing.Point(64, 90);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcula.TabIndex = 8;
            this.BtnCalcula.Text = "&Calcular";
            this.BtnCalcula.UseVisualStyleBackColor = true;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // RdbSoma
            // 
            this.RdbSoma.AutoSize = true;
            this.RdbSoma.Location = new System.Drawing.Point(180, 13);
            this.RdbSoma.Name = "RdbSoma";
            this.RdbSoma.Size = new System.Drawing.Size(52, 17);
            this.RdbSoma.TabIndex = 2;
            this.RdbSoma.TabStop = true;
            this.RdbSoma.Text = "Soma";
            this.RdbSoma.UseVisualStyleBackColor = true;
            this.RdbSoma.CheckedChanged += new System.EventHandler(this.RdbSoma_CheckedChanged);
            // 
            // RdbSub
            // 
            this.RdbSub.AutoSize = true;
            this.RdbSub.Location = new System.Drawing.Point(180, 36);
            this.RdbSub.Name = "RdbSub";
            this.RdbSub.Size = new System.Drawing.Size(74, 17);
            this.RdbSub.TabIndex = 3;
            this.RdbSub.TabStop = true;
            this.RdbSub.Text = "Subtração";
            this.RdbSub.UseVisualStyleBackColor = true;
            this.RdbSub.CheckedChanged += new System.EventHandler(this.RdbSub_CheckedChanged);
            // 
            // RdbMult
            // 
            this.RdbMult.AutoSize = true;
            this.RdbMult.Location = new System.Drawing.Point(180, 59);
            this.RdbMult.Name = "RdbMult";
            this.RdbMult.Size = new System.Drawing.Size(87, 17);
            this.RdbMult.TabIndex = 4;
            this.RdbMult.TabStop = true;
            this.RdbMult.Text = "Multiplicação";
            this.RdbMult.UseVisualStyleBackColor = true;
            this.RdbMult.CheckedChanged += new System.EventHandler(this.RdbMult_CheckedChanged);
            // 
            // RdbDiv
            // 
            this.RdbDiv.AutoSize = true;
            this.RdbDiv.Location = new System.Drawing.Point(180, 82);
            this.RdbDiv.Name = "RdbDiv";
            this.RdbDiv.Size = new System.Drawing.Size(60, 17);
            this.RdbDiv.TabIndex = 5;
            this.RdbDiv.TabStop = true;
            this.RdbDiv.Text = "Divisão";
            this.RdbDiv.UseVisualStyleBackColor = true;
            this.RdbDiv.CheckedChanged += new System.EventHandler(this.RdbDiv_CheckedChanged);
            // 
            // RdbRaiz
            // 
            this.RdbRaiz.AutoSize = true;
            this.RdbRaiz.Location = new System.Drawing.Point(180, 105);
            this.RdbRaiz.Name = "RdbRaiz";
            this.RdbRaiz.Size = new System.Drawing.Size(46, 17);
            this.RdbRaiz.TabIndex = 6;
            this.RdbRaiz.TabStop = true;
            this.RdbRaiz.Text = "Raiz";
            this.RdbRaiz.UseVisualStyleBackColor = true;
            this.RdbRaiz.CheckedChanged += new System.EventHandler(this.RdbRaiz_CheckedChanged);
            // 
            // RdbExpo
            // 
            this.RdbExpo.AutoSize = true;
            this.RdbExpo.Location = new System.Drawing.Point(180, 128);
            this.RdbExpo.Name = "RdbExpo";
            this.RdbExpo.Size = new System.Drawing.Size(99, 17);
            this.RdbExpo.TabIndex = 7;
            this.RdbExpo.TabStop = true;
            this.RdbExpo.Text = "Exponenciação";
            this.RdbExpo.UseVisualStyleBackColor = true;
            this.RdbExpo.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // TxtV1
            // 
            this.TxtV1.Location = new System.Drawing.Point(53, 6);
            this.TxtV1.Name = "TxtV1";
            this.TxtV1.Size = new System.Drawing.Size(100, 20);
            this.TxtV1.TabIndex = 0;
            this.TxtV1.TextChanged += new System.EventHandler(this.TxtV1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 158);
            this.Controls.Add(this.TxtV1);
            this.Controls.Add(this.RdbExpo);
            this.Controls.Add(this.RdbRaiz);
            this.Controls.Add(this.RdbDiv);
            this.Controls.Add(this.RdbMult);
            this.Controls.Add(this.RdbSub);
            this.Controls.Add(this.RdbSoma);
            this.Controls.Add(this.BtnCalcula);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.TxtV2);
            this.Controls.Add(this.LblV2);
            this.Controls.Add(this.LblV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblV1;
        private System.Windows.Forms.Label LblV2;
        private System.Windows.Forms.TextBox TxtV2;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCalcula;
        private System.Windows.Forms.RadioButton RdbSoma;
        private System.Windows.Forms.RadioButton RdbSub;
        private System.Windows.Forms.RadioButton RdbMult;
        private System.Windows.Forms.RadioButton RdbDiv;
        private System.Windows.Forms.RadioButton RdbRaiz;
        private System.Windows.Forms.RadioButton RdbExpo;
        private System.Windows.Forms.TextBox TxtV1;
    }
}


namespace Menu
{
    partial class FrmVistaT1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaT1));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblTexto = new System.Windows.Forms.Label();
            this.TxtTextoUsu = new System.Windows.Forms.RichTextBox();
            this.LblLinha1 = new System.Windows.Forms.Label();
            this.LblLinha2 = new System.Windows.Forms.Label();
            this.LblLinha3 = new System.Windows.Forms.Label();
            this.LblLinha4 = new System.Windows.Forms.Label();
            this.LblLinha5 = new System.Windows.Forms.Label();
            this.BtnProx = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TimAtualizarTempo = new System.Windows.Forms.Timer(this.components);
            this.LblTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(124, 13);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(344, 55);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Teste de Vista";
            // 
            // LblTexto
            // 
            this.LblTexto.ForeColor = System.Drawing.Color.White;
            this.LblTexto.Location = new System.Drawing.Point(494, 12);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(140, 42);
            this.LblTexto.TabIndex = 1;
            this.LblTexto.Text = "Digite aqui as letras na ordem em que você enxergar:";
            // 
            // TxtTextoUsu
            // 
            this.TxtTextoUsu.BackColor = System.Drawing.Color.White;
            this.TxtTextoUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTextoUsu.Location = new System.Drawing.Point(497, 57);
            this.TxtTextoUsu.Name = "TxtTextoUsu";
            this.TxtTextoUsu.Size = new System.Drawing.Size(140, 276);
            this.TxtTextoUsu.TabIndex = 2;
            this.TxtTextoUsu.Text = "";
            this.TxtTextoUsu.TextChanged += new System.EventHandler(this.TxtTextoUsu_TextChanged);
            // 
            // LblLinha1
            // 
            this.LblLinha1.AutoSize = true;
            this.LblLinha1.BackColor = System.Drawing.Color.Transparent;
            this.LblLinha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinha1.ForeColor = System.Drawing.Color.White;
            this.LblLinha1.Location = new System.Drawing.Point(22, 68);
            this.LblLinha1.Name = "LblLinha1";
            this.LblLinha1.Size = new System.Drawing.Size(469, 108);
            this.LblLinha1.TabIndex = 3;
            this.LblLinha1.Text = "A A A A A";
            // 
            // LblLinha2
            // 
            this.LblLinha2.AutoSize = true;
            this.LblLinha2.BackColor = System.Drawing.Color.Transparent;
            this.LblLinha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinha2.ForeColor = System.Drawing.Color.White;
            this.LblLinha2.Location = new System.Drawing.Point(27, 176);
            this.LblLinha2.Name = "LblLinha2";
            this.LblLinha2.Size = new System.Drawing.Size(315, 73);
            this.LblLinha2.TabIndex = 4;
            this.LblLinha2.Text = "A A A A A";
            // 
            // LblLinha3
            // 
            this.LblLinha3.AutoSize = true;
            this.LblLinha3.BackColor = System.Drawing.Color.Transparent;
            this.LblLinha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinha3.ForeColor = System.Drawing.Color.White;
            this.LblLinha3.Location = new System.Drawing.Point(33, 249);
            this.LblLinha3.Name = "LblLinha3";
            this.LblLinha3.Size = new System.Drawing.Size(163, 37);
            this.LblLinha3.TabIndex = 5;
            this.LblLinha3.Text = "A A A A A";
            // 
            // LblLinha4
            // 
            this.LblLinha4.AutoSize = true;
            this.LblLinha4.BackColor = System.Drawing.Color.Transparent;
            this.LblLinha4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinha4.ForeColor = System.Drawing.Color.White;
            this.LblLinha4.Location = new System.Drawing.Point(37, 303);
            this.LblLinha4.Name = "LblLinha4";
            this.LblLinha4.Size = new System.Drawing.Size(69, 18);
            this.LblLinha4.TabIndex = 6;
            this.LblLinha4.Text = "A A A A A";
            // 
            // LblLinha5
            // 
            this.LblLinha5.AutoSize = true;
            this.LblLinha5.BackColor = System.Drawing.Color.Transparent;
            this.LblLinha5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinha5.ForeColor = System.Drawing.Color.White;
            this.LblLinha5.Location = new System.Drawing.Point(38, 342);
            this.LblLinha5.Name = "LblLinha5";
            this.LblLinha5.Size = new System.Drawing.Size(38, 9);
            this.LblLinha5.TabIndex = 7;
            this.LblLinha5.Text = "A A A A A";
            // 
            // BtnProx
            // 
            this.BtnProx.Location = new System.Drawing.Point(40, 12);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(75, 23);
            this.BtnProx.TabIndex = 8;
            this.BtnProx.Text = "&Próximo>>";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(12, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(23, 23);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TimAtualizarTempo
            // 
            this.TimAtualizarTempo.Tick += new System.EventHandler(this.TimAtualizarTempo_Tick);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.White;
            this.LblTempo.Location = new System.Drawing.Point(12, 44);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(133, 16);
            this.LblTempo.TabIndex = 10;
            this.LblTempo.Text = "Fim da Prova: 00:00";
            // 
            // FrmVistaT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(658, 360);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.LblLinha5);
            this.Controls.Add(this.LblLinha4);
            this.Controls.Add(this.LblLinha3);
            this.Controls.Add(this.LblLinha2);
            this.Controls.Add(this.LblLinha1);
            this.Controls.Add(this.TxtTextoUsu);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVistaT1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVistaT1_FormClosing);
            this.Load += new System.EventHandler(this.FrmVistaT1_Load);
            this.SizeChanged += new System.EventHandler(this.FrmVista_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.RichTextBox TxtTextoUsu;
        private System.Windows.Forms.Label LblLinha1;
        private System.Windows.Forms.Label LblLinha2;
        private System.Windows.Forms.Label LblLinha3;
        private System.Windows.Forms.Label LblLinha4;
        private System.Windows.Forms.Label LblLinha5;
        private System.Windows.Forms.Button BtnProx;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Timer TimAtualizarTempo;
        private System.Windows.Forms.Label LblTempo;
    }
}
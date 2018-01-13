namespace AppNet
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCep = new System.Windows.Forms.MaskedTextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            // 
            // TxtCep
            // 
            this.TxtCep.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCep.Location = new System.Drawing.Point(49, 6);
            this.TxtCep.Mask = "00000-000";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(61, 20);
            this.TxtCep.TabIndex = 1;
            this.TxtCep.TextChanged += new System.EventHandler(this.TxtCep_TextChanged);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(116, 9);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(96, 13);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "<- Complete o CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logradouro:";
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLogradouro.Location = new System.Drawing.Point(82, 44);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.ReadOnly = true;
            this.TxtLogradouro.Size = new System.Drawing.Size(350, 20);
            this.TxtLogradouro.TabIndex = 5;
            // 
            // TxtBairro
            // 
            this.TxtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBairro.Location = new System.Drawing.Point(82, 70);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.ReadOnly = true;
            this.TxtBairro.Size = new System.Drawing.Size(175, 20);
            this.TxtBairro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCidade.Location = new System.Drawing.Point(82, 96);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.ReadOnly = true;
            this.TxtCidade.Size = new System.Drawing.Size(175, 20);
            this.TxtCidade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cidade:";
            // 
            // TxtEstado
            // 
            this.TxtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.TxtEstado.Location = new System.Drawing.Point(82, 122);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.ReadOnly = true;
            this.TxtEstado.Size = new System.Drawing.Size(175, 20);
            this.TxtEstado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 154);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLogradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppNet.com CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtCep;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label5;
    }
}


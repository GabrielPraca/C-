namespace Horario_Aula
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
            this.BtnVerHorarios = new Horario_Aula.ButtonMain();
            this.BtnNovoHorario = new Horario_Aula.ButtonMain();
            this.SuspendLayout();
            // 
            // BtnVerHorarios
            // 
            this.BtnVerHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVerHorarios.BackgroundImage = global::Horario_Aula.Properties.Resources.HoraView;
            this.BtnVerHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerHorarios.ForeColor = System.Drawing.Color.Black;
            this.BtnVerHorarios.Location = new System.Drawing.Point(142, 0);
            this.BtnVerHorarios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnVerHorarios.Name = "BtnVerHorarios";
            this.BtnVerHorarios.Size = new System.Drawing.Size(140, 154);
            this.BtnVerHorarios.TabIndex = 5;
            this.BtnVerHorarios.Text = "Ver Horários";
            // 
            // BtnNovoHorario
            // 
            this.BtnNovoHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNovoHorario.BackgroundImage = global::Horario_Aula.Properties.Resources.New_File_icon;
            this.BtnNovoHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoHorario.ForeColor = System.Drawing.Color.Black;
            this.BtnNovoHorario.Location = new System.Drawing.Point(0, 0);
            this.BtnNovoHorario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnNovoHorario.Name = "BtnNovoHorario";
            this.BtnNovoHorario.Size = new System.Drawing.Size(140, 154);
            this.BtnNovoHorario.TabIndex = 4;
            this.BtnNovoHorario.Text = "Novo Horário";
            this.BtnNovoHorario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnNovoHorario_MouseClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(282, 154);
            this.Controls.Add(this.BtnVerHorarios);
            this.Controls.Add(this.BtnNovoHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horário Aula";
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonMain BtnNovoHorario;
        private ButtonMain BtnVerHorarios;
    }
}


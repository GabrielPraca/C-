namespace Quiz
{
    partial class FrmLoadScreen
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
            this.BarLoadStatus = new System.Windows.Forms.ProgressBar();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.ImgRaio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRaio)).BeginInit();
            this.SuspendLayout();
            // 
            // BarLoadStatus
            // 
            this.BarLoadStatus.Location = new System.Drawing.Point(47, 218);
            this.BarLoadStatus.Name = "BarLoadStatus";
            this.BarLoadStatus.Size = new System.Drawing.Size(522, 10);
            this.BarLoadStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarLoadStatus.TabIndex = 1;
            this.BarLoadStatus.Visible = false;
            // 
            // Tempo
            // 
            this.Tempo.Interval = 10;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // ImgRaio
            // 
            this.ImgRaio.BackColor = System.Drawing.Color.Transparent;
            this.ImgRaio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgRaio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgRaio.Image = global::Quiz.Properties.Resources.LoadRaio;
            this.ImgRaio.Location = new System.Drawing.Point(0, 0);
            this.ImgRaio.Name = "ImgRaio";
            this.ImgRaio.Size = new System.Drawing.Size(607, 240);
            this.ImgRaio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgRaio.TabIndex = 3;
            this.ImgRaio.TabStop = false;
            this.ImgRaio.Visible = false;
            // 
            // FrmLoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Quiz.Properties.Resources.LoadCerebro;
            this.ClientSize = new System.Drawing.Size(607, 240);
            this.Controls.Add(this.BarLoadStatus);
            this.Controls.Add(this.ImgRaio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoadScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FrmLoadScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgRaio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarLoadStatus;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.PictureBox ImgRaio;
    }
}


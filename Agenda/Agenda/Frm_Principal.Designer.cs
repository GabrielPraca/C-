namespace Agenda
{
    partial class Frm_principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telefonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indvidualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telefonesToolStripMenuItem
            // 
            this.telefonesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaisToolStripMenuItem});
            this.telefonesToolStripMenuItem.Name = "telefonesToolStripMenuItem";
            this.telefonesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.telefonesToolStripMenuItem.Text = "Telefones";
            // 
            // pessoaisToolStripMenuItem
            // 
            this.pessoaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalheToolStripMenuItem,
            this.indvidualToolStripMenuItem});
            this.pessoaisToolStripMenuItem.Name = "pessoaisToolStripMenuItem";
            this.pessoaisToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pessoaisToolStripMenuItem.Text = "Pessoais";
            // 
            // detalheToolStripMenuItem
            // 
            this.detalheToolStripMenuItem.Name = "detalheToolStripMenuItem";
            this.detalheToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detalheToolStripMenuItem.Text = "Detalhe";
            this.detalheToolStripMenuItem.Click += new System.EventHandler(this.detalheToolStripMenuItem_Click);
            // 
            // indvidualToolStripMenuItem
            // 
            this.indvidualToolStripMenuItem.Name = "indvidualToolStripMenuItem";
            this.indvidualToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indvidualToolStripMenuItem.Text = "Indvidual";
            this.indvidualToolStripMenuItem.Click += new System.EventHandler(this.indvidualToolStripMenuItem_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_principal";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telefonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indvidualToolStripMenuItem;

    }
}


namespace Agencia_Banco
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
            this.components = new System.ComponentModel.Container();
            this.bD_agenciaDataSet = new Agencia_Banco.BD_agenciaDataSet();
            this.tb_carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_carrosTableAdapter = new Agencia_Banco.BD_agenciaDataSetTableAdapters.tb_carrosTableAdapter();
            this.tableAdapterManager = new Agencia_Banco.BD_agenciaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bD_agenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_agenciaDataSet
            // 
            this.bD_agenciaDataSet.DataSetName = "BD_agenciaDataSet";
            this.bD_agenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_carrosBindingSource
            // 
            this.tb_carrosBindingSource.DataMember = "tb_carros";
            this.tb_carrosBindingSource.DataSource = this.bD_agenciaDataSet;
            // 
            // tb_carrosTableAdapter
            // 
            this.tb_carrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_carrosTableAdapter = this.tb_carrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agencia_Banco.BD_agenciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 258);
            this.Name = "FrmMain";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_agenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_carrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BD_agenciaDataSet bD_agenciaDataSet;
        private System.Windows.Forms.BindingSource tb_carrosBindingSource;
        private Agencia_Banco.BD_agenciaDataSetTableAdapters.tb_carrosTableAdapter tb_carrosTableAdapter;
        private Agencia_Banco.BD_agenciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}


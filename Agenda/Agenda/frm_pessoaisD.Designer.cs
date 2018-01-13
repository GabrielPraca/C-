namespace Agenda
{
    partial class frm_pessoaisd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pessoaisd));
            this.bdagendaDataSet = new Agenda.bdagendaDataSet();
            this.tb_pessoaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_pessoaisTableAdapter = new Agenda.bdagendaDataSetTableAdapters.tb_pessoaisTableAdapter();
            this.tableAdapterManager = new Agenda.bdagendaDataSetTableAdapters.TableAdapterManager();
            this.tb_pessoaisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_pessoaisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_pessoaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdagendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaisBindingNavigator)).BeginInit();
            this.tb_pessoaisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdagendaDataSet
            // 
            this.bdagendaDataSet.DataSetName = "bdagendaDataSet";
            this.bdagendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_pessoaisBindingSource
            // 
            this.tb_pessoaisBindingSource.DataMember = "tb_pessoais";
            this.tb_pessoaisBindingSource.DataSource = this.bdagendaDataSet;
            // 
            // tb_pessoaisTableAdapter
            // 
            this.tb_pessoaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_pessoaisTableAdapter = this.tb_pessoaisTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agenda.bdagendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_pessoaisBindingNavigator
            // 
            this.tb_pessoaisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_pessoaisBindingNavigator.BindingSource = this.tb_pessoaisBindingSource;
            this.tb_pessoaisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_pessoaisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_pessoaisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_pessoaisBindingNavigatorSaveItem});
            this.tb_pessoaisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_pessoaisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_pessoaisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_pessoaisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_pessoaisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_pessoaisBindingNavigator.Name = "tb_pessoaisBindingNavigator";
            this.tb_pessoaisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_pessoaisBindingNavigator.Size = new System.Drawing.Size(345, 25);
            this.tb_pessoaisBindingNavigator.TabIndex = 0;
            this.tb_pessoaisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tb_pessoaisBindingNavigatorSaveItem
            // 
            this.tb_pessoaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_pessoaisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_pessoaisBindingNavigatorSaveItem.Image")));
            this.tb_pessoaisBindingNavigatorSaveItem.Name = "tb_pessoaisBindingNavigatorSaveItem";
            this.tb_pessoaisBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tb_pessoaisBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_pessoaisBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_pessoaisBindingNavigatorSaveItem_Click);
            // 
            // tb_pessoaisDataGridView
            // 
            this.tb_pessoaisDataGridView.AutoGenerateColumns = false;
            this.tb_pessoaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_pessoaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tb_pessoaisDataGridView.DataSource = this.tb_pessoaisBindingSource;
            this.tb_pessoaisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pessoaisDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tb_pessoaisDataGridView.Name = "tb_pessoaisDataGridView";
            this.tb_pessoaisDataGridView.Size = new System.Drawing.Size(345, 260);
            this.tb_pessoaisDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frm_pessoaisd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 285);
            this.Controls.Add(this.tb_pessoaisDataGridView);
            this.Controls.Add(this.tb_pessoaisBindingNavigator);
            this.Name = "frm_pessoaisd";
            this.Text = "Pessoais Detalhe";
            this.Load += new System.EventHandler(this.frm_pessoaisd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdagendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaisBindingNavigator)).EndInit();
            this.tb_pessoaisBindingNavigator.ResumeLayout(false);
            this.tb_pessoaisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdagendaDataSet bdagendaDataSet;
        private System.Windows.Forms.BindingSource tb_pessoaisBindingSource;
        private Agenda.bdagendaDataSetTableAdapters.tb_pessoaisTableAdapter tb_pessoaisTableAdapter;
        private Agenda.bdagendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_pessoaisBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_pessoaisBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_pessoaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
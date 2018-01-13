using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agencia_Banco
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tb_carrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_carrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_agenciaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_agenciaDataSet.tb_carros' table. You can move, or remove it, as needed.
            this.tb_carrosTableAdapter.Fill(this.bD_agenciaDataSet.tb_carros);

        }
    }
}

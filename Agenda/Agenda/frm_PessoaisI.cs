using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_PessoaisI : Form
    {
        public frm_PessoaisI()
        {
            InitializeComponent();
        }

        private void tb_pessoaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_pessoaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdagendaDataSet);

        }

        private void frm_PessoaisI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdagendaDataSet.tb_pessoais' table. You can move, or remove it, as needed.
            this.tb_pessoaisTableAdapter.Fill(this.bdagendaDataSet.tb_pessoais);

        }
    }
}

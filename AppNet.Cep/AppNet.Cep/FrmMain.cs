using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppNet
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TxtCep_TextChanged(object sender, EventArgs e)
        {
            string CEP = TxtCep.Text.Replace("_", "").Replace("-", "");

            if (CEP.Length == 8)
            {
                Cep WebCep = new Cep();
                WebCep.GetEnderecoConcluido += new CepConcluidoEventHandler(GetEnderecoConcluido);
                WebCep.AsyncGetEndereco(CEP);

                /*
                DataTable DT = Cep.GetEndereco(CEP);

                if (DT != null && (bool)DT.Rows[0]["Resultado"])
                {
                    TxtLogradouro.Text = DT.Rows[0]["Endereco"].ToString();
                    TxtBairro.Text = DT.Rows[0]["Bairro"].ToString();
                    TxtCidade.Text = DT.Rows[0]["Cidade"].ToString();
                    TxtEstado.Text = DT.Rows[0]["EstadoDescricao"].ToString();
                }*/
            }
        }

        void GetEnderecoConcluido(DataTable DT)
        {
            if (DT != null && (bool)DT.Rows[0]["Resultado"])
            {
                TxtLogradouro.Text = DT.Rows[0]["Endereco"].ToString();
                TxtBairro.Text = DT.Rows[0]["Bairro"].ToString();
                TxtCidade.Text = DT.Rows[0]["Cidade"].ToString();
                TxtEstado.Text = DT.Rows[0]["EstadoDescricao"].ToString();
            }
        }
    }
}

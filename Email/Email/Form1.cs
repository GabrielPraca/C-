using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Email
{
    public partial class FrmEnvioDeEmail : Form
    {
        public FrmEnvioDeEmail()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string smtp = "";
            SmtpClient servico = new SmtpClient();
            if (ProcurarChars(TxtDe.Text.ToLower(), "@gmail.com"))
                smtp = "smtp.gmail.com";
            else if (ProcurarChars(TxtDe.Text.ToLower(), "@yahoo.com"))
                smtp = "smtp.mail.yahoo.com";
            else if (ProcurarChars(TxtDe.Text.ToLower(), "@hotmail.com") || ProcurarChars(TxtDe.Text.ToLower(), "@live.com"))
                smtp = "smtp.live.com";
            if (TxtDe.Text == null)
            {
                MessageBox.Show("Campo \"De\" vazio.");
                return;
            }
            if (TxtSenha.Text == null)
            {
                MessageBox.Show("Campo \"Senha\" vazio.");
                return;
            }
            if (TxtPara.Text == null)
            {
                MessageBox.Show("Campo \"Para\" vazio.");
                return;
            }
            if (TxtMensagem.Text == null)
            {
                MessageBox.Show("Escreva sua mensagem.");
                return;
            }
            servico.Host = smtp;
            servico.Port = 587;
            servico.Credentials = new NetworkCredential(TxtDe.Text, TxtSenha.Text);
            MailMessage mensagem = new MailMessage(TxtDe.Text, TxtPara.Text);//Adicionando remetende e Destinatário.
            mensagem.Subject = TxtAssunto.Text;//título da mensagem.
            mensagem.Body = TxtMensagem.Text;//corpo da mensagem.
            if (LkAnexo.Text != "Anexo") 
            {
                Attachment anexo = new Attachment(LkAnexo.Text);
                mensagem.Attachments.Add(anexo);
            }
            try
            {
                servico.Sen(mensagem);
                MessageBox.Show("Enviando email.");
            }
            catch { }
        }

        private bool ProcurarChars(string texto, string caracteres)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == caracteres[0])
                {
                    if (caracteres.Length == 1)
                        return true;
                    else
                    {
                        string comparar = "";
                        if (caracteres.Length >= texto.Length - i + 1)
                            return false;
                        for (int ii = 0; ii < caracteres.Length; ii++)
                            comparar += texto[ii + i];
                        if (comparar == caracteres)
                            return true;
                    }
                }
            }
            return false;
        }

        private void LkAnexo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OdgAnexo = new OpenFileDialog(); 
            if (OdgAnexo.ShowDialog() == DialogResult.OK)
                LkAnexo.Text = OdgAnexo.FileName;
        }
    }
}

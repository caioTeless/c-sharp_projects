using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nome.Text.Trim() == "")
                {
                    Error.Text = "Nome inválido";
                }
                else if (Email.Text.Trim() == "")
                {
                    Error.Text = "E-mail inválido";
                }
                else if (Mensagem.Text.Trim() == "")
                {
                    Error.Text = "Mensagem inválida";
                }
                else
                {
                    // Criando a mensagem
                    MailMessage mail = new MailMessage();
                    mail.IsBodyHtml = false;
                    mail.Subject = "Contato";
                    mail.To.Add("contato@seudominio.com.br");
                    MailAddress from = new MailAddress("contato@seudominio.com.br");
                    mail.From = from;
                    mail.Body = "\nMENSAGEM ENVIADA\n";
                    mail.Body = "Nome: " + Nome.Text + "\n";
                    mail.Body = "E-mail: " + Email.Text + "\n";
                    mail.Body = "Mensagem: " + Mensagem.Text + "\n";

                    // Enviando o email
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.@seudominio.com.br";
                    smtp.Port = 587;
                    smtp.EnableSsl = false;
                    smtp.Credentials = new NetworkCredential("contato@seudominio.com.br", "senha");
                    smtp.Send(mail);

                }
            }
            catch (Exception)
            {
                Error.Text = "Houve uma falha ao enviar o e-mail";
            }
        }
    }
}
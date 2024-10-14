using System.Net.Mail;

namespace SOLID.SRP.Solucao
{
    public static class EmailServices //static - �til para m�todos ou classes que executam tarefas globais, n�o dependem do est�do de um objeto, logo n precisa ser instanciada
    {
        public static void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            client.Send(mail);
        }
    }
}
using System.Net.Mail;

namespace SOLID.SRP.Solucao
{
    public static class EmailServices //static - útil para métodos ou classes que executam tarefas globais, não dependem do estádo de um objeto, logo n precisa ser instanciada
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
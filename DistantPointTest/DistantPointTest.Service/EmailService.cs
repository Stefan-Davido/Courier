using DistantPointTest.Service.Interfaces;
using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace DistantPointTest.Service
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Baller Scout", "ballerscoutmk@gmail.com"));
            message.To.Add(new MailboxAddress("Baller Scout Verification", email));
            message.Subject = $"Email in {DateTime.Now}";
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = string.Format($"<h3>Thank You For The Trust!</h3>")
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("ballerscoutmk@gmail.com", "MyPassword");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}

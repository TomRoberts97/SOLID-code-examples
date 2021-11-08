using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP.Passing
{
    public class EmailService
    {




        public void SendCustomerEmail(string customerEmail, string subject, string message)
        {
            Console.WriteLine($"**EMAIL SERVICE**");

            // HANDLE EMAIL SET UP
            //
            // emailMessage.From.Add(new MailboxAddress("Mark Adam", "madam@sample.com"));
            // emailMessage.To.Add(new MailboxAddress(string.Empty, email));
            // emailMessage.Subject = subject;
            // emailMessage.Body = new TextPart("plain") { Text = message };

            // using (SmtpClient smtpClient = new SmtpClient())
            // {
            //     smtpClient.LocalDomain = "sample.com";
            //     await smtpClient.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
            //     await smtpClient.SendAsync(emailMessage).ConfigureAwait(false);
            //     await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            // }
            //
            // END OF EMAIL SET UP


            Console.WriteLine($"Confirmation email sent to {customerEmail}");

            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP.Passing
{
    public class CustomerService
    {
        // This class now handles the functionality
        private readonly EmailService _emailService;
        public CustomerService(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegisterCustomer(CustomerNew customer)
        {
            Console.WriteLine($"**CUSTOMER SERVICE**");

            Console.WriteLine($"{customer.Name}, {customer.Address}, {customer.Age} saved to Database");
            Console.WriteLine($"{customer.Name} has been registered!");


            //SendCustomerEmail(customer.Email, "Beelivery Registration Complete!", $"Hi {customer.Name}, your account has successfully been registered." );
            _emailService.SendCustomerEmail(customer.Email, "Beelivery Registration Complete!", $"Hi {customer.Name}, your account has successfully been registered.");
        }


        private void SendCustomerEmail(string customerEmail, string subject, string message)
        {

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

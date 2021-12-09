using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.DIP.Failing
{
    public class Emailer : IMessagingService
    {
        public void SendMessage(ICustomer customer, string message)
        {
            Console.WriteLine($"Email send to {customer.Email}: {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.DIP.Failing
{
    public class Emailer
    {
        public void SendEmail(Customer customer, string message)
        {
            Console.WriteLine($"Email send to {customer.Email}: {message}");
        }
    }
}

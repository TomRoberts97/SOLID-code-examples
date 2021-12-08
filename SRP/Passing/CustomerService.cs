using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP.Passing
{
    public class CustomerService
    {
        private readonly EmailService _emailService;
        public CustomerService(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegisterCustomer(CustomerNew customer)   //Should this be here?
        {

            // HANDLE SENDING CUSTOMER DATA TO DATABASE 

            Console.WriteLine($"{customer.Name} saved to Database");
            Console.WriteLine("");

            Console.WriteLine($"{customer.Name} has been registered with Beelivery!");
            Console.WriteLine("");

            _emailService.SendEmail(customer.Email,"Header","Youve signed up to Beelivery!");

        }


    }
}

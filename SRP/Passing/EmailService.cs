using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP.Passing
{
    public class EmailService
    {


        public void SendEmail(string email, string header, string message)
        {

            //
            //
            //

            Console.WriteLine($"SEND EMAIL: {email} has recived email!");
            Console.WriteLine("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.OCP.Passing
{
    public class Kustomer : IBeeliveryUser
    {
        public void SignIn()
        {
            // Customer account sign in
            // Keeps Home page open

            Console.WriteLine($"Customer Signed In!");
            Console.WriteLine("");
        }
    }
}

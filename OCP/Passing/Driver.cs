using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.OCP.Passing
{
    public class Driver : IBeeliveryUser
    {
        public void SignIn()
        {
            // Driver account sign in 
            // Open Driver Landing page

            Console.WriteLine($"Driver Signed In!");
            Console.WriteLine($"Open Driver Landing Page");
            Console.WriteLine("");
        }
    }
}

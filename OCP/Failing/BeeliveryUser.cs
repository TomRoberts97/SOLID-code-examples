using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.OCP.Failing
{
    public class BeeliveryUser
    {

        public BeeliveryUser(string name, string accountType)
        {
            Name = name;
            AccountType = accountType;


            Console.WriteLine($"User: {Name}, {AccountType} created!");
            Console.WriteLine("");
        }


        public string Name { get; }

        public string AccountType { get; }

        public void SignIn() 
        {
            if(AccountType == "Customer")
            {
                // Customer account sign in
                // Keeps Home page open

                Console.WriteLine($"Customer Signed In!");
                Console.WriteLine("");
            }

            if(AccountType == "Driver")
            {
                // Driver account sign in 
                // Open Driver Landing page

                Console.WriteLine($"Driver Signed In!");
                Console.WriteLine($"Open Driver Landing Page");
                Console.WriteLine("");
            }
        }
    }
}

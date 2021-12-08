using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP
{
    public class Customer
    {
        public Customer(string name, string address, int age)
        {
            Name = name;
            Address = address;
            Age = age;

            Console.WriteLine($"Customer: {Name}, {Address}, {Age} created!");
            Console.WriteLine("");
        }

        public string Name { get; }
        public string Address { get; }
        public int Age { get; }


        public void RegisterCustomer()   //Should this be here?
        {

            // HANDLE SENDING CUSTOMER DATA TO DATABASE 

            Console.WriteLine($"{Name} saved to Database");
            Console.WriteLine("");

            Console.WriteLine($"{Name} has been registered with Beelivery!");
            Console.WriteLine("");

        }

    }
}

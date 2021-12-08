using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP.Passing
{
    public class CustomerNew
    {
        public CustomerNew(string name, string address, int age, string email)
        {
            Name = name;
            Address = address;
            Age = age;
            Email = email;

            Console.WriteLine($"Customer: {Name}, {Address}, {Age} created! Email; {Email}" );
            Console.WriteLine("");
        }

        public string Name { get; }
        public string Address { get; }
        public int Age { get; }
        public string Email { get; }

    }
}

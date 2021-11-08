using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.SRP.Passing
{
    public class CustomerNew
    {

        //This class is now just responsible for the models data

        public CustomerNew(string name, string address, int age, string email, string password)
        {
            Name = name;
            Address = address;
            Age = age;
            Email = email;
            Password = password;
        }

        public string Name { get; }
        public string Address { get; }
        public int Age { get; }
        public string Email { get; }
        public string Password { get; }


    }
}

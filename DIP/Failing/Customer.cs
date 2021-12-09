using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.DIP.Failing
{
    public class Customer : ICustomer
    {
        public Customer(string id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}

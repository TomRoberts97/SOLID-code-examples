using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.ISP.Failing
{
    public class Driver: IDriver
    {
        public Driver(string id, string name, string email, string driverId)
        {
            ID = id;
            Name = name;
            Email = email;
            DriverID = driverId;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string DriverID { get ; set; }

        public void AcceptOrder()
        {
            Console.WriteLine($"Driver {DriverID} accecpted an order!");

        }

        public void CompleteOrder()
        {
            Console.WriteLine($"Order complete! Confirmation sent to {Email}");
        }


        public void SignIn()
        {
            Console.WriteLine($"{Name} has signed IN!");
        }

        public void SignOut()
        {
            Console.WriteLine($"{Name} has signed OUT!");
        }
    }
}

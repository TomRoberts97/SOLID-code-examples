using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.ISP.Failing
{
    public class Driver: IUser
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
        public string AdminPermissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //driver CANNOT have Admin Permissions

        public void AcceptOrder()
        {
            Console.WriteLine($"Driver {DriverID} accecpted an order!");

        }

        public void CompleteOrder()
        {
            Console.WriteLine($"Order complete! Confirmation sent to {Email}");
        }

        public void DeleteAccount()
        {
            throw new NotImplementedException(); // ONLY for Admins
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

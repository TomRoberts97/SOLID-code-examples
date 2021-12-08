using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.ISP.Failing
{
    public class Customer : IUser
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
        public string DriverID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //Customer CANNOT have driver ID
        public string AdminPermissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //Customer CANNOT have Admin Permissions

        public void AcceptOrder()
        {
            throw new NotImplementedException(); //Customer CANNOT accept orders
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

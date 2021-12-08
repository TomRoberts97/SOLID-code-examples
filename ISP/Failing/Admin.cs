using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.ISP.Failing
{
    public class Admin: IUser
    {
        public Admin(string id, string email)
        {
            ID = id;
            Email = email;
        }
        public string ID { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get; set; }
        public string DriverID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AdminPermissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //driver CANNOT have Admin Permissions

        public void AcceptOrder()
        {
            throw new NotImplementedException(); //Admin cant make orders

        }

        public void CompleteOrder()
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount()
        {
            Console.WriteLine($"Admin {ID} has Deleted account!");
        }

        public void SignIn()
        {
            Console.WriteLine($"Admin {ID} has signed IN!");
        }

        public void SignOut()
        {
            Console.WriteLine($"Admin {ID} has signed OUT!");
        }
    }
}

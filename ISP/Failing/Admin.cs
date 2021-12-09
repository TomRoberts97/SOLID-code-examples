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
        public string Email { get; set; }
        public string AdminPermissions { get; set; } 

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

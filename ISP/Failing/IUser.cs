using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.ISP.Failing
{
    public interface IUser
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string DriverID { get; set; }
        string AdminPermissions { get; set; }
        void SignIn();
        void SignOut();
        void CompleteOrder();
        void AcceptOrder();
        void DeleteAccount();
    }
}

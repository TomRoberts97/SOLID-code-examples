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
        string Email { get; set; }
        void SignIn();
        void SignOut();
    }
}

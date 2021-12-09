using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.ISP.Failing
{
    public interface IDriver : ICustomer
    {
        string DriverID { get; set; }
        void AcceptOrder();
    }
}

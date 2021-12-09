using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.DIP.Failing
{
    public static class Factory
    {
        public static ICustomer CreateCustomer(string id, string name, string email)
        {
            return new Customer(id, name, email);
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessagingService CreateEmailer()
        {
            return new Emailer();
        }

        public static IOrder CreateOrder(string orderToken, ICustomer customer, List<string> productsList, decimal total, bool isComplete)
        {
            return new Order(orderToken,customer,productsList,total,isComplete, CreateLogger(), CreateEmailer());
        }

    }
}

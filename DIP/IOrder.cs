using SOLID_code_examples.DIP.Failing;
using System.Collections.Generic;

namespace SOLID_code_examples.DIP
{
    public interface IOrder
    {
        ICustomer Customer { get; set; }
        bool IsComplete { get; set; }
        string OrderToken { get; set; }
        List<string> ProductList { get; set; }
        decimal Total { get; set; }

        void AddProduct(string productName, decimal price);
        void CompleteOrder();
    }
}
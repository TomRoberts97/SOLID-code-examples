using SOLID_code_examples.DIP.Failing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.DIP
{
    public class Order
    {
        public string OrderToken { get; set; }
        public Customer Customer { get; set; }
        public List<string> ProductList { get; set; }
        public decimal Total { get; set; }
        public bool IsComplete { get; set; }

        public void AddProduct(string productName, decimal price)
        {
            ProductList.Add(productName);
            
            Total += price;

            Logger logger = new Logger();
            logger.Log($"{productName} added to the basket! {price} added to Total. Total: £{Total}");
        }

        public void CompleteOrder()
        {
            IsComplete = true;

            Logger logger = new Logger();
            logger.Log($"Order complete! Total: £{Total}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Customer, $"Order complete! Total: £{Total}");
        }
    }
}

using SOLID_code_examples.DIP.Failing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples.DIP
{
    public class Order : IOrder
    {
        private readonly ILogger _logger;
        private readonly IMessagingService _messagingService;

        public Order(string orderToken, ICustomer customer, List<string> productsList, decimal total, bool isComplete, ILogger logger, IMessagingService messaging)
        {
            OrderToken = orderToken;
            Customer = customer;
            ProductList = productsList;
            Total = total;
            IsComplete = isComplete;

            _logger = logger;
            _messagingService = messaging;
        }
        public string OrderToken { get; set; }
        public ICustomer Customer { get; set; }
        public List<string> ProductList { get; set; }
        public decimal Total { get; set; }
        public bool IsComplete { get; set; }

        public void AddProduct(string productName, decimal price)
        {
            ProductList.Add(productName);

            Total += price;
            
            
            _logger.Log($"{productName} added to the basket! {price} added to Total. Total: £{Total}");
        }

        public void CompleteOrder()
        {
            IsComplete = true;

            
            _logger.Log($"Order complete! Total: £{Total}");

            
            _messagingService.SendMessage(Customer, $"Order complete! Total: £{Total}");
        }
    }
}

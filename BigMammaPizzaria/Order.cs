using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class Order
    {
        private string _id;
        private DateTime _orderDateTime = DateTime.Now;
        private Customer _customer;
        private List<OrderItem> _orderItems;
        public Order(Customer customer, List<OrderItem> orderItems)
        {
            _customer = customer;
            _orderItems = orderItems;
            _id = generateID();
        }
        public DateTime OrderDateTime => _orderDateTime;

        public List<OrderItem> OrderItems => _orderItems;

        public string Id => _id;

        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        public double CalculateTotalPrice()
        {
            double orderPrice = 0;
            foreach (var item in _orderItems)
            {
                orderPrice += item.TotalItemPrice();
            }

            return orderPrice * (Constants.Tax + 1) + Constants.DeliveryCost;
        }

        public void Update(List<OrderItem> orderItems)
        {
            _orderItems = orderItems;
        }


        public override string ToString()
        {
            return 
                $"The order was made by {_customer.FirstName} {_customer.LastName}." +
                $"\n\tThe order contains: \n\t\t{string.Join("\n\t\t", _orderItems)}" +
                $"\n\t\tThe total price is {CalculateTotalPrice()} dkk\n";
        }
    }
}
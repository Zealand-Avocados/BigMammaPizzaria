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
            if (customer == null) throw new ArgumentNullException("customer", "Argument customer can't be null");
            _customer = customer;
            if (orderItems == null) _orderItems = new List<OrderItem>();
            else
            {
                orderItems.RemoveAll(orderItem => orderItem == null);
                _orderItems = orderItems;
            }
            _orderItems = orderItems;
            _id = Helpers.GenerateId();
        }
        public DateTime OrderDateTime => _orderDateTime;

        public List<OrderItem> OrderItems => _orderItems;

        public string Id => _id;

        
        public double CalculateTotalPrice()
        {
            double orderPrice = 0;
            foreach (var item in _orderItems) orderPrice += item.TotalItemPrice();
            return orderPrice * (Constants.Tax + 1) + Constants.DeliveryCost;
        }

        public void Update(List<OrderItem> orderItems)
        {
            if (orderItems == null) return;
            orderItems.RemoveAll(orderItem => orderItem == null);
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
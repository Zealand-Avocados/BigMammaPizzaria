using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class Order
    {
        private DateTime _orderDateTime = DateTime.Now;
        private Customer _customer;
        private List<OrderItem> _orderItems;

        public Order(Customer customer, List<OrderItem> orderItems)
        {
            _customer = customer;
            _orderItems = orderItems;
        }

        public DateTime OrderDateTime
        {
            get { return _orderDateTime; }
        }

        public List<OrderItem> OrderItems
        {
            get { return _orderItems; }
        }


        public double CalculateTotalPrice()
        {
            double orderPrice = 0;
            foreach (var item in _orderItems)
            {
                orderPrice += item.TotalItemPrice;
            }

            return orderPrice * (Constants.Tax + 1) + Constants.DeliveryCost;
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
using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class Order
    {
        private DateTime _orderDateTime;
        private Customer _customer;
        private List<MenuItem> _orderItems;


        public Order(Customer customer, List<MenuItem> orderItems)
        {
            _orderDateTime = DateTime.Now;
            _customer = customer;
            _orderItems = orderItems;
        }


        public DateTime OrderDateTime
        {
            get { return _orderDateTime; }
        }

        public List<MenuItem> OrderItems
        {
            get { return _orderItems; }
        }


        public double CalculateTotalPrice()
        {
            double orderPrice = 0;
            foreach (MenuItem item in _orderItems)
            {
                orderPrice += item.Price;
            }

            return orderPrice * (Constants.Tax + 1) + Constants.DeliveryCost;
        }


        public override string ToString()
        {
            return
                $"The order was made by {_customer.FirstName} {_customer.LastName}. The order contains: \n{string.Join("\n", _orderItems)} \n";
        }
    }
}
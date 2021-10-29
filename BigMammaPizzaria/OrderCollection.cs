using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class OrderCollection
    {
        private List<Order> _orderItems;


        public OrderCollection()
        {
            _orderItems = new List<Order>();
        }

        public List<Order> OrderItems
        {
            get { return _orderItems; }
        }

        public void Add(Order orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public void Remove(Order orderItem)
        {
            _orderItems.Remove(orderItem);
        }
    }
}
using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class OrderCatalog
    {
        private List<Order> _orders;

        public OrderCatalog()
        {
            _orders = new List<Order>();
        }
        
        public OrderCatalog(List<Order> order)
        {
            if (order == null) 
                _orders = new List<Order>();
            else 
            {
                order.RemoveAll(order => order == null);
                _orders = order;
            }
           
        }

        public List<Order> Orders => _orders;

        public void Add(Order order)
        {
            if (order == null) 
                return;

            _orders.Add(order); 
        }

        public void Remove(Order order)
        {
            _orders.Remove(order);
        }

        public void Update(string id, List<OrderItem> orderItem)
        {
            if (orderItem == null) 
                return;

            orderItem.RemoveAll(order => order == null);

            Order order = null;

            try
            {
                order = Search(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
             
            if (order != null)
                order.Update(orderItem); 
        }
        
        public Order Search(string id)
        {
            Order order = _orders.Find(order => order.Id == id);

            if (order == null)
                throw new ArgumentNullException("order does not exist");

            return order;
        }
        
        public void PrintOrders()
        {
            Helpers.PrintPaper("Orders", ToString());
        }
        
        public override string ToString()
        {
            string orders = "";
            int i = 0;

            foreach (var item in _orders)
            {
                orders += item + (i != _orders.Count - 1 ? "\n" : "");
                i++;
            }

            return orders;
        }
    }
}
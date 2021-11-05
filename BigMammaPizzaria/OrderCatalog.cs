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
            _orders = order;
        }


        public List<Order> Orders => _orders;


        public void Add(Order order)
        {
            _orders.Add(order); // TODO check for null
        }


        public void Remove(Order order)
        {
            _orders.Remove(order);
        }

        public void Update(string id, List<OrderItem> orderItem)
        {

            Search(id).Update(orderItem); // TODO check for null as well here

        }
        
        public void Delete(Order order)
        {
            _orders.Remove(order); // TODO
        }

        public Order Search(string id)
        {
            return _orders.Find(order => order.Id == id); // TODO Check for null and make case insensitive
        }
        
        public void PrintOrders()
        {
            Console.WriteLine("---------ORDERS--------");
            Console.WriteLine(ToString());
            Console.WriteLine("-----------------------");
        }
        
        public override string ToString()
        {
            string orders = "";
            foreach (var item in _orders)
            {
                orders += item + "\n";
            }
            return orders;
        }


    }
}
using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class CustomerCatalog
    {

        private List<Customer> _customers;


        public CustomerCatalog()
        {
            _customers = new List<Customer>();
        }
        
        public CustomerCatalog(List<Customer> customers)
        {
            _customers = customers;
        }


        public List<Customer> Customers => _customers;


        public void Add(Customer customer)
        {
            _customers.Add(customer); // TODO check for null
        }


        public void Remove(Customer customer)
        {
            _customers.Remove(customer);
        }

        public void Update(string firstName, string lastName, string newFirstName, string newLastName)
        {

            Search(firstName, lastName).Update(newFirstName, newLastName); // TODO check for null as well here

        }
        
        public void Delete(Customer customer)
        {
            _customers.Remove(customer); // TODO
        }

        public Customer Search(string fistName, string lastName)
        {
            return _customers.Find(customer => customer.FirstName == fistName && customer.LastName == lastName); // TODO Check for null and make case insensitive
        }
        
        
        public void PrintCustomers()
        {
            Console.WriteLine("-------CUSTOMERS-------");
            Console.WriteLine(ToString());
            Console.WriteLine("-----------------------");
        }
        
        public override string ToString()
        {
            string customers = "";
            foreach (var item in _customers)
            {
                customers += item + "\n";
            }
            return customers;
        }






    }
}
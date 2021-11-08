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
            if (customers == null) _customers = new List<Customer>();
            else 
            {
                customers.RemoveAll(customer => customer == null);
                _customers = customers;
            }
        }


        public List<Customer> Customers => _customers;


        public void Add(Customer customer)
        {
            if (customer == null) return;
            _customers.Add(customer); 
        }


        public void Remove(Customer customer)
        {
            _customers.Remove(customer);
        }

        public void Update(string firstName, string lastName, string newFirstName, string newLastName)
        {

            Search(firstName, lastName).Update(newFirstName, newLastName); // We checked there is no way to have null customer in the list, so we don't have to check for null

        }
        

        public Customer Search(string fistName, string lastName)
        {
            return _customers.Find(customer => customer.FirstName == fistName && customer.LastName == lastName);
        }
        
        
        public void PrintCustomers()
        {
            Helpers.PrintPaper("customers", ToString());
        }
        
        public override string ToString()
        {
            string customers = "";
            foreach (var item in _customers) customers += item + "\n";
            return customers;
        }






    }
}
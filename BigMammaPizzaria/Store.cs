using System;
using System.Collections.Generic;
using System.Linq;

namespace BigMammaPizzaria
{
    public class Store
    {
        private List<Order> _orders = new List<Order>();

        public List<Customer> _customers = new List<Customer>
        {
            new Customer("Adam", "Cipkala", new Address("Slovakia", "Kosice", "Lunik 9", 23423)),
            new Customer("Patrik", "Hoferica", new Address("Slovakia", "Zilina", "Kosicka", 23413)),
            new Customer("Pawel", "Dziagwa", new Address("Poland", "Krakow", "Lownicka", 32432))
        };

        public List<MenuItem> _menu = new List<MenuItem>
        {
            new Pizza("Margarita", 78, new List<Ingredient>{Ingredient.Tomato, Ingredient.Cheese}),
            new Pizza("Proscutio", 45, new List<Ingredient>{Ingredient.Tomato, Ingredient.Cheese}, new List<Topping>{Topping.Ketchup}),
            new Pizza("Hawai", 66, new List<Ingredient>{Ingredient.Tomato, Ingredient.Pineapple}, new List<Topping>{Topping.Majonase}),
            new Drink("Coke", 20, 300),
            new Drink("Coffee Latte", 40, 150),
            new Drink("Water", 10, 500)
        };

        public void Start()
        {

            foreach (var item in _menu)
            {
                Console.WriteLine("The " + item.Name + " costs " + item.Price + " dkk.");
            }
            
            Console.WriteLine();

            List<OrderItem> orderItems = new List<OrderItem>();

            #region customer1

            var myPizza = GetPizza("Proscutio");
            if (myPizza == null)
            {
                Console.WriteLine("Pizza does not exist");
            }
            else
            {
                orderItems.Add(new OrderItem(2, myPizza));
            }

            myPizza.AddTopping(Topping.Majonase);


            var myDrink = GetDrink("Coke");
            if (myDrink == null)
            {
                Console.WriteLine("Drink does not exist");
            }
            else
            {
                orderItems.Add(new OrderItem(3, myDrink));
            }

            var customer1 = GetCustomer("Adam", "Cipkala");
            if (customer1 == null)
            {
                Console.WriteLine("Customer does not exist");
            }
            else
            {
                _orders.Add(new Order(customer1, new List<OrderItem>(orderItems)));
            }

            orderItems.Clear();
            #endregion

            #region customer2

            var myPizza2 = GetPizza("Hawai");
            if (myPizza2 == null)
            {
                Console.WriteLine("Pizza does not exist");
            }
            else
            {
                orderItems.Add(new OrderItem(1, myPizza2));
            }

            myPizza2.AddTopping(Topping.Majonase);


            var myDrink2 = GetDrink("Coffee Latte");
            if (myDrink2 == null)
            {
                Console.WriteLine("Drink does not exist");
            }
            else
            {
                orderItems.Add(new OrderItem(5, myDrink2));
            }

            var customer2 = GetCustomer("Patrik", "Hoferica");
            if (customer2 == null)
            {
                Console.WriteLine("Customer does not exist");
            }
            else
            {
                _orders.Add(new Order(customer2, new List<OrderItem>(orderItems)));
            }

            orderItems.Clear();
            #endregion

            #region customer3

            var myPizza3 = GetPizza("Margarita");
            if (myPizza3 == null)
            {
                Console.WriteLine("Pizza does not exist");
            }
            else
            {
                orderItems.Add(new OrderItem(1, myPizza3));
            }

            var myDrink3 = GetDrink("Water");
            if (myDrink3 == null)
            {
                Console.WriteLine("Drink does not exist");
            }
            else
            {
                orderItems.Add(new OrderItem(5, myDrink3));
            }

            var customer3 = GetCustomer("Pawel", "Dziagwa");
            if (customer3 == null)
            {
                Console.WriteLine("Customer does not exist");
            }
            else
            {
                _orders.Add(new Order(customer3, new List<OrderItem>(orderItems)));
            }

            orderItems.Clear();
            #endregion

            foreach (Order item in _orders)
            {
                Console.WriteLine(item);
            }
        }

        private Customer GetCustomer(string sFirstName, string sLastName)
        {
            return _customers.FirstOrDefault(obj => obj.FirstName == sFirstName && obj.LastName == sLastName);
        }

        private MenuItem GetMenuItem(string sName)
        {
            return _menu.FirstOrDefault(obj => obj.Name == sName);
        }

        private Pizza GetPizza(string sName)
        {
            MenuItem m = GetMenuItem(sName);
            if (m == null)
                return null;

            return ((Pizza)m).Clone();

        }
        private Drink GetDrink(string sName)
        {
            MenuItem m = GetMenuItem(sName);
            if (m == null)
                return null;

            return ((Drink)m).Clone();
        }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace BigMammaPizzaria
{
    public class Store
    {
        private OrderCatalog _orderCatalog = new OrderCatalog();

        private CustomerCatalog _customerCatalog = new CustomerCatalog(new List<Customer>
        {
            new Customer("Adam", "Cipkala", new Address("Slovakia", "Kosice", "Lunik 9", 23423)),
            new Customer("Patrik", "Hoferica", new Address("Slovakia", "Zilina", "Kosicka", 23413)),
            new Customer("Pawel", "Dziagwa", new Address("Poland", "Krakow", "Lownicka", 32432))
        });


        private MenuCatalog _menuCatalog = new MenuCatalog(new List<MenuItem>
        {
            new Pizza("Margarita", 78, new List<Ingredient> {Ingredient.Tomato, Ingredient.Cheese}),
            new Pizza("Proscutio", 45, new List<Ingredient> {Ingredient.Tomato, Ingredient.Cheese},
                new List<Topping> {Topping.Ketchup}),
            new Pizza("Hawai", 66, new List<Ingredient> {Ingredient.Tomato, Ingredient.Pineapple},
                new List<Topping> {Topping.Majonase}),
            new Drink("Coke", 20, 300),
            new Drink("Coffee Latte", 40, 150),
            new Drink("Water", 10, 500)
        });


        public void Start()
        {
            _menuCatalog.PrintMenu();

            _menuCatalog.AddMenuItem(new Pizza("Pepperoni", 55,
                new List<Ingredient> {Ingredient.Tomato, Ingredient.Salami}));

            _menuCatalog.DeleteMenuItem("Hawai");

            _menuCatalog.UpdateMenuItem("Coke", "Coca Cola", 22);

            Console.WriteLine(_menuCatalog.Search("Margarita"));

            _menuCatalog.PrintMenu();

            /*
            #region customer1

            List<OrderItem> firstOrderItems = new List<OrderItem>();


            firstOrderItems.Add(new Order())
            
            var myPizza = GetPizza("Hawai");
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
            
            */
        }

        // TODO UserChoice

        private Customer GetCustomer(string firstName, string lastName)
        {
            return _customerCatalog.Search(firstName, lastName);
        }


        // TODO 
        private MenuItem GetMenuItem(string sName)
        {
            return _menuCatalog.Menu.FirstOrDefault(obj => obj.Name == sName);
        }

        // TODO
        private Pizza GetPizza(string sName)
        {
            MenuItem m = GetMenuItem(sName);
            if (m == null)
                return null;

            return ((Pizza) m).Clone();
        }

        // TODO
        private Drink GetDrink(string sName)
        {
            MenuItem m = GetMenuItem(sName);
            if (m == null)
                return null;

            return ((Drink) m).Clone();
        }
    }
}
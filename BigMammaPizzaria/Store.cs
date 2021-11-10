using System;
using System.Collections.Generic;
using System.Linq;

namespace BigMammaPizzaria
{
    public class Store
    {
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

        private OrderCatalog _orderCatalog;


        public void Start()
        {
            #region MenuCatalog
            _menuCatalog.PrintMenu();

            _menuCatalog.AddMenuItem(new Pizza("Pepperoni", 55,
                new List<Ingredient> {Ingredient.Tomato, Ingredient.Salami}));

            _menuCatalog.DeleteMenuItem("Hawai");

            _menuCatalog.UpdateMenuItem("Cokee", "Coca Cola", 22);
            
            Console.WriteLine(_menuCatalog.Search("Margarita") + "\n");

            _menuCatalog.PrintMenu();
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region CustomerCatalog

            _customerCatalog.PrintCustomers();

            _customerCatalog.Add(new Customer("David", "Zidan", new Address("Madagarskar", "Forest", "Cave", 23423)));

            _customerCatalog.Remove("Pawel", "Dziagwa");

            _customerCatalog.Update("Patrik", "Hoferica", "Matej", "Pekny");
           
            _customerCatalog.PrintCustomers();

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region OrderCatalog

            _orderCatalog = new OrderCatalog(new List<Order>
                {
                    new Order(
                       _customerCatalog.Search("Adam", "Cipkala"), 
                       new List<OrderItem>()
                       {
                            new OrderItem(2, GetPizza("Margarita")),
                            new OrderItem(1, GetDrink("Water"))
                       }
                    ),
                    new Order(
                        _customerCatalog.Search("David", "Zidan"),
                        new List<OrderItem>()
                        {
                            new OrderItem(1, GetPizza("Proscutio")),
                            new OrderItem(2, GetDrink("Coffee Latte"))
                        }
                    )
                });

            _orderCatalog.PrintOrders();

            _orderCatalog.Add(
                new Order(
                   _customerCatalog.Search("David", "Zidan"),
                   new List<OrderItem>()
                   {
                        new OrderItem(5, GetPizza("Margarita")),
                        new OrderItem(6, GetDrink("Water"))
                   }
                )
             );

            Pizza pizza1 = GetPizza("Proscutio");
            pizza1.AddTopping(Topping.Majonase);

            _orderCatalog.Update(_orderCatalog.Orders[0].Id,
                new List<OrderItem>()
                    {
                        new OrderItem(5, pizza1),
                        new OrderItem(6, GetDrink("Coffee Latte"))
                    }
             ); //TODO Id is too long

            _orderCatalog.PrintOrders();
            #endregion
        }

        private Pizza GetPizza(string sName)
        {
            MenuItem item = _menuCatalog.Search(sName);

            if (item == null)
                return null;

            return ((Pizza)item).Clone();
        }

        private Drink GetDrink(string sName)
        {
            MenuItem m = _menuCatalog.Search(sName);

            if (m == null)
                return null;

            return ((Drink)m).Clone();
        }
    }
}
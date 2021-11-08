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


        }


        // TODO
        private Pizza GetPizza(string sName)
        {
            MenuItem m = _menuCatalog.Search(sName);
            if (m == null)
                return null;

            return ((Pizza) m).Clone();
        }

        // TODO
        private Drink GetDrink(string sName)
        {
            MenuItem m = _menuCatalog.Search(sName);
            if (m == null)
                return null;

            return ((Drink) m).Clone();
        }
    }
}
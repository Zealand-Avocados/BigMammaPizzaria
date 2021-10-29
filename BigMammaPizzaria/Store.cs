using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class Store
    {

        private OrderCollection _orders;
        private MenuCollection _menu;
        
        public Store()
        {
            _orders = new OrderCollection();
            _menu = new MenuCollection();
        }



        public void Start()
        {
            
            
            Pizza p1 = new Pizza("Margarite", 78, new List<Ingredient>{Ingredient.Tomato, Ingredient.Cheese});
            Pizza p2 = new Pizza("Proscutio", 45, new List<Ingredient>{Ingredient.Tomato, Ingredient.Cheese}, new List<Topping>{Topping.Ketchup});
            Pizza p3 = new Pizza("Hawai", 66, new List<Ingredient>{Ingredient.Tomato, Ingredient.Pineapple}, new List<Topping>{Topping.Majonase});
            
            
            
            Drink d1 = new Drink("Coke", 20, 300);
            Drink d2 = new Drink("Coffee Latte", 40, 150);
            Drink d3 = new Drink("Water", 10, 500);
            
            
            _menu.Add(p1);
            _menu.Add(p2);
            _menu.Add(p3);


            Customer c1 = new Customer("Adam", "Cipkala", new Address("Slovakia", "Kosice", "Lunik 9", 23423));
            Customer c2 = new Customer("Patrik", "Hoferica", new Address("Slovakia", "Zilina", "Kosicka", 23413));
            Customer c3 = new Customer("Pawel", "Dziagwa", new Address("Poland", "Krakow", "Lownicka", 32432));
            
            
            // Display the menu
            Console.WriteLine(_menu);
            

            Console.WriteLine();
            Console.WriteLine();


            
            Order order1 = new Order(c1, new List<MenuItem> {p1, p3, d1});
            Order order2 = new Order(c2, new List<MenuItem> {p2});
            Order order3 = new Order(c3, new List<MenuItem> {p1, p2, p3, d1});


            Console.WriteLine(order1);
            Console.WriteLine(order1.CalculateTotalPrice());






        }








    }
}
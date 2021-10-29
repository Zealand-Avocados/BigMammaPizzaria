using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pizza p1 = new Pizza("Margarite", 78, new List<Ingredient>{Ingredient.Tomato, Ingredient.Cheese});
            Pizza p2 = new Pizza("Proscutio", 78, new List<Ingredient>{Ingredient.Tomato, Ingredient.Cheese}, new List<Topping>{Topping.Ketchup});

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            
        }
    }
}
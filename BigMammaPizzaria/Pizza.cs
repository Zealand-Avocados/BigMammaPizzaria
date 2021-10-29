using System;
using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public enum Ingredient
    {
        Tomato,
        Cheese,
        Garlic,
        Pineapple,
    }

    public enum Topping
    {
        Ketchup,
        Majonase,
    }


    public class Pizza : MenuItem
    {
        private List<Ingredient> _ingredients;
        private List<Topping> _toppings;
        private int _extraToppings = 0;

        public Pizza(string name, double price, List<Ingredient> ingredients) : base(name, price)
        {
            _ingredients = ingredients;
            _toppings = new List<Topping>();
        }

        public Pizza(string name, double price, List<Ingredient> ingredients, List<Topping> toppings) : base(name,
            price)
        {
            _ingredients = ingredients;
            _toppings = toppings;
        }


        public void AddTopping(Topping topping)
        {
            _toppings.Add(topping);
            _price += Constants.ExtraToppingPrice;
            _extraToppings++;
        }

        public void RemoveToppings()
        {
            if (_extraToppings == 0) return;
            _price -= Constants.ExtraToppingPrice * _extraToppings;
            _toppings.RemoveRange(_toppings.Count - _extraToppings, _extraToppings);
            _extraToppings = 0;
        }


        public override string ToString()
        {
            return
                $"The pizza {Name}, it costs {Price} DKK, the ingredients are {string.Join(", ", _ingredients)} " +
                (_toppings.Count == 0 ? "" : "and the toppings are "  + string.Join(" ,", _toppings));
        }
    }
}
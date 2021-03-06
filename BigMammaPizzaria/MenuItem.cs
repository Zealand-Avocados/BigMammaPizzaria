    
using System;

namespace BigMammaPizzaria
{
    public class MenuItem
    {
        protected string _name;
        protected float _price;

        protected MenuItem(string name, float price)
        {
            if (price <= 0) 
                throw new ArgumentOutOfRangeException("price", "Price cannot be negative");

            _name = name;
            _price = price;
        }
        
        public string Name => _name;
        public float Price => _price;

        public void Update(string name, float price)
        {
            if (price <= 0) 
                throw new ArgumentOutOfRangeException("price", "Price cannot be negative");
            
            _name = name;
            _price = price;
        }

        public override string ToString()
        {
            return $"The menu item {_name} has price of {_price}.";
        }
    }
}
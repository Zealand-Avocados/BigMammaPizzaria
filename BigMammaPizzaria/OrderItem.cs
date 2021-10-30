using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaPizzaria
{
    public class OrderItem
    {
        private int _quantity;
        private MenuItem _menuItem;

        public OrderItem(int quantity, MenuItem menuItem)
        {
            _quantity = quantity;
            _menuItem = menuItem;
        }
        
        public int Quantity => _quantity;
        public MenuItem MenuItem => _menuItem;

        public float TotalItemPrice() => _quantity * _menuItem.Price;
        public override string ToString()
        {
            return $"{_quantity}x {_menuItem.Name} for total price of {TotalItemPrice()} dkk\n\t\t({_menuItem})";
        }
    }
}

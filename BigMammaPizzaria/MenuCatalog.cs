using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMammaPizzaria
{
    public class MenuCatalog
    {
        private List<MenuItem> _menu = new List<MenuItem>();

        public void AddMenuItem(MenuItem menuItem)
        {
            _menu.Add(menuItem);
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            _menu.Remove(menuItem);
        }

        public void UpdateMenuItem(string name, string newName, float price)
        {
            SearchItem(name).Update(newName, price);
        }

        public void PrintMenu()
        {
            Console.WriteLine("-------MENU-------");
            Console.WriteLine(ToString());
        }

        public MenuItem SearchItem(string name)
        {
            //_menu.Find();
            return null;
        }

        public override string ToString()
        {
            string menu = "";
            foreach (var item in _menu)
            {
                menu += item.ToString() + "\n";
            }
            return menu;
        }
    }
}

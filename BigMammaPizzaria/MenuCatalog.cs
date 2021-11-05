using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMammaPizzaria
{
    public class MenuCatalog
    {
        private List<MenuItem> _menu;



        public MenuCatalog()
        {
            _menu = new List<MenuItem>();
        }

        public MenuCatalog(List<MenuItem> items)
        {
            _menu = items;
        }

        public List<MenuItem> Menu => _menu;
        
        public void AddMenuItem(MenuItem menuItem)
        {
            _menu.Add(menuItem);
        }

        public void DeleteMenuItem(string menuItem)
        {
            _menu.Remove(Search(menuItem)); // TODO
        }

        public void UpdateMenuItem(string name, string newName, float price)
        {
            Search(name).Update(newName, price); // TODO
        }

        public void PrintMenu()
        {
            Console.WriteLine("-------MENU-------");
            Console.WriteLine(ToString());
            Console.WriteLine("------------------");
        }

        public MenuItem Search(string name)
        {
            return _menu.Find(item => item.Name == name); // TODO checks for empty list or null exceptions
        }

        public override string ToString()
        {
            string menu = "";
            foreach (var item in _menu)
            {
                menu += item + "\n";
            }
            return menu;
        }
    }
}

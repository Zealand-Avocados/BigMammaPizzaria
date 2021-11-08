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
            if (items == null) _menu = new List<MenuItem>();
            else
            {
                items.RemoveAll(customer => customer == null);
                _menu = items;
            }
        }

        public List<MenuItem> Menu => _menu;

        public void AddMenuItem(MenuItem menuItem)
        {
            if (menuItem == null) return;
            _menu.Add(menuItem);
        }

        public void DeleteMenuItem(string menuItem)
        {
            _menu.Remove(Search(menuItem));
        }

        public void UpdateMenuItem(string name, string newName, float price)
        {
            try
            {
                Search(name).Update(newName, price);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintMenu()
        {
            Helpers.PrintPaper("Menu", ToString());
        }

        public MenuItem Search(string name)
        {
            return _menu.Find(item => item.Name == name);
        }

        public override string ToString()
        {
            string menu = "";
            foreach (var item in _menu) menu += item + "\n";
            return menu;
        }
    }
}
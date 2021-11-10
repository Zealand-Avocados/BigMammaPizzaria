using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMammaPizzaria
{
    public class MenuCatalog
    {
        private List<MenuItem> _menu = new List<MenuItem>();


        public MenuCatalog(List<MenuItem> items = null)
        {
            if (items == null) 
                _menu = new List<MenuItem>();
            else
            {
                items.RemoveAll(customer => customer == null);
                _menu = items;
            }
        }

        public List<MenuItem> Menu => _menu;

        public void AddMenuItem(MenuItem menuItem)
        {
            if (menuItem == null) 
                return;

            _menu.Add(menuItem);
        }

        public void DeleteMenuItem(string menuItem)
        {
            try
            {
                _menu.Remove(Search(menuItem));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            MenuItem item = _menu.FirstOrDefault(obj => obj.Name == name);

            if (item == null)
                throw new ArgumentNullException("Menu Item doesnt exist");

            return item;
        }

        public override string ToString()
        {
            string menu = "";

            for (int i = 0; i < _menu.Count; ++i)
            {
                menu += _menu[i].ToString();

                if (i < _menu.Count - 1)
                    menu += "\n";
            }

            return menu;
        }
    }
}
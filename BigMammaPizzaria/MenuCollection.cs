using System.Collections.Generic;

namespace BigMammaPizzaria
{
    public class MenuCollection
    {
        private List<MenuItem> _menuItems;


        public MenuCollection()
        {
            _menuItems = new List<MenuItem>();
        }

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
        }

        public void Add(MenuItem menuItem)
        {
            _menuItems.Add(menuItem);
        }

        public void Remove(MenuItem menuItem)
        {
            _menuItems.Remove(menuItem);
        }


        public override string ToString()
        {
            return "Menu:\n" + string.Join(",\n", _menuItems);
        }
    }
}
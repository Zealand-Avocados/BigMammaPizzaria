namespace BigMammaPizzaria
{
    public class MenuItem
    {
        
        private string _name;
        protected double _price;


        protected MenuItem(string name, double price)
        {
            _name = name;
            _price = price;
        }
        

        public string Name => _name;
        public double Price => _price;



        public override string ToString()
        {
            return $"The menu item {_name} has price of {_price}.";
        }
        


    }
}
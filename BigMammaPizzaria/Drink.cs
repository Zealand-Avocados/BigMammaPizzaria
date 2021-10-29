namespace BigMammaPizzaria
{
    public class Drink : MenuItem
    {

        private int _volumeInMl;


        public Drink(string name, double price, int volumeInMl) : base(name, price)
        {
            _volumeInMl = volumeInMl;
        }


        

        public override string ToString()
        {
            return $"The drink called {Name}, it costs {Price} DKK and the volume is {_volumeInMl} ml";
        }
        


    }
}
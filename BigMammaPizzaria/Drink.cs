using System;

namespace BigMammaPizzaria
{
    public class Drink : MenuItem
    {
        private int _volumeInMl;

        public Drink(string name, float price, int volumeInMl) : base(name, price)
        {
            if (volumeInMl <= 0) throw new ArgumentOutOfRangeException("volumeInMl", "Volume can't be lower than zero");
            _volumeInMl = volumeInMl;
        }

        public int VolumeInMl => _volumeInMl;

        public Drink Clone() => (Drink)MemberwiseClone();
        
        public override string ToString()
        {
            return $"The {Name} has volume is {_volumeInMl} ml";
        }

       
    }
}
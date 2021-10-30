namespace BigMammaPizzaria
{
    public class Drink : MenuItem
    {
        private int _volumeInMl;

        public Drink(string name, float price, int volumeInMl) : base(name, price)
        {
            _volumeInMl = volumeInMl;
        }

        public int VolumeInMl => _volumeInMl;

        public Drink Clone() => (Drink)MemberwiseClone();
        
        public override string ToString()
        {
            return $"the volume is {_volumeInMl} ml";
        }
    }
}
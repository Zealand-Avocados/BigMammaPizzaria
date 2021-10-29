namespace BigMammaPizzaria
{
    public class Address
    {
        private string _country;
        private string _city;
        private string _street;
        private int _zip;

        public Address(string country, string city, string street, int zip)
        {
            _country = country;
            _city = city;
            _street = street;
            _zip = zip;
        }

        public string Country
        {
            get { return _country; }
        }
        
        public string City
        {
            get { return _city; }
        }
        
        public string Street
        {
            get { return _street; }
        }
        
        public int Zip
        {
            get { return _zip; }
        }
    }
}
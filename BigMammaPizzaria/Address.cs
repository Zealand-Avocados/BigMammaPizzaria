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

        public string Country => _country;

        public string City => _city;

        public string Street => _street;

        public int Zip => _zip;

        public override string ToString()
        {
            return $"{_city} {_street} {_zip} {_country}";
        }
    }
}
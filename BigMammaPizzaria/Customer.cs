namespace BigMammaPizzaria
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private Address _address;
        public Customer(string firstName, string lastName, Address address)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }
        public string FirstName => _firstName;

        public string LastName => _lastName;

        public Address Address => _address;

        public void Update(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"Customer name is: {_firstName} and last name is: {_lastName} and the address is {_address}";
        }
    }
}
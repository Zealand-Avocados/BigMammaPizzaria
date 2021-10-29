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

        public string FirstName
        {
            get { return _firstName; }
        }
        
        public string LastName
        {
            get { return _lastName; }
        }
        
        public Address Address {
            get { return _address;}
        }

        public override string ToString()
        {
            return $"Customer name is: {_firstName} and last name is: {_lastName} and the address is {_address}";
        }
    }
}
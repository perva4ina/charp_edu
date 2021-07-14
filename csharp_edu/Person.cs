namespace csharp_edu
{
    public class Person
    {
        private string _firstName;
        private string _larstName;

        //sting formatting with fields
        public string Name => $"{_firstName} {_larstName}";

        //auto property
        public string Phone { get; set; }
        
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _larstName = lastName;
            PersonCount++;
        }
        
        //read only static property
        public static int PersonCount { get; private set; }
    }
}
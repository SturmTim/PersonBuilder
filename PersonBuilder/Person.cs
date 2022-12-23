namespace PersonBuilder;

public class Person
{
    private string Firstname { get; init; }
    private string Lastname { get; init; }
    private int? Age { get; init; }
    private string? Phone { get; init; }
    private string? Address { get; init; }
    
    public Person(Builder builder)
    {
        Firstname = builder._firstname;
        Lastname = builder._lastname;
        Age = builder._age;
        Phone = builder._phone;
        Address = builder._address;
    }
    
public override string ToString()
    {
        return $"Firstname: {Firstname}, Lastname: {Lastname}, Age: {Age}, Phone: {Phone}, Address: {Address}";
    }
    
    
    public class Builder
    {
        internal string _firstname;
        internal string _lastname;
        internal int? _age;
        internal string? _address;
        internal string? _phone;

        public Builder(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }
        
        public Builder SetAge(int age)
        {
            _age = age;
            return this;
        }
        
        public Builder SetAddress(string address)
        {
            _address = address;
            return this;
        }
        
        public Builder SetPhone(string phone)
        {
            _phone = phone;
            return this;
        }
        
        public Person Build()
        {
            var person = new Person(this);
            if(person.Age > 115 || _firstname.Length < 3 || (_address.Split(' ')[0].Length == 5 && (_phone != null && _phone.Split(' ')[0].Length == 2))) 
                Console.WriteLine($"{person} is not allowed");
            return person;
        }
    }
}


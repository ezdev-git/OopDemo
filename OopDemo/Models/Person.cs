namespace OopDemo.Models
{
    public abstract class Person
    {
        public string Name { get; init; }
        public string Address { get; init; }
        public DateTime DateOfBirth { get; init; }
        public string SIN { get; }

        protected Person(string name, string address, DateTime dateOfBirth, string sin)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            DateOfBirth = dateOfBirth;
            SIN = sin ?? throw new ArgumentNullException(nameof(sin));
        }

        public abstract void DisplayDetails();
    }
}
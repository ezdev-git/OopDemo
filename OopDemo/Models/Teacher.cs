namespace OopDemo.Models
{
    public class Teacher : Person
    {
        public string TeacherId { get; init; }

        public Teacher(string name, string address, DateTime dateOfBirth, string sin, string teacherId)
            : base(name, address, dateOfBirth, sin)
        {
            TeacherId = teacherId ?? throw new ArgumentNullException(nameof(teacherId));
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"I’m a teacher and my Id is {TeacherId}. My address is {Address}");
        }
    }
}
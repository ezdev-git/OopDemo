namespace OopDemo.Models
{
    public class Student : Person
    {
        public string StudentId { get; init; }

        public Student(string name, string address, DateTime dateOfBirth, string sin, string studentId)
            : base(name, address, dateOfBirth, sin)
        {
            StudentId = studentId ?? throw new ArgumentNullException(nameof(studentId));
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"I’m a student and my Id is {StudentId}. My address is {Address}");
        }
    }
}
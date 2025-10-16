using OopDemo.Models;

namespace OopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Data.StudentsData();
            List<Teacher> teachers = Data.TeachersData();

            foreach (var student in students)
            {
                student.DisplayDetails();
            }

            foreach (var teacher in teachers)
            {
                teacher.DisplayDetails();
            }

            Console.ReadLine();
        }
    }
}

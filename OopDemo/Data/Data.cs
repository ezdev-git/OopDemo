using OopDemo.Models;

namespace OopDemo
{
    public static class Data
    {
        public static List<Student> StudentsData() => new List<Student>
        {
            new Student(
                name: "Alice Johnson",
                address: "123 Maple Street",
                dateOfBirth: new DateTime(2003, 4, 15),
                sin: "123456789",
                studentId: "S2025"
            ),
            new Student(
                name: "Bob Smith",
                address: "456 Pine Road",
                dateOfBirth: new DateTime(2002, 7, 22),
                sin: "234567890",
                studentId: "S2026"
            ),
        };

        public static List<Teacher> TeachersData() => new List<Teacher>
        {
            new Teacher(
                name: "Robert Smith",
                address: "456 Oak Avenue",
                dateOfBirth: new DateTime(1980, 8, 21),
                sin: "987654321",
                teacherId: "T1001"
            ),
            new Teacher(
                name: "Susan Clark",
                address: "789 Maple Blvd",
                dateOfBirth: new DateTime(1975, 3, 10),
                sin: "876543210",
                teacherId: "T1002"
            ),
        };
    }
}

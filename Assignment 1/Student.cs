using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNamespace;

namespace YourNamespace // Replace YourNamespace with your actual namespace
{
    public class Student
    {
        public int Id { get; set; }
        public StudentType Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
public static class StudentHelper
{
    public static Student CreateStudent(int id, StudentType type, string firstName, string lastName)
    {
        // Check for null parameters and set default values if needed
        if (id == null)
            id = 0;
        if (firstName == null)
            firstName = "Unknown";
        if (lastName == null)
            lastName = "";

        // Create and return a new Student object
        return new Student
        {
            Id = id,
            Type = type,
            FirstName = firstName,
            LastName = lastName
        };
    }
    public static void OutputStudent(Student student)
    {
        // Output the Student information
        Console.WriteLine($"Id: {student.Id}");
        Console.WriteLine($"Type: {student.Type}");
        Console.WriteLine($"First Name: {student.FirstName}");
        Console.WriteLine($"Last Name: {student.LastName}");
    }
}

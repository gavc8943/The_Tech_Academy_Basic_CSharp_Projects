using StudentDatabaseApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentDbContext())
        {
            context.Database.EnsureCreated();

            var student = new Student
            {
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added to the database.");
        }
    }
}


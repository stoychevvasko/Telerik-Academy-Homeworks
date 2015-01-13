/*

<Problem 03>

Write a method that from a given array of students 
finds all students whose first name is before its last 
name alphabetically. Use LINQ query operators.

*/

namespace _03.StudentsFirstBeforeLastName
{
    using System;
    using System.Linq;

    class StudentsFirstBeforeLastName
    {
        static void Main()
        {
            Console.Title = "03. StudentsFirstBeforeLastName";
            Console.SetWindowSize(60, 10);
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 10;

            Student student1 = new Student("Ivan", "Petrov", 18);
            Student student2 = new Student("Petyr", "Ivanov", 25);
            Student student3 = new Student("Georgi", "Petrov", 40);
            Student student4 = new Student("Petyr", "Georgiev", 60);

            Student[] studentArray = new Student[] { student1, student2, student3, student4 };

            var studentQuery =
                from student in studentArray
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            Console.WriteLine("List of students whose first name is before their last name alphabetically:");
            Console.WriteLine();
            
            foreach (Student item in studentQuery)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

/*

<Problem 04>

Write a LINQ query that finds the first name and last 
name of all students with age between 18 and 24.

*/

namespace _04.StudentsInAgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _03.StudentsFirstBeforeLastName;

    // added reference to <Problem 03>

    class StudentsInAgeRange
    {
        static void Main()
        {
            Console.Title = "04. StudentsInAgeRange";
            Console.SetWindowSize(40, 10);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 10;

            
            Student student1 = new Student("Ivan", "Petrov", 18);
            Student student2 = new Student("Petyr", "Ivanov", 25);
            Student student3 = new Student("Georgi", "Petrov", 19);
            Student student4 = new Student("Petyr", "Georgiev", 30);
            Student student5 = new Student("Lili", "Mimeva", 22);

            Student[] studentArray = new Student[] { student1, student2, student3, student4, student5 };

            var ageQuery =
                from student in studentArray
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("Students between age 18 and 24:");            
            Console.WriteLine();

            foreach (var item in ageQuery)
            {
                Console.WriteLine("{0} {1} - Age: {2}", item.FirstName, item.LastName, item.Age);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

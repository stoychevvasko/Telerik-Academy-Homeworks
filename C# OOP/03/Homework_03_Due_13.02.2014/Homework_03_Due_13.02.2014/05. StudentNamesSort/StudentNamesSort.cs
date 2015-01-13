/*

<Problem 05>

Using the extension methods OrderBy() and 
ThenBy() with lambda expressions sort the students 
by first name and last name in descending order. 
Rewrite the same with LINQ.

*/

namespace _05.StudentNamesSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _03.StudentsFirstBeforeLastName;

    // added reference to <Problem 03>

    class StudentNamesSort
    {
        static void Main()
        {
            Console.Title = "05.StudentNamesSort";
            Console.SetWindowSize(35, 20);
            Console.BufferWidth = Console.WindowWidth = 35;
            Console.BufferHeight = Console.WindowHeight = 20;


            Student student1 = new Student("Ivan", "Petrov", 18);
            Student student2 = new Student("Ivan", "Ivanov", 25);
            Student student3 = new Student("Georgi", "Georgiev", 19);
            Student student4 = new Student("Georgi", "Petrov", 30);
            Student student5 = new Student("Zanka", "Zancheva", 22);

            Student[] studentArray = new Student[] { student1, student2, student3, student4, student5 };
            
            // Lambda expression

            var studentsSortedLambda = studentArray.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            Console.WriteLine("Sorted via lambda expression:");
            Console.WriteLine();

            foreach (var item in studentsSortedLambda)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine();
            Console.WriteLine();

            // LINQ

            var studentsSortedLINQ =
                from student in studentArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("Sorted via LINQ query:");
            Console.WriteLine();

            foreach (var item in studentsSortedLINQ)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
                        

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

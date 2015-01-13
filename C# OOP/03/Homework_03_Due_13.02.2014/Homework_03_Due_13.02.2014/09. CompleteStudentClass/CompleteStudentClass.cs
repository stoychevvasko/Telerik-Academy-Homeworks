/*

<Problem 09>

Create a class student with properties FirstName, 
LastName, FN, Tel, Email, Marks (a List<int>),
GroupNumber. Create a List<Student> with 
sample students. Select only the students that are 
from group number 2. Use LINQ query. Order the 
students by FirstName.

*/

namespace _09.CompleteStudentClass
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class CompleteStudentClass
    {
        static void Main()
        {
            Console.Title = "09.CompleteStudentClass";
            Console.SetWindowSize(40, 10);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 10;


            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123456789", "0888 888 888", "joro@joromail.com", new List<int> { 2, 3, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123456790", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "0888 777 888", "Niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123456792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 2));
            sampleStudents.Add(new Student("Asya", "Asieva", "123456793", "0889 999 888", "asya@gmail.com", new List<int> { 6, 5, 6, 5, 5 }, 2));

            var linqQuery =
                from student in sampleStudents
                where student.GroupNumber == 2
                orderby student.FirstName ascending, student.LastName ascending
                select student;

            Console.WriteLine("Students from Group 2 are:");
            Console.WriteLine();

            foreach (var item in linqQuery)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

/*

<Problem 14>

Write down a similar program that extracts the 
students with exactly  two marks "2". Use extension 
methods.


*/

namespace _14.PoorStudents
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using _09.CompleteStudentClass;    

    // added reference to <Problem 09>

    class PoorStudents
    {
        static void Main()
        {
            Console.Title = "14.PoorStudents";
            Console.SetWindowSize(40, 10);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 10;


            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123456789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123456790", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "(02) 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123456792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 2));
            sampleStudents.Add(new Student("Asya", "Asieva", "123456793", "(02) 999 888", "asya@gmail.com", new List<int> { 5, 5, 5, 5, 5 }, 2));
            
            // Count() is a lambda expression extension method

            var studentsWithPoorMarks =
                from student in sampleStudents
                where student.Marks.Count(x => x == 2) == 2
                select student;

            Console.WriteLine("Students with at least two poor marks:");
            Console.WriteLine();

            foreach (var item in studentsWithPoorMarks)
            {
                Console.WriteLine("{0} {1} - marks {2}", item.FirstName, item.LastName, string.Join(" ", item.Marks));
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

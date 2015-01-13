/*

<Problem 12>

Extract all students with phones in Sofia. Use LINQ.

*/

namespace _12.StudentPhonesLINQ
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using _09.CompleteStudentClass;

    // added reference to <Problem 09>

    class StudentPhonesLINQ
    {
        static void Main()
        {
            Console.Title = "12.StudentPhonesLINQ";
            Console.SetWindowSize(40, 10);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 10;


            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123456789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123456790", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "(02) 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123456792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 2));
            sampleStudents.Add(new Student("Asya", "Asieva", "123456793", "(02) 999 888", "asya@gmail.com", new List<int> { 6, 5, 6, 5, 5 }, 2));

            var linqQuery =
                from student in sampleStudents
                where student.Tel.Substring(0,4).CompareTo("(02)") == 0
                orderby student.FirstName ascending, student.LastName ascending
                select student;

            Console.WriteLine("Students with Sofia phones are:");
            Console.WriteLine();

            foreach (var item in linqQuery)
            {
                Console.WriteLine("{0} {1} - tel. {2}", item.FirstName, item.LastName, item.Tel);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

/*

<Problem 11>

Extract all students that have email in abv.bg. Use 
string methods and LINQ.


*/

namespace _11.EmailInABV
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using _09.CompleteStudentClass;

    // added reference to <Problem 09>

    class EmailInABV
    {
        static void Main()
        {
            Console.Title = "11.EmailInABV";
            Console.SetWindowSize(40, 10);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 10;


            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123456789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123456790", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "0888 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123456792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 2));
            sampleStudents.Add(new Student("Asya", "Asieva", "123456793", "0889 999 888", "asya@gmail.com", new List<int> { 6, 5, 6, 5, 5 }, 2));

            var linqQuery =
                from student in sampleStudents
                where student.Email.Substring(student.Email.IndexOf('@') + 1) == "abv.bg"
                orderby student.FirstName ascending, student.LastName ascending
                select student;
            
            Console.WriteLine("Students with abv.bg emails are:");
            Console.WriteLine();

            foreach (var item in linqQuery)
            {
                Console.WriteLine("{0} {1} - {2}", item.FirstName, item.LastName, item.Email);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

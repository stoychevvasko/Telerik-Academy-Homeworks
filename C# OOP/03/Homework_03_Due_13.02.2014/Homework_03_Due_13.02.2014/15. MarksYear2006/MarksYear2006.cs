/*

<Problem 15>

Extract all Marks of the students that enrolled in 
2006. (The students from 2006 have 06 as their 5-th 
and 6-th digit in the FN).

*/

namespace _15.MarksYear2006
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using _09.CompleteStudentClass;

    // added reference to <Problem 09>

    class MarksYear2006
    {
        static void Main()
        {
            Console.Title = "15.MarksYear2006";
            Console.SetWindowSize(42, 10);
            Console.BufferWidth = Console.WindowWidth = 42;
            Console.BufferHeight = Console.WindowHeight = 10;


            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123406789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123450690", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "(02) 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123406792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 2));
            sampleStudents.Add(new Student("Asya", "Asieva", "123450693", "(02) 999 888", "asya@gmail.com", new List<int> { 5, 5, 5, 5, 5 }, 2));

            var studentsFrom2006 =
                from student in sampleStudents
                where student.FN.Substring(5, 2).CompareTo("06") == 0
                select new { FullName = student.FirstName + " " + student.LastName, FN = student.FN, Marks = student.Marks };

            Console.WriteLine("Students from 2006:");

            Console.WriteLine();

            foreach (var item in studentsFrom2006)
            {
                Console.WriteLine("{0} FN {1} Marks {2}", item.FullName, item.FN, string.Join(" ", item.Marks));
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

/*

<Problem 19>

Rewrite the previous using extension methods.

*/

namespace _19.StudentsByGroupNameLambda
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using _09.CompleteStudentClass;
    using _18.StudentsByGroupName;

    // added reference to <Problem 09>
    // added reference to <Problem 18>

    class StudentsByGroupNameLambda
    {
        static void Main()
        {
            Console.Title = "19.StudentsByGroupNameLambda";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;


            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123406789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 2));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123450690", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "(02) 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123406792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 1));
            sampleStudents.Add(new Student("Asya", "Asieva", "123450693", "(02) 999 888", "asya@gmail.com", new List<int> { 5, 5, 5, 5, 5 }, 2));

            List<Group> sampleGroups = new List<Group>();
            sampleGroups.Add(new Group(1, "Group 1"));
            sampleGroups.Add(new Group(2, "Group 2"));

            foreach (var gr in sampleGroups)
            {
                List<Student> currentGroupList = sampleStudents.FindAll(x => x.GroupNumber == gr.GroupNumber);

                Console.WriteLine(gr.GroupName);
                Console.WriteLine();

                foreach (var student in currentGroupList)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }

        }
    }
}

/*

<Problem 01>

We are given a school. In the school there are classes
of students. Each class has a set of teachers. Each 
teacher teaches a set of disciplines. Students have 
name and unique class number. Classes have unique
text identifier. Teachers have name. Disciplines have
name, number of lectures and number of exercises. 
Both teachers and students are people. Students, 
classes, teachers and disciplines could have optional 
comments (free text block).

Your task is to identify the classes (in terms of  OOP) 
and their attributes and operations, encapsulate 
their fields, define the class hierarchy and create a 
class diagram with Visual Studio.

*/

namespace _01.SchoolModel
{
    using System;
    using System.Collections.Generic;

    class SchoolModel
    {
        static void Main()
        {
            Console.Title = "01. SchoolModel";
            Console.SetWindowSize(40, 41);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 41;

            string line = new string('-', 39);

            Student testStudent = new Student("Ivan Ivanov", 1, "Some comment");
            System.Console.WriteLine(testStudent);
            System.Console.WriteLine(line);

            Student testStudent1 = new Student();

            Discipline testDiscipline = new Discipline("Math", 5, 6, "Math is a cool subject.");
            System.Console.WriteLine(testDiscipline);
            System.Console.WriteLine(line);

            Discipline testDiscipline2 = new Discipline("Physics", 3, 4, "http://youtu.be/-oV_B3BZLHE");

            Teacher testTeacher = new Teacher("Petyr Petrov", new HashSet<Discipline> { testDiscipline, testDiscipline2 }, "employment info");
            System.Console.WriteLine(testTeacher);
            System.Console.WriteLine(line);

            Teacher testTeacher2 = new Teacher("Mimi Mimeva", new HashSet<Discipline> { testDiscipline }, "more employment info");
            Console.WriteLine(testTeacher2);
            System.Console.WriteLine(line);

            testTeacher2.AddDiscipline(testDiscipline2);
            testTeacher2.RemoveDiscipline(testDiscipline);
            Console.WriteLine(testTeacher2);
            System.Console.WriteLine(line);

            SchoolClass class1 = new SchoolClass("Class I", new HashSet<Teacher> { testTeacher, testTeacher2 },
                new HashSet<Student> { testStudent, testStudent1 }, "this is a test class");
            Console.WriteLine(class1);
            System.Console.WriteLine(line);

            SchoolClass class2 = new SchoolClass("Class II", new HashSet<Teacher>(), new HashSet<Student>(), "another test class");

            School testSchool = new School("Test Highschool", new HashSet<SchoolClass> { class1, class2 });

            Console.WriteLine(testSchool);
            Console.WriteLine();
        }
    }
}

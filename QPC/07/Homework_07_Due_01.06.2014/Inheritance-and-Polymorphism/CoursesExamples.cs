// <copyright file="CoursesExamples.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    /// <summary>Demos for Task 04 of this homework - course object model.</summary>
    public class CoursesExamples
    {
        /// <summary>Program execution starts here.</summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev", new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}

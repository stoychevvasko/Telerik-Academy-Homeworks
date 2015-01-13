/*

<Problem 02>

Define abstract class Human with first name and last 
name. Define new class Student which is derived 
from Human and has new field – grade. Define class
Worker derived from Human with new property 
WeekSalary and WorkHoursPerDay and method 
MoneyPerHour() that returns money earned by 
hour by the worker. Define the proper constructors 
and properties for this hierarchy. Initialize a list of 10 
students and sort them by grade in ascending order 
(use LINQ or OrderBy() extension method). 
Initialize a list of 10 workers and sort them by money
per hour in descending order. Merge the lists and 
sort them by first name and last name.

*/

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;    
    using System.Text;
    using System.Linq;

    class StudentsAndWorkers
    {
        static void PrintLine()
        {
            string line = new string('-', 39);
            Console.WriteLine();
            Console.WriteLine(line);
            Console.WriteLine();
        }
        
        static void Main()
        {
            CultureInfo ci = new CultureInfo("bg-BG");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "02.StudentsAndWorkers";
            Console.SetWindowSize(40, 60);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 60;

            List<Human> finalList = new List<Human>();
            
            List<Student> studentList = new List<Student>
            {
                new Student("Петко", "Петков ", 6f),
                new Student("Жоро ", "Жоров  ", 5.56f),
                new Student("Васко", "Васков ", 3.2f),
                new Student("Коко ", "Кокинов", 2f),
                new Student("Мими", " Мимева ", 3.5f),
                new Student("Лили ", "Лилиева", 4.44f),
                new Student("Петър", "Петров ", 6f),
                new Student("Катя ", "Катева ", 5.99f),
                new Student("Яна", "  Янева  ", 2.11f),
                new Student("Бела ", "Белева ", 5.56f),
            };

            PrintLine();

            Console.WriteLine("Студенти:");
            Console.WriteLine();

            var sortedStudents = studentList.OrderBy(x => x.Grade);

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
                finalList.Add(item);
            }

            PrintLine();

            List<Worker> workerList = new List<Worker>
            {
                new Worker("Петко ", "Илиев  ", 200, 8),
                new Worker("Жоро  ", "Петков ", 350, 8),
                new Worker("Васко ", "Петров ", 180, 8),
                new Worker("Коко  ", "Василев", 350, 4),
                new Worker("Мими  ", "Лилиева", 350, 6),
                new Worker("Лили  ", "Мимева ", 200, 4),
                new Worker("Петър ", "Кътев  ", 350, 8),
                new Worker("Мария ", "Петрова", 400, 6),
                new Worker("Ваня  ", "Велева ", 180, 4),
                new Worker("Бела  ", "Янева  ", 320, 6),

            };

            Console.WriteLine("Служители:");
            Console.WriteLine();

            var sortedWorkers = workerList.OrderBy(x => x.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
                finalList.Add(worker);
            }

            PrintLine();

            Console.WriteLine("Всички:");
            Console.WriteLine();

            var sortedFinalList = from person in finalList
                                  orderby person.FirstName, person.LastName
                                  select person;

            foreach (var person in sortedFinalList)
            {

                Console.WriteLine(string.Format("{0} {1}", person.FirstName.Trim(), person.LastName.Trim()));
            }

            PrintLine();            
        }
    }
}

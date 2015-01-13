/*

<Problem 04> 
 
 Create a class Person with two fields - name and
 age. Age can be left unspecified (may contain null
 value. Overrider ToString() to display the
 information of a person and if age is not specified -
 to say so. Write a program to test this functionality.
 
*/

namespace _04.CreateClassPerson
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Globalization;

    class CreateClassPerson
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "CreateClassPerson";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;


            // test constructors

            Person testPerson1 = new Person();
            Person testPerson2 = new Person("Ivan Ivanov");
            Person testPerson3 = new Person("Petyr Petrov", 25);
            Person testPerson4 = new Person("Georgi Georgiev", null);

            // test ToString() override

            Console.WriteLine(testPerson1);
            Console.WriteLine(testPerson2);
            Console.WriteLine(testPerson3);
            Console.WriteLine(testPerson4);

            Console.WriteLine();
        }
    }
}

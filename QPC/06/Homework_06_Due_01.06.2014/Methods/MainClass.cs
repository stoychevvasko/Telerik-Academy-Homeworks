// <copyright file="MainClass.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Homework06
{
    using System;

    /// <summary>Starts program execution.</summary>
    public class MainClass
    {
        /// <summary>Executes program.</summary>
        public static void Main()
        {
            Console.WriteLine("Triangle calculations:");
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));            
            Console.WriteLine();

            int number = 5;
            Console.Write("Number {0} is ", number);
            Console.WriteLine(Methods.NumberToDigit(number));
            Console.WriteLine();

            Console.Write("Max among [5, -1, 3, 2, 14, 2, 3] is ");
            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine();

            Console.WriteLine("Formatted strings:");
            Console.WriteLine("FormatNumber(1.3, \"f\") -> " + Methods.FormatNumber(1.3, "f"));
            Console.WriteLine("FormatNumber(0.75, \"%\") -> " + Methods.FormatNumber(0.75, "%"));
            Console.WriteLine("FormatNumber(2.30, \"r\") -> " + Methods.FormatNumber(2.30, "r"));
            Console.WriteLine();

            Console.WriteLine("Distance:");
            bool horizontal, vertical;
            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
            Console.WriteLine();

            Student peter = new Student("Peter", "Ivanov", DateTime.Parse("17.03.1992"));
            peter.OtherInfo = "from Sofia";
            Console.WriteLine(peter.ToString());

            Student stella = new Student("Stella", "Markova", DateTime.Parse("03.11.1993"));
            stella.OtherInfo = "from Vidin, gamer, high results";
            Console.WriteLine(stella.ToString());

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

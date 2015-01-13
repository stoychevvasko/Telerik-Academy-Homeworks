/*

<Problem 01>

Implement an extension method Substring(int 
index, int length) for the class StringBuilder 
that returns new StringBuilder and has the same 
functionality as Substring in the class String.

*/

namespace _01.SubStringBuilder
{
    using System;
    using System.Text;        

    class SubStringBuilder
    {
        static void Main()
        {            
            Console.Title = "01.SubStringBuilder";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;

            
            StringBuilder testBuilder01 = new StringBuilder("Testing 1, 2, 3...");
            System.Console.WriteLine("1." + testBuilder01);
            System.Console.WriteLine("2." + testBuilder01.Substring(0, 5));
            System.Console.WriteLine("3." + testBuilder01.Substring(-1, 6));
            System.Console.WriteLine("4." + testBuilder01.Substring(0, 25));
            System.Console.WriteLine("5." + testBuilder01.Substring(0, -3));
            System.Console.WriteLine("6." + testBuilder01.Substring(5, 2));
            System.Console.WriteLine("7." + testBuilder01.Substring(5, 0));


            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.ReadKey();
        }
    }
}

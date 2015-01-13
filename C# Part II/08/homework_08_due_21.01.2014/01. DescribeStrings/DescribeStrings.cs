using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Describe the strings in C#. What is typical for the string data type? 
//Describe the most important methods of the String class.

namespace _01.DescribeStrings
{
    class DescribeStrings
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "DescribeStrings";
            Console.Clear();

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("          S T R I N G S");
            Console.WriteLine();
            Console.WriteLine(new string('-', 60));
            
            Console.WriteLine("Strings in C# are a data type consisting of sequences of");
            Console.WriteLine("characters.");            
            Console.WriteLine();
            Console.WriteLine("Strings are considered immutable, meaning that no direct");
            Console.WriteLine("changes to a string can be made. All methods that seemingly");
            Console.WriteLine("make changes to a string create a new resulting string and ");
            Console.WriteLine("return it as a value instead of modifyingthe source string");
            Console.WriteLine("directly.");
            Console.WriteLine();
            Console.WriteLine("Characters in strings can be accessed through an index");
            Console.WriteLine("in a similar fashion to arrays.");
            Console.WriteLine();
            Console.WriteLine("Some basic methods of the class include String.Equals()");
            Console.WriteLine("String.CompareTo(), + for concatenation, String.Replace(), ");
            Console.WriteLine("IndexOf() and others.");
            Console.WriteLine();
            Console.WriteLine("The built-in immutability of strings comes at the price of");
            Console.WriteLine("speed. The implementation of the StringBuilder class has ");
            Console.WriteLine("largely remedied this problem and is recommended.");
            Console.WriteLine();
            Console.WriteLine("Strings are a fundamental data type in programming in ");
            Console.WriteLine("general as well as C# in particular.");
            

            Console.WriteLine();
            Console.ReadKey();
        }
    }



}

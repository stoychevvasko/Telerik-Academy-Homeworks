/*

<Problem 17*>

Write a program to return the string with maximum 
length from an array of strings. Use LINQ.

*/

namespace _17.MaxLengthStringLINQ
{
    using System;
    using System.Linq;    

    class MaxLengthStringLINQ
    {        
        static void Main()
        {
            Console.Title = "16.GroupClass";
            Console.SetWindowSize(42, 10);
            Console.BufferWidth = Console.WindowWidth = 42;
            Console.BufferHeight = Console.WindowHeight = 10;

            string[] array = new string[] { "short", "mini", "this_is_the_longest_string_here", "longer", "this_one_is_long" };
            
            Console.WriteLine("The longest string is:");
            Console.WriteLine();

            string result = (from str in array orderby str.Length select str).Last();

            Console.WriteLine(result);
            

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

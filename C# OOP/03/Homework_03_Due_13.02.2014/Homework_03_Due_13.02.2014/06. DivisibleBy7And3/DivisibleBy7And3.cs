/*

<Problem 06>

Write a program that prints from given array of 
integers all numbers that are divisible by 7 and 3. Use
the built-in extension methods and lambda 
expressions. Rewrite the same with LINQ.

*/

namespace _06.DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            Console.Title = "06.DivisibleBy7And3";
            Console.SetWindowSize(40, 20);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 20;
                        

            int[] allNums = new int[1000];

            for (int i = 1; i < 1001; i++)
			{
                allNums[i - 1] = i;
			}

            // Lambda expression

            var resultLambda = allNums.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();

            Console.WriteLine("with Lambda expression:");
            Console.WriteLine();

            foreach (var item in resultLambda)
            {
                Console.Write("{0, 3} ", item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // LINQ

            var resultLinq =
                from num in allNums
                where num % 7 == 0 && num % 3 == 0
                select num;


            Console.WriteLine("with LINQ query:");
            Console.WriteLine();

            foreach (var item in resultLinq)
            {
                Console.Write("{0, 3} ", item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

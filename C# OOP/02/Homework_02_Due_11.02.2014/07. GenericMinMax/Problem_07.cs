/*

<Problem 07>

Create generic methods Min<T>() and Max<T>()
for finding the minimal and maximal element in the
GenericList<T>. You may need to add generic 
constraints for the type T.

*/

// added generic constraints to the entire GenericList<T> class
// methods start at line 221 in GenericList.cs from <Problem 05>

namespace _07.GenericMinMax
{
    using System;
    using System.Globalization;
    using System.Threading;
    using _05.GenericClass;
    
    // added a reference to <Problem 05>

    class Problem_07
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "07. GenericMinMax";
            Console.SetWindowSize(60, 20);
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            // create a char and an int instance for test purposes

            GenericList<char> letters = new GenericList<char>();
            GenericList<int> numbers = new GenericList<int>();

            for (int i = 0; i < 128; i++)
            {
                letters.Add((char)i);
                numbers.Add(i);
            }

            Console.WriteLine(numbers.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Min: {0} Max: {1}", numbers.Min<int>(), numbers.Max<int>());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(letters.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Min: {0} Max: {1}", letters.Min<char>(), letters.Max<char>());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

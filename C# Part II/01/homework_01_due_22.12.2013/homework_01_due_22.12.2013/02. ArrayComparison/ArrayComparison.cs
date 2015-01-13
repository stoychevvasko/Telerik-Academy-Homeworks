using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that reads two arrays from the 
//     console and compares them element by element.

class ArrayComparison
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ArrayComparison";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a program that reads two arrays from the ");
        Console.WriteLine("  console and compares them element by element.");
        Console.WriteLine();
        Console.WriteLine();
                
        Console.Write("  What is the length of the first array? ");
        string keyboardInput = Console.ReadLine();
        uint arrayOneLength = 0;

        while (!uint.TryParse(keyboardInput, out arrayOneLength) || (arrayOneLength == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array length, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the length of the first array? ");
            keyboardInput = Console.ReadLine();
        }
        
        Console.WriteLine();
        Console.WriteLine();

        int[] arrayOne = new int[arrayOneLength];

        for (int i = 0; i < arrayOneLength; i++)
        {
            Console.Write("  arrayOne[{0}] = ", i);
            keyboardInput = Console.ReadLine();


            while (!int.TryParse(keyboardInput, out arrayOne[i]))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Cannot be converted to a valid numeric value, please try again!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  arrayOne[{0}] = ", i);
                keyboardInput = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        uint arrayTwoLength = 0;

        Console.Write("  What is the length of the second array? ");
        keyboardInput = Console.ReadLine();

        while (!uint.TryParse(keyboardInput, out arrayTwoLength) || (arrayTwoLength == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array length, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the length of the second array? ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] arrayTwo = new int[arrayTwoLength];

        for (int i = 0; i < arrayTwoLength; i++)
        {
            Console.Write("  arrayTwo[{0}] = ", i);
            keyboardInput = Console.ReadLine();


            while (!int.TryParse(keyboardInput, out arrayTwo[i]))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Cannot be converted to a valid numeric value, please try again!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  arrayTwo[{0}] = ", i);
                keyboardInput = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        uint arrayComparisonLength = ((arrayOneLength <= arrayTwoLength) ? arrayOneLength : arrayTwoLength);

        bool areArraysEqual = true;

        for (int i = 0; i < arrayComparisonLength; i++)
        {
            if (arrayOne[i] != arrayTwo[i])
            {
                areArraysEqual = false;
                break;
            }
        }

        if (areArraysEqual)
        {
            Console.WriteLine("  The two arrays are equal up to index [{0}] (including).", arrayComparisonLength - 1);
        }
        else
        {
            Console.WriteLine("  The two arrays are not equal.");
        }
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
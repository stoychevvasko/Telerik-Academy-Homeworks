using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that compares two char arrays 
//     lexicographically (letter by letter).


class LexicographicalComparison
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "LexicographicalComparison";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a program that compares two char arrays ");
        Console.WriteLine("  lexicographically (letter by letter).");
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

        char[] arrayOne = new char[arrayOneLength];
        Console.Write("  Please enter arrayOne as string: ");
        keyboardInput = Console.ReadLine();
        
        for (int i = 0; i < arrayOneLength; i++)
        {
            arrayOne[i] = keyboardInput[i];
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

        char[] arrayTwo = new char[arrayTwoLength];
        Console.Write("  Please enter arrayTwo as string: ");
        keyboardInput = Console.ReadLine();

        for (int i = 0; i < arrayTwoLength; i++)
        {
            arrayTwo[i] = keyboardInput[i];
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
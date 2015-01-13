using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that finds in given array of integers 
//     a sequence of given sum S (if present). Example:
//     {4, 3, 1, 4, 2, 5, 8}, S=11 --> {4, 2, 5}	

class SequenceOfGivenSumInArray
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SequenceOfGivenSumInArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that finds in given array of integers ");
        Console.WriteLine("  a sequence of given sum S (if present). Example:");
        Console.WriteLine("  {4, 3, 1, 4, 2, 5, 8}, S=11 --> {4, 2, 5}	");
        Console.WriteLine();
        Console.WriteLine();

        int arrayLength = 0;
        Console.Write("  What is the length of the array? ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out arrayLength) || (arrayLength == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array length, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the length of the array? ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("  array[{0}] = ", i);
            keyboardInput = Console.ReadLine();

            while (!int.TryParse(keyboardInput, out array[i]))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Cannot be converted to a valid numeric value, please try again!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  array[{0}] = ", i);
                keyboardInput = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        int sumSeek;
        Console.Write("  What is the sum you seek? S = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out sumSeek))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid sum, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the sum you seek? S = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        
        int currentSum, seqStart = -1, seqEnd = -1;

        for (int i = 0; i < arrayLength; i++)
        {
            currentSum = 0;
            
            for (int j = i; j < arrayLength; j++)
            {
                if (currentSum == sumSeek)
                {
                    seqStart = i;
                    seqEnd = j;
                }

                currentSum += array[j];
            }
        }

        if (seqStart == -1)
        {
            Console.WriteLine("  No sequence found!");
        }
        else
        {
            Console.Write("  Sequence found: {");
            
            for (int i = seqStart; i < seqEnd; i++)
            {
                Console.Write(array[i]);

                if (i != seqEnd - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("}");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
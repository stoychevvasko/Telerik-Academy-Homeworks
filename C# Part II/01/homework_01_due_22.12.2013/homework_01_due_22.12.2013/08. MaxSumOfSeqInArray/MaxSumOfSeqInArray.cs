using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that finds the sequence of maximal 
//     sum in given array. Example:
//     {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
//     Can you do it with only one loop (with single scan 
//     through the elements of the array)?


class MaxSumOfSeqInArray
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MaxSumOfSeqInArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that finds the sequence of maximal ");
        Console.WriteLine("  sum in given array. Example:");
        Console.WriteLine("  {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}");
        Console.WriteLine("  Can you do it with only one loop (with single scan ");
        Console.WriteLine("  through the elements of the array)?");
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
        
        int endOfMaxSeq = 0, currentStart = 0, currentMax = array[0], currentMaxEnd = array[0];
        int count = 1;

        for (int i = 0; i < arrayLength; i++)
        {
            if (currentMaxEnd < 0)
            {
                currentMaxEnd = array[i];
                currentStart = i;
                count = 1;
            }
            else
            {
                currentMaxEnd += array[i];                
            }

            if (currentMaxEnd >= currentMax)
            {
                currentMax = currentMaxEnd;                
                endOfMaxSeq = i;
                count++;
            }
        }        

        Console.WriteLine("  This is the sequence of maximum sum:");
        Console.WriteLine();

        for (int i = endOfMaxSeq - count + 1; i <= endOfMaxSeq; i++)
        {
            Console.WriteLine("  array[{0}] = {1}", i, array[i]);
        }

        Console.WriteLine();
        Console.WriteLine("  The sum of this sequence is {0}.", currentMax);
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
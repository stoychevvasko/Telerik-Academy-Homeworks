using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Write a program that reads an array of integers 
//     and removes from it a minimal number of elements 
//     in such way that the remaining array is sorted in 
//     increasing order. Print the remaining sorted array. 
//     Example:
//     {6, 1, 4, 3, 0, 3, 6, 4, 5} --> {1, 3, 3, 4, 5}

class MinimalNumRemovalForSortedArray
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MinimalNumRemovalForSortedArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that reads an array of integers ");
        Console.WriteLine("  and removes from it a minimal number of elements ");
        Console.WriteLine("  in such way that the remaining array is sorted in ");
        Console.WriteLine("  increasing order. Print the remaining sorted array. ");
        Console.WriteLine("  Example:");
        Console.WriteLine("  {6, 1, 4, 3, 0, 3, 6, 4, 5} --> {1, 3, 3, 4, 5}");
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
        
        int maxNumberOfSubsets = (int)Math.Pow(2, array.Length) - 1;
        List<int> sortedElements = new List<int>();
        List<int> elementsForComparison = new List<int>();
        int min;
        int counter;
        int biggestCombination = 0;

        for (int i = 0; i < maxNumberOfSubsets - 1; i++)
        {
            counter = 0;
            min = int.MinValue;
            for (int j = 0; j < array.Length; j++)
            {
                if ((((i >> j) & 1) == 1) && (min <= array[j]))
                {
                    min = array[j];
                    elementsForComparison.Add(array[j]);
                    counter++;
                }
            }

            if (counter > biggestCombination)
            {
                sortedElements.Clear();
                biggestCombination = counter;
                for (int j = 0; j < elementsForComparison.Count; j++)
                {
                    sortedElements.Add(elementsForComparison[j]);
                }
            }

            elementsForComparison.Clear();
        }
        
        string consoleOutput = "{ ";
        int commaOrNoComma = 0;

        for (int j = 0; j < sortedElements.Count; j++)
        {
            commaOrNoComma++;

            if (commaOrNoComma > 1)
            {
                consoleOutput += ", ";
            }

            consoleOutput += (sortedElements[j]);
        }

        consoleOutput += " }  ";

        Console.WriteLine("  The subset we're looking for is {0}", consoleOutput);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
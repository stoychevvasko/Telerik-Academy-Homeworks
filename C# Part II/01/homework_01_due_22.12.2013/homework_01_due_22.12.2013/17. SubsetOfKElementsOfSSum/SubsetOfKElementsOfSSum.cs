using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that reads three integer numbers 
//     N, K and S and an array of N elements from the 
//     console. Find in the array a subset of K elements 
//     that have sum S or indicate about its absence.

class SubsetOfKElementsOfSSum
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SubsetOfKElementsOfSSum";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that reads three integer numbers ");
        Console.WriteLine("  N, K and S and an array of N elements from the ");
        Console.WriteLine("  console. Find in the array a subset of K elements ");
        Console.WriteLine("  that have sum S or indicate about its absence.");
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

        int numberOfElements;
        Console.Write("  How many elements should make up that sum? K = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out numberOfElements))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid number of elements, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  How many elements should make up that sum? K = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        
        string currentSubset;
        int counter = 0;
        int commaOrNoComma;

        int maxNumberOfSubsets = (int)Math.Pow(2, array.Length) - 1;

        for (int i = 1; i < maxNumberOfSubsets; i++)
        {
            currentSubset = "{ ";
            int currentSum = 0;
            int currentNumberOfElements = 0;
            commaOrNoComma = 0;

            for (int j = 0; j < arrayLength; j++)
            {
                int maskedNum = (1 << j) & i;
                int bit = maskedNum >> j;
                if (bit == 1)
                {
                    commaOrNoComma++;

                    if (commaOrNoComma > 1)
                    {
                        currentSubset += ", ";
                    }

                    currentSum += array[j];
                    currentSubset += (array[j]);
                    currentNumberOfElements++;
                }
            }

            currentSubset += " }  ";

            if (currentSum == sumSeek && currentNumberOfElements == numberOfElements)
            {
                counter++;
                Console.WriteLine("  Subset found! {0}", currentSubset);
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("  A total of {0} subsets of {1} elements with sum of {2} were found.", counter, numberOfElements, sumSeek);
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     We are given an array of integers and a number S. 
//     Write a program to find if there exists a subset of 
//     the elements of the array that has a sum S. 
//     Example:
//     arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 --> yes (1+2+5+6)

class SubsetOfSSumInArray
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SubsetOfSSumInArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  We are given an array of integers and a number S. ");
        Console.WriteLine("  Write a program to find if there exists a subset of ");
        Console.WriteLine("  the elements of the array that has a sum S. ");
        Console.WriteLine("  Example:");
        Console.WriteLine("  arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 --> yes (1+2+5+6)");
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

        string currentSubset;
        int counter = 0;        
        int commaOrNoComma;

        int maxNumberOfSubsets = (int)Math.Pow(2, array.Length) - 1;
        
        for (int i = 1; i < maxNumberOfSubsets; i++)
        {
            currentSubset = "{ ";
            int currentSum = 0;
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
                }
            }

            currentSubset += " }  ";

            if (currentSum == sumSeek)
            {
                counter++;
                Console.WriteLine("  Subset found! {0}", currentSubset);
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("  A total of {0} subsets with sum of {1} were found.", counter, sumSeek);
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
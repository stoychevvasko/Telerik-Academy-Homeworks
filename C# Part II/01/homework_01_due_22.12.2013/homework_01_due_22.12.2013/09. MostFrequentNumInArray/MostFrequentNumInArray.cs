using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that finds the most frequent 
//     number in an array. Example:
//     {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --> 4 (5 times)

class MostFrequentNumInArray
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MostFrequentNumInArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that finds the most frequent");
        Console.WriteLine("  number in an array. Example:");
        Console.WriteLine("  {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --> 4 (5 times)");
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

        int[] frequency = new int[arrayLength];
        int count, value;

        for (int i = 0; i < arrayLength; i++)
        {
            count = 0;
            value = array[i];
            
            for (int j = i; j < arrayLength; j++)
            {
                if (value == array[j])
                {
                    count++;
                }
            }

            frequency[i] = count;
        }

        int maxFrequency = frequency[0];
        int maxIndex = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            if (frequency[i] > maxFrequency)
            {
                maxFrequency = frequency[i];
                maxIndex = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("  The most frequent element is {0}. It was found {1} times.", array[maxIndex], maxFrequency);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
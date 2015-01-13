using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that counts how many times given 
//     number appears in given array. Write a test program 
//     to check if the method is working correctly.

class CountRepeatsInArray
{
    static int RepeatCounter(int[] array, int element)
    {
        int count = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                count++;
            }
        }

        return count;
    }

    static int[] ArrayMaker()
    {
        Console.Write("How many elements should the array have? ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];
        Random randomGenerator = new Random();

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = randomGenerator.Next(10);
        }

        return array;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        Console.SetWindowSize(83, 41);
        Console.Title = "CountRepeatsInArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        int[] array = ArrayMaker();

        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}  ", array[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Which element would you like to count? (0-9) ");
        int queryElement = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int finalCount = RepeatCounter(array, queryElement);

        Console.WriteLine("The element {0} was found {1} time{2} within the array.",
            queryElement, finalCount, (finalCount == 1)?"":"s");

        Console.ReadKey();
    }
}



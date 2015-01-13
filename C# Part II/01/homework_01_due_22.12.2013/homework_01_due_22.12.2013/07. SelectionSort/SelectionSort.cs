using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Sorting an array means to arrange its elements in 
//     increasing order. Write a program to sort an array. 
//     Use the "selection sort" algorithm: Find the smallest 
//     element, move it at the first position, find the 
//     smallest from the rest, move it at the second 
//     position, etc.


class SelectionSort
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SelectionSort";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Sorting an array means to arrange its elements in ");
        Console.WriteLine("  increasing order. Write a program to sort an array. ");
        Console.WriteLine("  Use the selection sort algorithm: Find the smallest ");
        Console.WriteLine("  element, move it at the first position, find the ");
        Console.WriteLine("  smallest from the rest, move it at the second ");
        Console.WriteLine("  position, etc.");

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

        int minNum, minNumIndex, swapNum;

        for (int i = 0; i < arrayLength; i++)
        {
            minNum = array[i];
            minNumIndex = i;
            
            for (int j = i; j < arrayLength; j++)
            {
                if (minNum > array[j])
                {
                    minNum = array[j];
                    minNumIndex = j;
                }
            }

            swapNum = array[minNumIndex];
            array[minNumIndex] = array[i];
            array[i] = swapNum;

        }

        Console.WriteLine("  The array is now sorted:");
        Console.WriteLine();

        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("  array[{0}] = {1}", i, array[i]);
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
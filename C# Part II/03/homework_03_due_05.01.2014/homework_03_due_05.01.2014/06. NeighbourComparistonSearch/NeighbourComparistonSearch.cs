using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that returns the index of the first 
//     element in array that is bigger than its neighbors, or 
//     -1, if there’s no such element.
//     Use the method from the previous exercise.

class NeighbourComparistonSearch
{
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

    public static bool BiggerThanNeighbours(int[] array, int position)
    {
        if (position <= 0 || position >= array.Length - 1)
        {
            return false;
        }
        else
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // this is the new method

    static int NeighbourSearch(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (BiggerThanNeighbours(array, i))
            {
                return i;
            }
        }
        
        return -1;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NeighbourComparistonSearch";
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

        int finalResult = NeighbourSearch(array);

        if (finalResult == -1)
        {
            Console.WriteLine("No element in the array meets the criteria!");
        }
        else
        {
            Console.WriteLine("The first element to meet the criteria was found at position {0}.", finalResult);
        }

        Console.ReadKey();
    }
}



using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that checks if the element at given 
//     position in given array of integers is bigger than its 
//     two neighbors (when such exist).

class NeightbourComparisonInArray
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

    static bool BiggerThanNeighbours(int[] array, int position)
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

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NeightbourComparisonInArray";
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

        Console.Write("Which position should I check? [0-{0}] ", array.Length - 1);
        int pos = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Is the element greater than its two neighbours? {0}", BiggerThanNeighbours(array, pos));

        Console.ReadKey();
    }
}



using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that finds the index of given 
//     element in a sorted array of integers by using the 
//     binary search algorithm (find it in Wikipedia).

class BinarySearch
{
    //     this is a method that seeks an element within a sorted array using the 
    //     binary search algorithm. It returns the index of the element if
    //     found or -1 if not found.

    static public int BinarySearchAlgo(int[] array, int elementSought)
    {
        int upperLimit = array.Length - 1;
        int lowerLimit = 0;

        while (upperLimit >= lowerLimit)
        {
            int middle = (lowerLimit + upperLimit) / 2;

            if (array[middle] < elementSought)
            {
                lowerLimit = middle + 1;
            }
            else if (array[middle] > elementSought)
            {
                upperLimit = middle - 1;
            }
            else
            {
                return middle;
            }
        }

        return -1;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BinarySearch";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that finds the index of given ");
        Console.WriteLine("  element in a sorted array of integers by using the ");
        Console.WriteLine("  binary search algorithm (find it in Wikipedia).");
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

        Array.Sort(array);

        Console.WriteLine();
        Console.WriteLine();

        int elementSought = 0;
        Console.Write("  What is the element you seek? ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out elementSought))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid element, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the element you seek? ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int result = BinarySearchAlgo(array, elementSought);

        if (result == -1)
        {
            Console.WriteLine("  Element {0} could not be found in the array.", elementSought);
        }
        else
        {
            Console.WriteLine("  Element {0} was found in the array at index {1}.", elementSought, result);
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that return the maximal element in 
//     a portion of array of integers starting at given index. 
//     Using it write another method that sorts an array in 
//     ascending / descending order.

class SortViaMaxElement
{
    public static int MaxElementIndex(int[] array, int startIndex, int endIndex)
    {
        int result = startIndex;

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] >= array[result])
            {
                result = i;   
            }
        }

        return result;   
    }

    public static int[] SortViaMax(int[] array, bool isAscending)
    {
        if (isAscending)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int maxIndex = MaxElementIndex(array, 0, i);
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }
        }
        else if (!isAscending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = MaxElementIndex(array, i, array.Length - 1);
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }
        }       

        return array;        
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SortViaMaxElement";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        
        Console.WriteLine("This is the orriginal array:");
        
        int[] numbers = new int[25];
        Random randomGenerator = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = randomGenerator.Next(25);
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("This is the array sorted in ascending order:");
        
        int[] ascendingNumbers = new int[numbers.Length];
        (SortViaMax(numbers, true)).CopyTo(ascendingNumbers, 0);

        for (int i = 0; i < ascendingNumbers.Length; i++)
        {
            Console.Write("{0} ", ascendingNumbers[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("This is the array sorted in descending order:");
        
        int[] descendingNumbers = new int[numbers.Length];
        (SortViaMax(numbers, false)).CopyTo(descendingNumbers, 0);

        for (int i = 0; i < descendingNumbers.Length; i++)
        {
            Console.Write("{0} ", descendingNumbers[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}


using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that sorts an array of integers 
//     using the merge sort algorithm (find it in Wikipedia).

class MergeSort
{
    static void MergeSortAlgo(int[] array)
    {
        if (array.Length < 2)
        {
            return;
        }        
        
        int[] leftArray = new int[array.Length / 2];
        int[] rightArray = new int[array.Length - leftArray.Length];

        Array.Copy(array, 0, leftArray, 0, leftArray.Length);
        Array.Copy(array, leftArray.Length, rightArray, 0, rightArray.Length);

        MergeSortAlgo(leftArray);
        MergeSortAlgo(rightArray);

        int leftIndex = 0, rightIndex = 0;

        do
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                array[leftIndex + rightIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[leftIndex + rightIndex] = rightArray[rightIndex];
                rightIndex++;
            }
        } 
        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length);

        for (int i = leftIndex; i < leftArray.Length; i++)
        {
            array[i + rightIndex] = leftArray[i];
        }

        for (int i = rightIndex; i < rightArray.Length; i++)
        {
            array[leftIndex + i] = rightArray[i];
        }
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MergeSort";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that sorts an array of integers ");
        Console.WriteLine("  using the merge sort algorithm (find it in Wikipedia).");
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

        MergeSortAlgo(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("  array[{0}] = {1}", i, array[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
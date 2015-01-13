using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that sorts an array of strings using 
//     the quick sort algorithm (find it in Wikipedia).

class QuickSort
{
    //     this is a recursive method that sorts an array
    //     of strings using the quick sort algorithm

    public static void QuickSortAlgo(string[] array, int left, int right)
    {
        int l = left, r = right;
        string middle = array[(left + right) / 2];
        
        while (l <= r)
        {
            while (array[l].CompareTo(middle) < 0)
            {
                l++;
            }
 
            while (array[r].CompareTo(middle) > 0)
            {
                r--;
            }
 
            if (l <= r)
            {                
                string swap = array[l];
                array[l] = array[r];
                array[r] = swap;
 
                l++;
                r--;
            }
        }
 
        if (left < r)
        {
            QuickSortAlgo(array, left, r);
        }
 
        if (l < right)
        {
            QuickSortAlgo(array, l, right);
        }
    }
    
    //program starts here

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "QuickSort";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that sorts an array of strings using ");
        Console.WriteLine("  the quick sort algorithm (find it in Wikipedia).");
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

        string[] array = new string[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("  array[{0}] = ", i);
            array[i] = Console.ReadLine();
        }
        
        Console.WriteLine();
        Console.WriteLine();
                
        QuickSortAlgo(array, 0, array.Length - 1);

        Console.WriteLine("  The array was sorted via quick sort thusly:");
        Console.WriteLine();

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("  array[{0}] = ", i);
            Console.WriteLine(array[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
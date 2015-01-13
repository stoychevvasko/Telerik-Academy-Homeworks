using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that allocates array of 20 integers
//     and initializes each element by its index multiplied
//     by 5. Print the obtained array on the console.

class ArrayInitializationIndexX5
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ArrayInitializationIndexX5";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a program that allocates array of 20 integers ");
        Console.WriteLine("  and initializes each element by its index multiplied ");
        Console.WriteLine("  by 5. Print the obtained array on the console.");
        Console.WriteLine();
        Console.WriteLine();
              
        int[] array = new int[20];
        
        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
            Console.WriteLine("  array[{0}] = {1} * 5 = {2}", i, i, array[i]);            
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Write a program that reads two numbers N and K 
//     and generates all the variations of K elements from 
//     the set [1..N]. Example:
//     N = 3, K = 2 --> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, 
//     {3, 1}, {3, 2}, {3, 3}

class VariationsOfKElementsOf1ToN
{
    static int N = 0, K = 0;
    
    static public void MakeVariations(int[] array, int index)
    {
        if (index == array.Length)
        {
            Console.Write("  {");
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("}");
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;
                MakeVariations(array, index + 1);
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "VariationsOfKElementsOf1ToN";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that reads two numbers N and K ");
        Console.WriteLine("  and generates all the variations of K elements from ");
        Console.WriteLine("  the set [1..N]. Example:");
        Console.WriteLine("  N = 3, K = 2 --> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, ");
        Console.WriteLine("  {3, 1}, {3, 2}, {3, 3}");
        Console.WriteLine();
        Console.WriteLine();

        
        Console.Write("  N = ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N) || (N == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid value, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("  K = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out K) || (K == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid value, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  K = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] variations = new int[K];

        MakeVariations(variations, 0);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
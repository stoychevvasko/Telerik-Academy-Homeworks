using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Write a program that finds all prime numbers in the 
//     range [1...10 000 000]. Use the sieve of Eratosthenes
//     algorithm (find it in Wikipedia).

class SieveOfEratosthenes
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SieveOfEratosthenes";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that finds all prime numbers in the ");
        Console.WriteLine("  range [1...10 000 000]. Use the sieve of Eratosthenes");
        Console.WriteLine("  algorithm (find it in Wikipedia).");
        Console.WriteLine();
        Console.WriteLine();

        List<int> primeNumbers = new List<int>();
        int[] allNumbers = new int[10000000];

        for (int i = 0; i < 10000000; i++)
        {
            allNumbers[i] = i + 1;
        }

        int sieve = 2;
        bool finished = false;

        while (!finished)
        {
            primeNumbers.Add(sieve);
           
            for (int i = 2 * sieve - 1; i < 10000000; i += sieve)
            {
                allNumbers[i] = 0;
            }

            finished = true;

            for (int i = sieve; i < 10000000; i++)
            {
                if (allNumbers[i] != 0) 
                {
                    sieve = allNumbers[i];
                    finished = false;
                    break;
                }
            }
        }

        int count = 0;

        foreach (int prime in primeNumbers)
        {
            Console.Write("  " + prime + ",");
            count++;

            if (count == 10)
            {
                count = 0;
                Console.WriteLine();
                Console.WriteLine("  Press any key for more prime numbers...");
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
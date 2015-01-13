using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Write a program that reads two integer numbers N 
//     and K and an array of N elements from the console. 
//     Find in the array those K elements that have 
//     maximal sum.

class MaxSumOfKElementsInArray
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MaxSumOfKElementsInArray";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that reads two integer numbers N");
        Console.WriteLine("  and K and an array of N elements from the console. ");
        Console.WriteLine("  Find in the array those K elements that have ");
        Console.WriteLine("  maximal sum.");

        Console.WriteLine();
        Console.WriteLine();

        int N = 0;
        Console.Write("  What is the length of the array? N = ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N) || (N == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array length, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the length of the array? N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
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

        int K = 0;
        Console.Write("  What is the number of elements? K = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out K) || (K <= 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid number, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the number of elements? K = ");
            keyboardInput = Console.ReadLine();
        }

        int[] resultNums = new int[K];
        int[] resultIndices = new int[K];
        int maxNum;
        int maxIndex;
        bool alreadyChecked = false;

        //     initialize all resultIndices values with -1
        //     so that the check further down does not fail
        //     accidentally

        for (int i = 0; i < K; i++)
        {
            resultIndices[i] = -1;
        }

        //     these cycles extract the the largest number, the second largest
        //     number, the third largest number, etc., and their respective indices

        for (int i = 0; i < K; i++)
        {
            maxNum = array[0];
            maxIndex = 0;
            
            for (int j = 0; j < N; j++)
            {
                alreadyChecked = false;

                for (int r = 0; r < K; r++)
                {
                    if (j == resultIndices[r])
                    {
                        alreadyChecked = true;
                    }
                }

                if (!alreadyChecked)
                {
                    if (array[j] >= maxNum)
                    {
                        maxNum = array[j];
                        maxIndex = j;
                    }
                }
            }

            resultNums[i] = maxNum;
            resultIndices[i] = maxIndex;
        }

        //     print end results

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("  Here are the K elements with maximum sum:");
        Console.WriteLine();

        for (int i = 0; i < K; i++)
        {
            Console.WriteLine("  array[{0}] = {1}", resultIndices[i], resultNums[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
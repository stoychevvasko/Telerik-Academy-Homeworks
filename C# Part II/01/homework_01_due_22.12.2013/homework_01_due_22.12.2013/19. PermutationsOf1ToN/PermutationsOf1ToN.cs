using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that reads a number N and 
//     generates and prints all the permutations of the 
//     numbers [1 … N]. Example:
//     n = 3 --> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, 
//     {3, 2, 1}

class PermutationsOf1ToN
{
    static int N = 0;

    static public void MakePermutations(int[] array, bool[] alreadyUsed, int index)
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
            for (int i = 0; i < N; i++)
            {
                if (alreadyUsed[i])
                {
                    continue;
                }
                
                array[index] = i + 1;
                alreadyUsed[i] = true;
                MakePermutations(array, alreadyUsed, index + 1);
                alreadyUsed[i] = false;
            }
        }
    }


    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PermutationsOf1ToN";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that reads a number N and ");
        Console.WriteLine("  generates and prints all the permutations of the ");
        Console.WriteLine("  numbers [1 … N]. Example:");
        Console.WriteLine("  n = 3 --> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, ");
        Console.WriteLine("  {3, 2, 1}");
        Console.WriteLine();
        Console.WriteLine();

        
        Console.Write("  What is the number you wish to use for permutations? N = ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N) || (N <= 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid N value, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the number you wish to use for permutations? N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] permutations = new int[N];
        bool[] alreadyUsed = new bool[N];
        MakePermutations(permutations, alreadyUsed, 0);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
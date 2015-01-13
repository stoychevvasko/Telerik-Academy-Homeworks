using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that reads two numbers N and K 
//     and generates all the combinations of K distinct 
//     elements from the set [1..N]. Example:
//     N = 5, K = 2 --> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, 
//     {2, 5}, {3, 4}, {3, 5}, {4, 5}

class CombinationsOfKElementsOf1ToN
{
    static int N = 0, K = 0;

    static public void MakeCombinations(int[] array, int index, int usedNum)
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
            for (int i = usedNum; i <= N; i++)
            {
                array[index] = i;
                MakeCombinations(array, index + 1, i + 1);
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CombinationsOfKElementsOf1ToN";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that reads two numbers N and K ");
        Console.WriteLine("  and generates all the combinations of K distinct ");
        Console.WriteLine("  elements from the set [1..N]. Example:");
        Console.WriteLine("  N = 5, K = 2 --> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, ");
        Console.WriteLine("  {2, 5}, {3, 4}, {3, 5}, {4, 5}");
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

        int[] combinations = new int[K];
        
        MakeCombinations(combinations, 0, 1);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that reads a rectangular matrix of
//     size N x M and finds in it the square 3 x 3 that has
//     maximal sum of its elements.

class MaxSum3x3
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MaxSum3x3";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a program that reads a rectangular matrix of");
        Console.WriteLine("  size N x M and finds in it the square 3 x 3 that has");
        Console.WriteLine("  maximal sum of its elements.");
        Console.WriteLine();
        Console.WriteLine();

        int N = 0;
        Console.Write("  What is the length of the array? N = ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N) || (N < 3))
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

        int M = 0;
        Console.Write("  What is the height of the array? M = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out M) || (M < 3))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array height, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the height of the array? M = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[,] matrix = new int[N, M];

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("  matrix[{0}, {1}] = ", row, col);
                keyboardInput = Console.ReadLine();

                while (!int.TryParse(keyboardInput, out matrix[row, col]))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Invalid value, please try again!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  matrix[{0}, {1}] = ");
                    keyboardInput = Console.ReadLine();
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("  {0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        int[,] sums = new int[N - 2, M - 2];
        int maxSum = 0;
        int maxSumRow = 0;
        int maxSumCol = 0;

        for (int row = 0; row < N - 2; row++)
        {
            for (int col = 0; col < M - 2; col++)
            {
                sums[row, col] = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col]
                    + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1]
                    + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                if (maxSum < sums[row, col])
                {
                    maxSum = sums[row, col];
                    maxSumRow = row;
                    maxSumCol = col;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("  The 3x3 submatrix with maximum sum is as follows:");
        Console.WriteLine();

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("  {0, 5}", matrix[row + maxSumRow, col + maxSumCol]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("  The sum of this submatrix is {0}.", maxSum);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
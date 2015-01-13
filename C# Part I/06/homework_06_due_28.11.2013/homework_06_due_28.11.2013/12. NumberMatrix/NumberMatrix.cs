using System;
using System.Threading;
using System.Globalization;
using System.Text;

class NumberMatrix
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NumberMatrix";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("This application will print a number matrix for");
        Console.WriteLine("int N > 0 and N < 20");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter N = ");

        string keyboardInput = Console.ReadLine();
        int N;

        while (!int.TryParse(keyboardInput, out N) || (N < 1) || (N >= 20))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number!");
            Console.WriteLine();
            Console.Write("0 < N < 20 Please enter N = ");
            keyboardInput = Console.ReadLine();
        }

        // fill in two-dimensional array

        int[,] cell;
        cell = new int[N, N];
        cell[0, 0] = 1;

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                cell[row, column] = row + 1;
                if (column > 0)
                {
                    cell[row, column] = cell[row, column - 1] + 1;
                }
            }
        }

        // print results

        Console.WriteLine();
        Console.WriteLine();

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                Console.Write("{0, 2} ", cell[row, column]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
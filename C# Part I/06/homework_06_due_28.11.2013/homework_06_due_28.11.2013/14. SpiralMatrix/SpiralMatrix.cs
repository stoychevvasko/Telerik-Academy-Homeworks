using System;
using System.Threading;
using System.Globalization;
using System.Text;

class SpiralMatrix
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(100, 41);
        Console.Title = "SpiralMatrix";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("This application will print a spiral number matrix for");
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
        
        int previousCell = 0;
        int maxStep = N / 2 + N % 2;

        // step will show us whether we're on the outside of the spiral (step = 0), 
        // or 1 row/column further in (step = 1) or 2 rows/columns further in (step = 2)
        // etc., maxStep is the innermost part of the spiral


        for (int step = 0; step < maxStep; step++)
        {
            //top row

            for (int column = step; column < N - step; column++)
            {
                previousCell++;
                cell[step, column] = previousCell;
            }
            
            // right column

            for (int row = step + 1; row < N - step; row++)
            {
                previousCell++;
                cell[row, N - 1 - step] = previousCell;
            }

            // bottom row

            for (int column = N - 2 - step; column >= step; column--)
            {
                previousCell++;
                cell[N - 1 - step, column] = previousCell;
            }


            // left column

            for (int row = N - 2 - step; row > step; row--)
            {
                previousCell++;
                cell[row, step] = previousCell;
            }

            
        }
        

        // print results

        Console.WriteLine();
        Console.WriteLine();

        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                Console.Write("{0, 4} ", cell[row, column]);
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
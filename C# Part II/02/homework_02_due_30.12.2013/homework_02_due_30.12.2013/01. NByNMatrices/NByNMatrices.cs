using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that fills and prints a matrix of size 
//     (n, n) as shown below: (examples for n = 4)

class NByNMatrices
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("  ");
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}  ", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NByNMatrices";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that fills and prints a matrix of size");
        Console.WriteLine("  (n, n) as shown below: (examples for n = 4)");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("  What is the size of your matrix? n = ");
        string keyboardInput = Console.ReadLine();
        int n = 0;

        while (!int.TryParse(keyboardInput, out n) || (n == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid matrix size, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the size of your matrix? n = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("  a)");
        Console.WriteLine();
        

        int[,] matrixA = new int[n, n];
        int counter = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrixA[col, row] = counter;
                counter++;
            }
        }

        PrintMatrix(matrixA);
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  b)");
        Console.WriteLine();

        int[,] matrixB = new int[n, n];
        counter = 1;
        bool goingDown = true;


        for (int row = 0; row < n; row++)
        {
            if (goingDown)
            {
                for (int col = 0; col < n; col++)
                {
                    matrixB[col, row] = counter;
                    counter++;
                }

                goingDown = false;
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    matrixB[col, row] = counter;
                    counter++;
                }

                goingDown = true;
            }
        }

        PrintMatrix(matrixB);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  c)");
        Console.WriteLine();

        int[,] matrixC = new int[n, n];
        int rowC = n - 1;
        int colC = 0;
        int lastDiagonalStartRow;
        int lastDiagonalStartCol;
        int diagonalCount = 1;
        int diagonalDiscount = 1;
        counter = 1;
        bool diagonalSwitch = false;

        while (counter <= n * n)
        {
            if (diagonalCount <= n)
            {
                lastDiagonalStartRow = rowC;
                lastDiagonalStartCol = colC;

                for (int i = 1; i <= diagonalCount; i++)
                {
                    matrixC[rowC, colC] = counter;
                    counter++;

                    rowC++;
                    colC++;
                }
                                
                rowC = lastDiagonalStartRow - 1;
                colC = lastDiagonalStartCol;

                diagonalCount++;                
            }
            else
            {
                if (!diagonalSwitch)
                {
                    lastDiagonalStartCol = 1;
                    lastDiagonalStartRow = 0;
                    colC = 1;
                    rowC = 0;
                    diagonalSwitch = true;
                }
                else
                {
                    lastDiagonalStartRow = 0;
                    lastDiagonalStartCol = colC;
                }                

                for (int i = 1; i <= diagonalCount - diagonalDiscount - 1; i++)
                {
                    while (colC > n - 1)
                    {
                        colC = n - 1;
                    }

                    matrixC[rowC, colC] = counter;
                    counter++;

                    rowC++;
                    colC++;
                }

                rowC = lastDiagonalStartRow;
                colC = lastDiagonalStartCol + 1;

                diagonalCount++;
                diagonalDiscount++;
                diagonalDiscount++;   
            }
        }

        PrintMatrix(matrixC);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  d)");
        Console.WriteLine();

        int[,] matrixD = new int[n, n];
        int maxStep = (n % 2 == 0) ? (n / 2) : (n / 2 + 1);
        counter = 1;
        
        
        for (int step = 0; step < maxStep; step++)
        {
            for (int row = 0 + step; row < n - step; row++)
            {
                matrixD[row, 0 + step] = counter;
                counter++;
            }

            for (int col = 1 + step; col < n - step; col++)
            {
                matrixD[n - 1 - step, col] = counter;
                counter++;
            }

            for (int row = n - 2 - step; row >= 0 + step; row--)
            {
                matrixD[row, n - 1 - step] = counter;
                counter++;
            }

            for (int col = n - 2 - step; col >= 1 + step; col--)
            {
                matrixD[0 + step, col] = counter;
                counter++;
            }
        }        

        PrintMatrix(matrixD);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}



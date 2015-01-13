/*

<Problem 09>

Implement an indexer this[row, col] to access 
the inner matrix cells.

*/

namespace _09.MatrixIndexer
{
    using System;
    using System.Globalization;
    using System.Threading;
    using _08.MatrixOfT;

    // added reference to <Problem 08>
    
    // solution starts from line 51 in GenericMatrix.cs from <Problem 08>

    class Problem_09
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "09. MatrixIndexer";
            Console.SetWindowSize(50, 25);
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.BufferHeight = Console.WindowHeight = 25;


            // test indexer

            GenericMatrix<float> testMatrix01 = new GenericMatrix<float>(5,9);

            float num = 0F;

            Console.WriteLine("Example float matrix:");
            Console.WriteLine();
            Console.WriteLine();
            
            for (int row = 0; row < testMatrix01.Height; row++)
            {
                for (int col = 0; col < testMatrix01.Width; col++)
                {
                    testMatrix01[row, col] = num * (float)Math.PI;
                    num++;
                    Console.Write("{0, 9} ", testMatrix01[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();            
        }
    }
}

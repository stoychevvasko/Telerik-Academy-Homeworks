using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains 
//the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be
//a single number in a separate text file. 

class MatrixTextFile
{
    static public void DrawBox(int consoleY, int consoleX, int height, int width,
        char topLeft, char topRight, char bottomLeft, char bottomRight, char horizontal, char vertical)
    {
        Console.SetCursorPosition(consoleY, consoleX);
        Console.Write(topLeft);
        for (int i = 0; i < width - 2; i++)
        {
            Console.Write(horizontal);
        }
        Console.Write(topRight);

        Console.SetCursorPosition(consoleY, consoleX + height - 1);

        Console.Write(bottomLeft);
        for (int i = 0; i < width - 2; i++)
        {
            Console.Write(horizontal);
        }
        Console.Write(bottomRight);

        for (int i = 1; i < height - 1; i++)
        {
            Console.SetCursorPosition(consoleY, consoleX + i);
            Console.Write(vertical);
            Console.SetCursorPosition(consoleY + width - 1, consoleX + i);
            Console.Write(vertical);
        }
    }

    static public void DrawSingleBox(int consoleY, int consoleX, int height, int width)
    {
        DrawBox(consoleY, consoleX, height, width, '\u250C', '\u2510', '\u2514', '\u2518', '\u2500', '\u2502');
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 80;
        Console.Title = "MatrixTextFile";
        
        Console.Clear();

        Console.Write("What is the size of the square matrix? N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] numbers = new int[n, n];
        Console.WriteLine();

        StreamReader read = new StreamReader(@"../../matrix.txt");
        string line = read.ReadLine();
        int currentLine = 0;
        while (!read.EndOfStream)
        {
            string[] numbersStr = line.Split(' ');
            for (int y = 0; y < n; y++)
            {
                numbers[currentLine, y] = int.Parse(numbersStr[y]);
                Console.Write("  {0, 2}", numbers[currentLine, y]);
            }
            currentLine++;
            line = read.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        int bestSum = int.MinValue;
        int bestSumX = 0;
        int bestSumY = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (numbers[i,j] + numbers[i+1,j] + numbers[i, j+1] + numbers[i+1, j+1] > bestSum)
                {
                    bestSum = numbers[i, j] + numbers[i + 1, j] + numbers[i, j + 1] + numbers[i + 1, j + 1];
                    bestSumX = i;
                    bestSumY = j;
                }
            }
        }

        StreamWriter write = new StreamWriter(@"../../best_sum.txt");
        write.WriteLine(bestSum);
        write.Close();

        Console.WriteLine("The Best 2 x 2 sum is {0}, recorded in file.", bestSum);

        
        DrawSingleBox(1 + bestSumY * 4, 1 + bestSumX * 2, 5, 9);
        Console.SetCursorPosition(0, 21);
        Console.WriteLine("on row {0} and column {1}", bestSumX, bestSumY);

        Console.WriteLine();
        Console.ReadKey();
    }
}



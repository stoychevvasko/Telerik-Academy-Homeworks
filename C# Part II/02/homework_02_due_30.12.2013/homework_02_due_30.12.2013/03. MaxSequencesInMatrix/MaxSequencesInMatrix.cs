using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     We are given a matrix of strings of size N x M. 
//     Sequences in the matrix we define as sets of several 
//     neighbor elements located on the same line, column 
//     or diagonal. Write a program that finds the longest 
//     sequence of equal strings in the matrix. 

class MaxSequencesInMatrix
{
    public static string[,] matrix = 
    {
       {"ha", "fifi", "ho", "hi"},
       {"fo", "ha", "hi", "xx"},
       {"xxx", "ho", "ha", "xx"}
    };

    //public static string[,] matrix = 
    //{
    //   {"s", "qq", "s"},
    //   {"pp", "pp", "s"},
    //   {"pp", "qq", "s"}
    //};

    //public static string[,] matrix = 
    //{
    //   {"hah", "xxx", "xxx", "hah", "lol"},
    //   {"xxx", "hah", "hah", "xxx", "lol"},
    //   {"xxx", "hah", "hah", "xxx", "lol"},
    //   {"hah", "xxx", "xxx", "hah", "lol"}
    //};

    public static string[] direction = { "down", "right", "right_diagonal", "left_diagonal" };

    public static int countNeighbours(int row, int col, string direction)
    {
        switch (direction)
        {
            // check if the next element is out of range

            case "down": if (row + 1 >= matrix.GetLength(0)) return 1; break;
            case "right": if (col + 1 >= matrix.GetLength(1)) return 1; break;
            case "right_diagonal": if ((row + 1 >= matrix.GetLength(0)) || (col + 1 >= matrix.GetLength(1))) return 1; break;
            case "left_diagonal": if ((row + 1 >= matrix.GetLength(0)) || (col - 1 < 0)) return 1; break;
        }

        switch (direction)
        {
            // check if the next element is equal to the current one

            case "down":
                {
                    if (matrix[row, col].CompareTo(matrix[row + 1, col]) == 0)
                    {
                        return (1 + countNeighbours(row + 1, col, "down"));
                    }
                }
                break;

            case "right":
                {
                    if (matrix[row, col].CompareTo(matrix[row, col + 1]) == 0)
                    {
                        return (1 + countNeighbours(row, col + 1, "right"));
                    }
                }
                break;

            case "right_diagonal":
                {
                    if (matrix[row, col].CompareTo(matrix[row + 1, col + 1]) == 0)
                    {
                        return (1 + countNeighbours(row + 1, col + 1, "right_diagonal"));
                    }
                }
                break;

            case "left_diagonal":
                {
                    if (matrix[row, col].CompareTo(matrix[row + 1, col - 1]) == 0)
                    {
                        return (1 + countNeighbours(row + 1, col - 1, "left_diagonal"));
                    }
                }
                break;
        }

        return 1;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MaxSequencesInMatrix";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  We are given a matrix of strings of size N x M.");
        Console.WriteLine("  Sequences in the matrix we define as sets of several");
        Console.WriteLine("  neighbor elements located on the same line, column");
        Console.WriteLine("  or diagonal. Write a program that finds the longest");
        Console.WriteLine("  sequence of equal strings in the matrix.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("  {0, 10}", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int maxRow = 0, maxCol = 0, maxSequence = 0;
        string maxDirection = "";


        for (int dirCount = 0; dirCount < 4; dirCount++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSequence = countNeighbours(row, col, direction[dirCount]);

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxRow = row;
                        maxCol = col;
                        maxDirection = direction[dirCount];
                    }
                }
            }            
        }                    

        Console.WriteLine("  The maximum sequence of equal elements is {0} elements long.", maxSequence);
        Console.WriteLine();
        Console.WriteLine("  It starts at row {0}, column {1} and moves in the {2} direction.", maxRow, maxCol, maxDirection);
        Console.WriteLine();
        Console.Write("  The sequence looks like this: ");

        for (int i = 1; i <= maxSequence; i++)
        {
            Console.Write(matrix[maxRow, maxCol]);

            if (i != maxSequence)
            {
                Console.Write(", ");    
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
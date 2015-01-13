using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that finds the largest area of
//     equal neighbor elements in a rectangular matrix and
//     prints its size.

public class Matrix
{
    private int[,] matrix;
    private bool[,] mask;
    private int[,] sizes;
    private int length;
    private int height;
    private int currentSize = 0;
    private int maxRow = 0;
    private int maxCol = 0;
    private int maxSize = 0;   
    
    //getters and setters

    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public int MaxSize
    {
        get { return this.maxSize;  }
        set { this.maxSize = value; }
    }

    //indexer

    public int this[int row, int col]
    {
        get { return matrix[row, col]; }
        set { matrix[row, col] = value; }
    }

    //default constructor

    public Matrix()
    {
        this.matrix = new int[5, 5];
        this.mask = new bool[5, 5];
        this.length = 5;
        this.height = 5;
    }

    //constructor with paramenters

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
        this.mask = new bool[rows, cols];
        this.length = cols;
        this.height = rows;
    }

    //method for print matrix on console

    public void Print()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                if (mask[row, col])
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                Console.Write("  {0}", this.matrix[row, col]);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Green;
    }

    //method that fills an existing matrix with random numbers

    public void Randomize()
    {
        Random randomGenerator = new Random();

        System.Threading.Thread.Sleep(93);

        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                matrix[row, col] = randomGenerator.Next(5);       
                // use larger or smaller numbers here   ^
                // to see varying sizes of max area
                // up to 10 should be cool with current
                // formatting
            }
        }
    }

    //method for clearing the mask

    public void ClearMask()
    {
        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                mask[row, col] = false;
            }
        }
    }

    //recursive method - finds the current area of equal neighbours
    
    public void FindCurrentArea(int row, int col)
    {
        mask[row, col] = true;
        currentSize++;

        if ((row + 1 < Height) && (col + 1 < Length))
        {
            if (matrix[row, col] == matrix[row + 1, col + 1] && !mask[row + 1, col + 1])
            {
                FindCurrentArea(row + 1, col + 1);
            }
        }
        
        if ((row < Height) && (col + 1 < Length))
        {
            if (matrix[row, col] == matrix[row, col + 1] && !mask[row, col + 1])
            {
                FindCurrentArea(row, col + 1);
            }
        }
        
        if ((row - 1 >= 0) && (col + 1 < Length))
        {
            if (matrix[row, col] == matrix[row - 1, col + 1] && !mask[row - 1, col + 1])
            {
                FindCurrentArea(row - 1, col + 1);
            }
        }
        
        if ((row + 1 < Height) && (col < Length))
        {
            if (matrix[row, col] == matrix[row + 1, col] && !mask[row + 1, col])
            {
                FindCurrentArea(row + 1, col);
            }
        }

        if ((row - 1 >= 0) && (col < Length))
        {
            if (matrix[row, col] == matrix[row -1, col] && !mask[row - 1, col])
            {
                FindCurrentArea(row - 1, col);
            }
        }

        if ((row + 1 < Height) && (col - 1 >= 0))
        {
            if (matrix[row, col] == matrix[row + 1, col - 1] && !mask[row + 1, col - 1])
            {
                FindCurrentArea(row + 1, col - 1);
            }
        }

        if ((row < Height) && (col - 1 >= 0))
        {
            if (matrix[row, col] == matrix[row, col - 1] && !mask[row, col - 1])
            {
                FindCurrentArea(row, col - 1);
            }
        }

        if ((row - 1 >= 0) && (col - 1 >= 0))
        {
            if (matrix[row, col] == matrix[row - 1, col - 1] && !mask[row - 1, col - 1])
            {
                FindCurrentArea(row - 1, col - 1);
            }
        }
    }
    
    // method for finding max area of equal neighbours

    public void FindMaxArea()
    {
        for (int row = 0; row < Height; row++)
        {
            for (int col = 0; col < Length; col++)
            {
                FindCurrentArea(row, col);

                if (maxSize < currentSize)
                {
                    maxSize = currentSize;
                    maxRow = row;
                    maxCol = col;                    
                }

                ClearMask();
                currentSize = 0;
            }   
        }

        FindCurrentArea(maxRow, maxCol);
    }
    
}

//class definition ends here, program starts

class MaxAreaOfEqualNeighboursInMatrix
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MaxAreaOfEqualNeighboursInMatrix";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a program that finds the largest area of equal neighbor");
        Console.WriteLine("  elements in a rectangular matrix and prints its size.");
        Console.WriteLine();
        Console.WriteLine();

        Matrix matrix1 = new Matrix(13, 23);
        matrix1.Randomize();
        
        matrix1.FindMaxArea();
        matrix1.Print();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  The largest area with equal neighbours covers a total of {0} cells.", matrix1.MaxSize);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}



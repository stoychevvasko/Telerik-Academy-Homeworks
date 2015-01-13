using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a class Matrix to hold a matrix of integers. 
//     Overload the operators for adding, subtracting and 
//     multiplying of matrices, indexer for accessing the 
//     matrix content and ToString().

public class Matrix 
{
    private int[,] matrix;
    private int length;
    private int height;

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

    //this is the indexer

    public int this[int row, int col]
    {
        get { return matrix[row, col]; }
        set { matrix[row, col] = value; }
    }

    //default constructor

    public Matrix()
    {
        this.matrix = new int[5, 5];
        this.length = 5;
        this.height = 5;
    }

    //constructor with parameters
    
    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
        this.length = cols;
        this.height = rows;
    }

    //method for print matrix on console, now obsolete
    //used it before I overloaded ToString()

    public void Print()
    {
        Console.WriteLine();

        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                Console.Write("  {0, 2}", this.matrix[row, col]);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    //method for matrix input via console

    public void Input()
    {
        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                Console.Write("  element @ [{0},{1}] = ", row, col);

                string keyboardInput = Console.ReadLine();

                while (!int.TryParse(keyboardInput, out matrix[row, col]))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Invalid entry, please try again!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  element @ [{0},{1}] = ", row, col);
                    keyboardInput = Console.ReadLine();
                }
            }

            Console.WriteLine();
        }
    }

    //method for filling an existing matrix with random numbers 0-9

    public void Randomize()
    {
        Random randomGenerator = new Random();

        System.Threading.Thread.Sleep(93);

        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                matrix[row, col] = randomGenerator.Next(10);
            }
        }
    }

    //overloading addition operator +

    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
        Matrix result = new Matrix(matrix1.Height, matrix1.Length);

        for (int row = 0; row < result.Height; row++)
        {
            for (int col = 0; col < result.Length; col++)
            {
                result[row, col] = matrix1[row, col] + matrix2[row, col];
            }
        }

        return result;
    }

    //overloading subtraction operator -

    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        Matrix result = new Matrix(matrix1.Height, matrix1.Length);

        for (int row = 0; row < result.Height; row++)
        {
            for (int col = 0; col < result.Length; col++)
            {
                result[row, col] = matrix1[row, col] - matrix2[row, col];
            }
        }

        return result;
    }

    //overloading multiplication operator *

    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        int resultHeight = (matrix1.Height <= matrix2.Height) ? matrix1.Height : matrix2.Height;
        int resultLength = (matrix1.Length <= matrix2.Length) ? matrix1.Length : matrix2.Length;
        int resultElement;

        Matrix result = new Matrix(resultHeight, resultLength);

        for (int resRow = 0; resRow < resultHeight; resRow++)
        {
            for (int resCol = 0; resCol < resultLength; resCol++)
            {
                resultElement = 0;

                for (int i = 0; i < matrix1.Length; i++)
                {
                    resultElement += matrix1[resRow, i] * matrix2[i, resCol];
                }

                result[resRow, resCol] = resultElement;
            }
        }

        return result;
    }

    //overloading the ToString() method

    public override string ToString()
    {
        string result = string.Empty;

        for (int row = 0; row < this.Height; row++)
        {
            for (int col = 0; col < this.Length; col++)
            {
                if (col < this.Length)
                {
                    result += "  ";
                }

                for (int fillers = 0; fillers < 3 - (this[row, col]).ToString().Length; fillers++)
                {
                    result += " ";
                }

                result += this[row, col].ToString();
            }

            result += "\n\n";
        }

        return result;
    }
}

// end of class declaration, program starts here

class MatrixOverload
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MatrixOverload";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a class Matrix, to holds a matrix of integers.");
        Console.WriteLine("  Overload the operators for adding, subtracting and");
        Console.WriteLine("  multiplying of matrices, indexer for accessing the");
        Console.WriteLine("  matrix content and ToString().");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("  Random matrix1:");
        Console.WriteLine();
        Matrix matrix1 = new Matrix(3, 3);
        matrix1.Randomize();
        Console.WriteLine(matrix1.ToString()); ;

        Console.WriteLine();
        Console.WriteLine("  Random matrix2:");
        Console.WriteLine();
        Matrix matrix2 = new Matrix(3, 3);
        matrix2.Randomize();        
        Console.WriteLine(matrix2.ToString());
        
        Console.WriteLine();
        Console.WriteLine("  matrix1 + matrix2");
        Console.WriteLine();
        Console.WriteLine((matrix1 + matrix2).ToString());
        
        Console.WriteLine();
        Console.WriteLine("  matrix1 - matrix2");
        Console.WriteLine();
        Console.WriteLine((matrix1 - matrix2).ToString());
        
        Console.WriteLine();
        Console.WriteLine("  matrix1 * matrix2");
        Console.WriteLine();

        if ((matrix1.Height != matrix2.Length) || (matrix1.Length != matrix2.Height))
        {
            Console.WriteLine();
            Console.WriteLine("  Multiplication can't take place! Try different matrix sizes.");
        }
        else
        {
            Console.WriteLine((matrix1 * matrix2).ToString());
        }     


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}



using System;


// this is the Telerik Logo problem from Practice "Telerik Academy Exam 1 @ 28 Dec 2012" 

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        int z = (x / 2) + 1;

        int size = 3 * x - 2;

        char[,] array = new char[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                array[i, j] = '.';
            }
        }

        int row = size - 1;
        int col = size / 2;

        array[row, col] = '*';
     
        for (int i = 2; i <= x; i++)
        {
            row--;
            col--;
            array[row, col] = '*';
            array[row, (size - 1) - col] = '*'; 
        }

        for (int i = 2; i <= 2*x -1; i++)
        {
            row--;
            col++;
            array[row, col] = '*';
            array[row, (size - 1) - col] = '*';
        }

        col = size - 1 - col;
       
        for (int i = 1; i < z; i++)
        {
            row++;
            col--;
            array[row, col] = '*';
            array[row, size - 1 - col] = '*';
        }
                
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
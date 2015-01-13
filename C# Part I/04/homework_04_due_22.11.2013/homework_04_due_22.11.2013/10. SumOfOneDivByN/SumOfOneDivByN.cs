using System;
using System.Threading;
using System.Globalization;
using System.Text;

class SumOfOneDivByN
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SumOfOneDivByN.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the sum of this array");
        Console.WriteLine();
        Console.WriteLine("      1 + 1/2 - 1/3 + 1/4 - 1/5 + ... +/- 1/n");
        Console.WriteLine();
        Console.WriteLine("and then print it with accuracy of 0.001.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter how many members of the array there are n = ");
        string keyboardInput = Console.ReadLine();
        uint n;

        while (!uint.TryParse(keyboardInput, out n) || (n < 2))
        {
            Console.WriteLine("Cannot convert to numeric value or n < 2. Try again!");
            Console.WriteLine();
            Console.Write("Please enter how many members of the array there are n = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        decimal sum = 1;
        int denominator;
        
        for (int i = 2; i <= n; ++i)
        {
            denominator = i;
            
            if (i % 2 == 1)
            {
                denominator = denominator * (-1);
            }

            sum = sum + (1.0M / denominator); 
        }

        Console.WriteLine("The sum of the first {0} members of this array is {1:N3}.", n, sum);
        Console.WriteLine();
        Console.WriteLine("The value of the sum with maximum accuracy is {0}.", sum);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
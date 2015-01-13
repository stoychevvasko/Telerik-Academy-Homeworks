using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "FibonacciSum";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the total sum of the first");
        Console.WriteLine("N numbers of the Fibonacci sequence.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter how many numbers there are  N = ");

        int N;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter how many numbers there are  N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        BigInteger[] numbers;
        numbers = new BigInteger[N];

        // assigning Fibonacci values to array and summing them

        BigInteger fibonacciSum = 0;

        for (int i = 0; i < N; i++)
        {
            if (i == 0)
            {
                numbers[i] = 0;
            }
            else if ((i == 1) || (i == 2))
            {
                numbers[i] = 1;
            }
            else 
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }

            fibonacciSum += numbers[i];
        }
        

        // printing final results

        Console.WriteLine();
        Console.WriteLine("The sum is {0}.", fibonacciSum);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
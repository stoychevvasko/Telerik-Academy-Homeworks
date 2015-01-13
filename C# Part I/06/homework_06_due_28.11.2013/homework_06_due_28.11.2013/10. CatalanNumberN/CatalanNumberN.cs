using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Numerics;

class CatalanNumberN
{
    // this method will calculate factorial values

    static public BigInteger CalcFactorial(int num)
    {
        BigInteger factorial = 1;

        for (int i = num; i > 1; i--)
        {
            factorial *= i;
        }

        return factorial;
    }

    // program starts here
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CatalanNumberN";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will print the N-th Catalan number.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter N = ");

        string keyboardInput = Console.ReadLine();
        int N = 0;

        while (!int.TryParse(keyboardInput, out N) || (N < 0))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number!");
            Console.WriteLine();
            Console.Write("N >= 0 Please enter N = ");
            keyboardInput = Console.ReadLine();
        }

        decimal catalanN = (decimal)CalcFactorial(2 * N) 
            / ((decimal)CalcFactorial(N + 1) * (decimal)CalcFactorial(N));


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The N-th Catalan number is {0}.", catalanN);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
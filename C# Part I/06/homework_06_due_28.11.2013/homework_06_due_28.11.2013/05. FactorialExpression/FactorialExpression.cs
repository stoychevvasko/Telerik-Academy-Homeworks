using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Numerics;

class FactorialExpression
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
        Console.Title = "FactorialExpression";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the expression N!*K! / (K-N)!");
        Console.WriteLine("for the values 1 < N < K as provided by the user.");
        Console.WriteLine();
        Console.WriteLine();

        // enter N > 1

        Console.Write("Please enter N = ");
        string keyboardInput = Console.ReadLine();
        int N = 1;

        while ((!int.TryParse(keyboardInput, out N)) || (N <= 1))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid value!");
            Console.WriteLine();
            Console.Write("Please enter N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        // enter K > N

        int K = N;
        Console.Write("Please enter K = ");
        keyboardInput = Console.ReadLine();

        while ((!int.TryParse(keyboardInput, out K)) || (K <= N))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid value!");
            Console.WriteLine();
            Console.Write("Please enter K = ");
            keyboardInput = Console.ReadLine();
        }

        // calculate N!*K! / (K-N)!

        decimal finalResult = ((decimal)CalcFactorial(N) * (decimal)CalcFactorial(K)) / (decimal)CalcFactorial(K - N);

        Console.WriteLine();
        Console.WriteLine("N! = {0}", CalcFactorial(N));
        Console.WriteLine();
        Console.WriteLine("K! = {0}", CalcFactorial(K));
        Console.WriteLine();
        Console.WriteLine("N!*K! / (K-N)! = {0}", finalResult);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}

// program ends here
using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Numerics;

class XNFactorialExpression
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

    // this method will calculate powers

    static public BigInteger CalcPower (int num, int pow)
    {
        BigInteger result = 1;

        for (int i = 1; i <= pow; i++)
			{
			    result *= num;
			}

        return result;
    }


    // program starts here

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "XNFactorialExpression";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the expression");
        Console.WriteLine();
        Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + … + N!/X^N");
        Console.WriteLine();
        Console.WriteLine("for the values N and X as provided by the user.");
        Console.WriteLine();
        Console.WriteLine();

        // enter N

        Console.Write("Please enter N = ");
        string keyboardInput = Console.ReadLine();
        int N = 1;

        while (!int.TryParse(keyboardInput, out N))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid value!");
            Console.WriteLine();
            Console.Write("Please enter N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        // enter X

        int X = 0;
        Console.Write("Please enter X = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out X))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid value!");
            Console.WriteLine();
            Console.Write("Please enter X = ");
            keyboardInput = Console.ReadLine();
        }

        // calculate expression

        decimal finalResult = 1M;
        decimal increment = 0M;

        for (int i = 1; i <= N; i++)
        {
            increment = (decimal)CalcFactorial(i) / (decimal)CalcPower(X, i);
            finalResult += increment;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("S = {0}", finalResult);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}

// program ends here
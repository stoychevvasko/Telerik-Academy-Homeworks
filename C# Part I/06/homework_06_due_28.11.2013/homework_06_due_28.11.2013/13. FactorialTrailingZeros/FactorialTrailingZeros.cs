using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Numerics;

class FactorialTrailingZeros
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
        Console.Title = "FactorialTrailingZeros";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will print out the number of trailing zeros");
        Console.WriteLine("at the end of the factorial of N.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter N = ");

        string keyboardInput = Console.ReadLine();
        int N = 0;

        while (!int.TryParse(keyboardInput, out N) || (N <= 0))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number!");
            Console.WriteLine();
            Console.Write("N >= 0 Please enter N = ");
            keyboardInput = Console.ReadLine();
        }

        BigInteger NFact = CalcFactorial(N);
        
        // counting the smart way using the hint
        
        // the number of zeros at the end of the factorial depends on how many times 10 is a factor in the product:
        // 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10 * 11 * 12 * 13 * 14 * 15 * 16 * 17... etc.
        // 10 is 2 * 5
        // between each factor of 5 (5, 10, 15, 20, etc.) there is at least one even number
        // that can be paired with said 5 to produce a 10
        // this is why we only count the factors of 5 to get the number of trailing zeros of the factorial value
        // if a member is a power of 5 such as 25, 125, 625, etc., we add additional count equaling the number of divisors that
        // fit in N and multiply the divisor by 5 to reach the next power of 5

        int zeroCount = 0;
        int div = 5;

        while (N / div >= 1)
        {
            zeroCount = zeroCount + (N / div);
            div *= 5;
        }


        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("The number of trailing zeros in N! is {0} calculated the smart way.", zeroCount);

        
        
        // counting the barbarous way
        
        zeroCount = 0;

        while (NFact % 10 == 0)
        {
            NFact = NFact / 10;
            ++zeroCount;
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("The number of trailing zeros in N! is {0} calculated the barbarous way.", zeroCount);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;

class ThirdDigitDivisibleBy7IntCheck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ThirdDigitDivisibleBy7IntCheck.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
       

        Console.WriteLine("This application will check if the third digit from the right is 7.");
        Console.WriteLine();
        Console.WriteLine("Please enter an integer:");
        int num;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid integer value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        int thirdDigit = Math.Abs(((num / 100) % 10));
        if (thirdDigit == 7)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The third digit of {0} is 7.", num);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The third digit of {0} is not 7.", num);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
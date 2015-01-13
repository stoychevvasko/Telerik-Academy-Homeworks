using System;
using System.Threading;
using System.Globalization;
using System.Text;

class GreatestOf5
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "GreatestOf5.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will find the greatest of 5 numbers.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Use dot (.) as your decimal mark.");
        Console.WriteLine();
        Console.WriteLine();

        decimal[] num;
        num = new decimal[5];

        Console.Write("Please enter the first number: ");
        string keyboardInput = Console.ReadLine();
        
        while (!decimal.TryParse(keyboardInput, out num[0]))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the first number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the second number: ");
        keyboardInput = Console.ReadLine();
        
        while (!decimal.TryParse(keyboardInput, out num[1]))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the second number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the third number: ");
        keyboardInput = Console.ReadLine();
        
        while (!decimal.TryParse(keyboardInput, out num[2]))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the third number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the fourth number: ");
        keyboardInput = Console.ReadLine();
       
        while (!decimal.TryParse(keyboardInput, out num[3]))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the fourth number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the fifth number: ");
        keyboardInput = Console.ReadLine();
        
        while (!decimal.TryParse(keyboardInput, out num[4]))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the fifth number again: ");
            keyboardInput = Console.ReadLine();
        }

        decimal greatestNum = num [0];

        for (int i = 1; i <= 4; i++)
        {
            if (num[i] > greatestNum)
            {
                greatestNum = num[i];
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The number {0} is the greatest of them all!", greatestNum);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
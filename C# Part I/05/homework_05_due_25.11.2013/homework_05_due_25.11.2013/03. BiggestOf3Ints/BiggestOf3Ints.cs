using System;
using System.Threading;
using System.Globalization;
using System.Text;

class BiggestOf3Ints
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BiggestOf3Ints.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will find the biggest of three integers");
        Console.WriteLine();
        Console.WriteLine("through the use of nested If statements.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter the first number: ");
        string keyboardInput = Console.ReadLine();
        int num1;

        while (!int.TryParse(keyboardInput, out num1))
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
        int num2;

        while (!int.TryParse(keyboardInput, out num2))
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
        int num3;

        while (!int.TryParse(keyboardInput, out num3))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the third number again: ");
            keyboardInput = Console.ReadLine();
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        if (num1 >= num2)
        { 
            if (num2 >= num3)
            {
                Console.WriteLine("The biggest number is {0}.", num1);
            }
            else
            {
                if (num1 >= num3)
                {
                    Console.WriteLine("The biggest number is {0}.", num1);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}.", num3);
                }
            }
        }
        else
        {
            if (num2 >= num3)
            {
                Console.WriteLine("The biggest number is {0}.", num2);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}.", num3);
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;

class SignOfProductOf3Nums
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SignOfProductOf3Nums.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will display the sign (+ or -) of the product of");
        Console.WriteLine();
        Console.WriteLine("three real numbers without calculating it.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please use dot (.) as your decimal mark when entering values.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter the first number: ");
        string keyboardInput = Console.ReadLine();
        decimal num1;

        while (!decimal.TryParse(keyboardInput, out num1))
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
        decimal num2;

        while (!decimal.TryParse(keyboardInput, out num2))
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
        decimal num3;

        while (!decimal.TryParse(keyboardInput, out num3))
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

        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("The product is 0.");
        }
        else if (num1 < 0 && (((num2 < 0) && (num3 < 0)) || ((num2 > 0) && (num3 > 0))))
        {
            Console.WriteLine("The sign of the product is minus (-).");
        }
        else if (num1 < 0 && (((num2 < 0) && (num3 > 0)) || ((num2 > 0) && (num3 < 0))))
        {
            Console.WriteLine("The sign of the product is plus (+).");
        }
        else if (num1 > 0 && (((num2 < 0) && (num3 < 0)) || ((num2 > 0) && (num3 > 0))))
        {
            Console.WriteLine("The sign of the product is plus (+).");
        }
        else if (num1 > 0 && (((num2 < 0) && (num3 > 0)) || ((num2 > 0) && (num3 < 0))))
        {
            Console.WriteLine("The sign of the product is minus (-).");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
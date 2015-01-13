using System;
using System.Threading;
using System.Globalization;
using System.Text;

class NameOfDigit
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NameOfDigit.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will read a digit from the keyboard");
        Console.WriteLine();
        Console.WriteLine("and print out its English pronunciation.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter your digit: ");
        string digit = Console.ReadLine();

        while (digit[0] != '0' && digit[0] != '1' && digit[0] != '2' && digit[0] != '3' && 
            digit[0] != '4' && digit[0] != '5' && digit[0] != '6' && digit[0] != '7' && 
            digit[0] != '8' && digit[0] != '9')
        {
            Console.WriteLine();
            Console.Write("This is not a digit! Please enter a valid digit (0-9): ");
            digit = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        switch (digit[0])
        {
            case '0': Console.WriteLine("You entered {0}: {1}", digit[0], "zero"); break;
            case '1': Console.WriteLine("You entered {0}: {1}", digit[0], "one"); break;
            case '2': Console.WriteLine("You entered {0}: {1}", digit[0], "two"); break;
            case '3': Console.WriteLine("You entered {0}: {1}", digit[0], "three"); break;
            case '4': Console.WriteLine("You entered {0}: {1}", digit[0], "four"); break;
            case '5': Console.WriteLine("You entered {0}: {1}", digit[0], "five"); break;
            case '6': Console.WriteLine("You entered {0}: {1}", digit[0], "six"); break;
            case '7': Console.WriteLine("You entered {0}: {1}", digit[0], "seven"); break;
            case '8': Console.WriteLine("You entered {0}: {1}", digit[0], "eight"); break;
            case '9': Console.WriteLine("You entered {0}: {1}", digit[0], "nine"); break;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
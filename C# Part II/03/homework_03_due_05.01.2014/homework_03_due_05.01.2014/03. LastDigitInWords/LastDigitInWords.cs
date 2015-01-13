using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that returns the last digit of given 
//     integer as an English word. Examples: 512  "two", 
//     1024  "four", 12309  "nine".

class LastDigitInWords
{
    static string LastDigitCaller(int number)
    {
        switch (number % 10)
        {
            case 1: return "one"; break;
            case 2: return "two"; break;
            case 3: return "three"; break;
            case 4: return "four"; break;
            case 5: return "five"; break;
            case 6: return "six"; break;
            case 7: return "seven"; break;
            case 8: return "eight"; break;
            case 9: return "nine"; break;
            case 0: return "zero"; break;
            default: return ""; break;
        }        
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        Console.SetWindowSize(83, 41);
        Console.Title = "LastDigitInWords";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("Please enter your number here: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("The last digit of the number {0} is {1} ({2}).", 
            number, number % 10, LastDigitCaller(number));

        Console.ReadKey();
    }
}



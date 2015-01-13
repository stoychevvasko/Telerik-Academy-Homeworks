using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that reverses the digits of given
//     decimal number. Example: 256 --> 652

class DigitReversal
{
    //     this method reverses the digits of an integer

    static public int ReverseDigits(int sourceNum)
    {
        string numAsText = sourceNum.ToString();
        string resultNumAsText = "";

        for (int i = numAsText.Length - 1; i >= 0; i--)
        {
            resultNumAsText += numAsText[i];
        }

        int result = int.Parse(resultNumAsText);
        return result;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DigitReversal";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("Please enter your number here: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("After digit reversal the number is {0}.", ReverseDigits(number));
        Console.WriteLine();

        Console.ReadKey();
    }
}

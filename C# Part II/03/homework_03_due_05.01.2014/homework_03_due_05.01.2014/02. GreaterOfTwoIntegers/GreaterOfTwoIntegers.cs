using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method GetMax() with two parameters that 
//     returns the bigger of two integers. Write a program 
//     that reads 3 integers from the console and prints the 
//     biggest of them using the method GetMax().

class GreaterOfTwoIntegers
{
    static int GetMax(int numberOne, int numberTwo)
    {
        if (numberOne >= numberTwo)
        {
            return numberOne;
        }
        else
        {
            return numberTwo;
        }
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "GreaterOfTwoIntegers";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0} is the largest number of them all! =)", 
            GetMax(GetMax(firstNumber, secondNumber), thirdNumber));

        Console.ReadKey();
    }
}



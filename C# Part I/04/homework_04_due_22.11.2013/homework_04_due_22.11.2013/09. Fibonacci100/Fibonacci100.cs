using System;
using System.Threading;
using System.Globalization;
using System.Text;

class Fibonacci100
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Fibonacci100.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application prints the first 100 members of the Fibonacci sequence.");
        Console.WriteLine();
        Console.WriteLine();

        
        decimal[] number = new decimal[100];  //the only type I could get to print properly
        number[0] = 1;                        //formatting strings rounded off floats and doubles
        number[1] = 1;                        //even though their respective ranges suffice theoretically
                                              //do let me know if you managed to make it print without decimal type
        for (int i = 2; i <= 99; i++)
        {
            number[i] = number[i - 1] + number[i - 2];
        }

        for (int i = 0; i <= 99; i++)
        {
            Console.WriteLine("Fibonacci member no. {0, 3}.     {1, 22}", i+1, number[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
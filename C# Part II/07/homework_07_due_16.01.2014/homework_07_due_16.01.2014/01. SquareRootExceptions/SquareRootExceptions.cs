using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, 
//print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class SquareRootExceptions
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.Title = "SquareRootExceptions";
        Console.Clear();

        Console.Write("Please enter an integer number for square root: ");
        uint num = 0;
        double sqRoot = 0;

        try
        {
            num = uint.Parse(Console.ReadLine());
            sqRoot = Math.Sqrt(num);
            Console.WriteLine();
            Console.WriteLine("The square root of {0} is {1}.", num, sqRoot);
            Console.WriteLine();

        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number");
            Console.WriteLine();
        }
        catch (System.OverflowException)
        {
            Console.WriteLine();
            Console.WriteLine("Cannot root negative integers.");
            Console.WriteLine();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {

            Console.WriteLine("Good bye");
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}



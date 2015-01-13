using System;
using System.Threading;
using System.Globalization;
using System.Text;

class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "QuadraticEquation.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will solve a quadratic equation of the type");
        Console.WriteLine();
        Console.WriteLine("              a * x * x + b * x + c = 0");
        Console.WriteLine();
        Console.WriteLine("Use dot (.) as your decimal separator.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter the value of a: ");
        double a;
        string keyboardInput = Console.ReadLine();

        while (!double.TryParse(keyboardInput, out a))
        {
            Console.WriteLine();
            Console.Write("Cannot be converted to numeric value. Please try again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Please enter the value of b: ");
        double b;
        keyboardInput = Console.ReadLine();

        while (!double.TryParse(keyboardInput, out b))
        {
            Console.WriteLine();
            Console.Write("Cannot be converted to numeric value. Please try again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Please enter the value of c: ");
        double c;
        keyboardInput = Console.ReadLine();

        while (!double.TryParse(keyboardInput, out c))
        {
            Console.WriteLine();
            Console.Write("Cannot be converted to numeric value. Please try again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        double realRoot1, realRoot2;

        if (a == 0)
        {
            realRoot1 = -c / b;
            Console.WriteLine();
            Console.WriteLine("This equation is linear and has a single real root:");
            Console.WriteLine();
            Console.WriteLine("     x = {0}", realRoot1);
        }
        else
        {
            double determinant = b * b - 4 * a * c;
            if (determinant < 0)
            {
                Console.WriteLine();
                Console.WriteLine("This equation has no real roots.");
            }
            else
            {
                if (determinant == 0)
                {
                    realRoot1 = -b / 2 * a;
                    realRoot2 = realRoot1;
                    Console.WriteLine();
                    Console.WriteLine("This equation has twin real roots:");
                    Console.WriteLine();
                    Console.WriteLine("     x1 = x2 = {0}", realRoot1);
                }
                else
                {
                    realRoot1 = (-b + Math.Sqrt(determinant)) / 2 * a;
                    realRoot2 = (-b - Math.Sqrt(determinant)) / 2 * a;
                    Console.WriteLine();
                    Console.WriteLine("This equation has two real roots:");
                    Console.WriteLine();
                    Console.WriteLine("     x1 = {0}", realRoot1);
                    Console.WriteLine();
                    Console.WriteLine("     x2 = {0}", realRoot2);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
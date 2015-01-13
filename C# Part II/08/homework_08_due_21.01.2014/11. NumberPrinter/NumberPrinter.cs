using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace _11.NumberPrinter
{
    class NumberPrinter
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "NumberPrinter";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your number:");
                    string input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    int num = int.Parse(input);
                    Console.WriteLine();
                    Console.WriteLine("DEC: {0, 15}", num);
                    Console.WriteLine();
                    Console.WriteLine("HEX: {0, 15:X}", num);
                    Console.WriteLine();
                    Console.WriteLine(" % : {0, 15:P}", num);
                    Console.WriteLine();
                    Console.WriteLine("Sci: {0, 15:E}", num);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (System.ArgumentNullException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}

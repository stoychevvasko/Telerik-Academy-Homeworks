using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. Using this method 
//write a program that enters 10 numbers:
//
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class ReadNumberExceptions
{
    public static int ReadNumber(int start, int end, int number)
    {
        try
        {
            Console.WriteLine();
            Console.WriteLine("<!> A new entry <number {0}>:", number);
            Console.Write("Enter an integer between ({0}...{1}): ", start, end);

            int entry = int.Parse(Console.ReadLine());

            if (entry <= start || entry >= end)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            return entry;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range!");
            return ReadNumber(start, end, number);
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Out of int range!");
            return ReadNumber(start, end, number);
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Not an integer! Press any key...");
            Console.ReadKey();
            throw;
        }
        catch (Exception)
        {
            throw;
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(30, 45);
        Console.BufferWidth = Console.WindowWidth = 45;
        Console.Title = "ReadNumberExceptions";
        Console.Clear();


        List<int> ints = new List<int>();
        
        Console.WriteLine("number <{0}>", 1);
        ints.Add(ReadNumber(1, 100, 1));        

        for (int i = 2; i < 11; i++)
        {
            Console.WriteLine();
            Console.WriteLine("number <{0}>", i);
            ints.Add(ReadNumber(ints[i - 2], 100, i));
            
            while (ints[ints.Count - 1] == ints[ints.Count - 2])
            {
                ints[ints.Count - 1] = ReadNumber(ints[ints.Count - 2], 100, i);
            }           

        }

        Console.WriteLine();
        foreach (int num in ints)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
        Console.WriteLine();        
        Console.ReadKey();
    }
}



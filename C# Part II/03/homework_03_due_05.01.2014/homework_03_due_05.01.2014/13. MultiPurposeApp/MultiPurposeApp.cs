using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

//     Write a program that can solve these tasks:
//     (*) Reverses the digits of a number
//     (*) Calculates the average of a sequence of integers
//     (*) Solves a linear equation a * x + b = 0
//     Create appropriate methods.
//     Provide a simple text-based menu for the user to 
//     choose which task to solve.
//     Validate the input data:
//     (*) The decimal number should be non-negative
//     (*) The sequence should not be empty
//     (*) a should not be equal to 0

class MultiPurposeApp
{
    public static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("This application can perform the following tasks for you:");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine();
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine();
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.WriteLine();
        Console.WriteLine("0. Exit");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
        Console.Write("Please type the number of your choice here: ");
    }

    public static bool MainMenu()
    {
        PrintMenu();

        string keyboardInput = Console.ReadLine();
        int choice;

        Console.WriteLine();

        while (!int.TryParse(keyboardInput, out choice))
        {
            Console.WriteLine("Invalid choice! Press any key...");
            Console.ReadKey();

            PrintMenu();

            keyboardInput = Console.ReadLine();
        }

        switch (choice)
        {
            case 0:
            {
                Console.WriteLine();
                Console.WriteLine("Bye now!");
                Console.WriteLine();
                return true;
            }
            case 1:
            {
                ReverseDigits();
                return false;
            }
            case 2:
            {
                AverageInts();
                return false;
            }
            case 3:
            {
                LinearEquation();
                return false;
            }
            default:
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Wrong choice! Press any key...");
                Console.ReadKey();
                return false;
            }            
        }
    }

    static public void ReverseDigits()
    {
        Console.Clear();
        Console.WriteLine("I will now reverse the digits of a non-negative integer for you.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter your number here: ");
        int num;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num) || num < 0)
        {
            Console.WriteLine();

            if (keyboardInput == "")
            {
                Console.Write("Empty strings don't hold numbers. Please enter your number again: ");                
            }
            else if (num < 0)
            {
                Console.Write("Negative numbers are not allowed! Please enter your number again: ");                 
            }             
            else
            {
                Console.Write("Invalid entry! Please enter your number again: ");                 
            }

            keyboardInput = Console.ReadLine();
        }
        
        string resultNumAsText = "";

        for (int i = keyboardInput.Length - 1; i >= 0; i--)
        {
            resultNumAsText += keyboardInput[i];
        }

        int result = int.Parse(resultNumAsText);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Your number was successfully reversed as follows: {0}", result);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static public bool ProperIntSequence(string seq)
    {
        if (seq.Length == 0)
        {
            return false;
        }
        
        bool result = true;
        
        for (int i = 0; i < seq.Length; i++)
        {
            if ((seq[i] < 48 || seq[i] > 57) && seq[i] != 32 && seq[i] != 45)
            {
                result = false;
            }
        }

        return result;
    }

    static public void AverageInts()
    {
        Console.Clear();
        Console.WriteLine("I will now calculate the average of a sequence of integers for you.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please enter a sequence of integers on a single line. Use SPACE as your separator.");
        Console.WriteLine();
        string keyboardInput = Console.ReadLine();

        while (!ProperIntSequence(keyboardInput))
        {
            while (keyboardInput == "")
            {
                Console.WriteLine();
                Console.WriteLine("Empty sequence! Please try again:");
                Console.WriteLine();
                keyboardInput = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Invalid sequence! Please try again:");
            Console.WriteLine();
            keyboardInput = Console.ReadLine();
        }

        double[] nums = keyboardInput.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();
        double result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            result += nums[i];
        }

        result /= nums.Length - 1;
        Console.WriteLine();

        if (nums.Length == 1)
        {
            Console.WriteLine("The average of the number sequence you entered is {0}.", nums[0]);
        }
        else
        {
            Console.WriteLine("The average of the number sequence you entered is {0}.", result);
        }
        
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static public void LinearEquation()
    {
        Console.Clear();
        Console.WriteLine("I will now solve a*x + b = 0 for you.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter a value for a here: ");
        string keyboardInput = Console.ReadLine();
        int a = 0;

        while (!int.TryParse(keyboardInput, out a))
        {
            Console.WriteLine();
            Console.Write("Invalid entry! Please enter another value for a here: ");            
            keyboardInput = Console.ReadLine();
        }

        while (a == 0)
        {
            Console.WriteLine();
            Console.Write("a cannot be zero! Please enter another value for a here: ");            
            keyboardInput = Console.ReadLine();

            while (!int.TryParse(keyboardInput, out a))
            {
                Console.WriteLine();
                Console.Write("Invalid entry! Please enter another value for a here: ");
                keyboardInput = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.Write("Please enter a value for b here: ");
        keyboardInput = Console.ReadLine();
        int b;

        while (!int.TryParse(keyboardInput, out b))
        {
            Console.WriteLine();
            Console.Write("Invalid entry! Please enter a value for b again: ");            
            keyboardInput = Console.ReadLine();
        }

        double result = (double)-b / a;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("x = {0}", result);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();        
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MultiPurposeApp";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        while (!MainMenu())
        {            
        }

        Console.ReadKey();
    }
}



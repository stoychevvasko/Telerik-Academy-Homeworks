using System;
using System.Threading;
using System.Globalization;
using System.Text;

class Sort3RealValues
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Sort3RealValues.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will sort three real values");
        Console.WriteLine();
        Console.WriteLine("in descending order via nested If statements.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter the first number: ");
        string keyboardInput = Console.ReadLine();
        decimal num1;

        while (!decimal.TryParse(keyboardInput, out num1))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the first number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the second number: ");
        keyboardInput = Console.ReadLine();
        decimal num2;

        while (!decimal.TryParse(keyboardInput, out num2))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the second number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the third number: ");
        keyboardInput = Console.ReadLine();
        decimal num3;

        while (!decimal.TryParse(keyboardInput, out num3))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the third number again: ");
            keyboardInput = Console.ReadLine();
        }

        decimal tempNum;

        Console.WriteLine();
        Console.WriteLine();

        if (num1 >= num2)
        {
            if (num2 >= num3)
            {
                // num1 >= num2 >= num3

                Console.WriteLine("The biggest number is {0}.", num1);
                Console.WriteLine("The middle number is {0}.", num2);
                Console.WriteLine("The smallest number is {0}.", num3);
            }
            else
            {
                if (num1 >= num3)
                {
                    // num1 >= num3 >= num2

                    tempNum = num3;
                    num3 = num2;
                    num2 = tempNum;

                    Console.WriteLine("The biggest number is {0}.", num1);
                    Console.WriteLine("The middle number is {0}.", num2);
                    Console.WriteLine("The smallest number is {0}.", num3);
                }
                else
                {
                    // num3 >= num1 >= num2

                    tempNum = num3;
                    num3 = num1;
                    num1 = tempNum;

                    tempNum = num3;
                    num3 = num2;
                    num2 = tempNum;

                    Console.WriteLine("The biggest number is {0}.", num1);
                    Console.WriteLine("The middle number is {0}.", num2);
                    Console.WriteLine("The smallest number is {0}.", num3);
                }
            }
        }
        else
        {
            if (num3 >= num2)
            {
                // num3 >= num2 >= num1

                tempNum = num3;
                num3 = num1;
                num1 = tempNum;

                Console.WriteLine("The biggest number is {0}.", num1);
                Console.WriteLine("The middle number is {0}.", num2);
                Console.WriteLine("The smallest number is {0}.", num3);
            }
            else
            {
                if (num1 >= num3)
                {
                    // num2 >= num1 >= num3

                    tempNum = num2;
                    num2 = num1;
                    num1 = tempNum;

                    Console.WriteLine("The biggest number is {0}.", num1);
                    Console.WriteLine("The middle number is {0}.", num2);
                    Console.WriteLine("The smallest number is {0}.", num3);
                }
                else
                {
                    // num2 >= num3 >= num1

                    tempNum = num3;
                    num3 = num1;
                    num1 = tempNum;

                    tempNum = num2;
                    num2 = num1;
                    num1 = tempNum;

                    Console.WriteLine("The biggest number is {0}.", num1);
                    Console.WriteLine("The middle number is {0}.", num2);
                    Console.WriteLine("The smallest number is {0}.", num3);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
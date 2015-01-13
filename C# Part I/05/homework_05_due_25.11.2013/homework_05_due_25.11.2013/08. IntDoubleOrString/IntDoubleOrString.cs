using System;
using System.Threading;
using System.Globalization;
using System.Text;

class IntDoubleOrString
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IntDoubleOrString.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will allow the user to enter an int,");
        Console.WriteLine();
        Console.WriteLine("double or string variable and then display it accordingly.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter \"int\", \"double\" or \"string\" (no quotes): ");

        string choice = Console.ReadLine();

        while (choice != "int" && choice != "double" && choice != "string")
        {
            Console.WriteLine();
            Console.Write("Invalid choice! Please enter \"int\", \"double\" or \"string\" only!: ");
            choice = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        string varInput;
        
        switch (choice)
        {
            case "int":
            {
                Console.Write("Enter your integer here: ");
                varInput = Console.ReadLine();
                int num;
                
                while (!int.TryParse(varInput, out num))
                {
                    Console.WriteLine();
                    Console.Write("Invalid integer! Please try again: ");
                    varInput = Console.ReadLine();
                }

                ++num;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The final result is int [ {0} ].", num);
                break;
            }
            case "double": 
            {
                Console.Write("Enter your double here: ");
                varInput = Console.ReadLine();
                double dnum;
                
                while (!double.TryParse(varInput, out dnum))
                {
                    Console.WriteLine();
                    Console.Write("Invalid double! Please try again: ");
                    varInput = Console.ReadLine();
                }

                ++dnum;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The final result is double [ {0} ].", dnum);
                break;

            }
            case "string":
            {
                Console.Write("Enter your string here: ");
                varInput = Console.ReadLine();
                
                varInput = varInput + "*";
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The final result is string [ {0} ].", varInput);
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
using System;
using System.Threading;
using System.Globalization;

class EmployeeRecords
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "EmployeeRecords";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("   Welcome to FakeCompany Inc. HR Registrar.");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Enter the employee's first name:");        
        string firstName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the employee's surname:");
        string surname = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the employee's age:");
        byte age;
        string keyboardInput = Console.ReadLine();
        while (!byte.TryParse(keyboardInput, out age))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value.");
            Console.WriteLine();
            Console.WriteLine("Please enter employee age again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Enter the employee's sex (M/F):");
        keyboardInput = Console.ReadLine();
        while ((keyboardInput[0] != 'M') & (keyboardInput[0] != 'm') & (keyboardInput[0] != 'F') & (keyboardInput[0] != 'f'))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered invalid sex. Please use F for female or M for male:");
            keyboardInput = Console.ReadLine();
        }
        bool isMale;
        if ((keyboardInput[0] != 'M') | (keyboardInput[0] != 'm'))
        {
            isMale = true;
        }
        else
        {
            isMale = false;
        }

        Console.WriteLine();
        Console.WriteLine("Enter the employee's ID card number:");
        uint idNum;
        keyboardInput = Console.ReadLine();
        while (!uint.TryParse(keyboardInput, out idNum))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value.");
            Console.WriteLine();
            Console.WriteLine("Please enter employee's ID card number again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Enter the employee's unique identification number:");
        uint employeeIDNum;
        keyboardInput = Console.ReadLine();
        while (!uint.TryParse(keyboardInput, out employeeIDNum))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value.");
            Console.WriteLine();
            Console.WriteLine("Please enter employee's unique identification number again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Processing");
        System.Threading.Thread.Sleep(500);
        Console.Write(".");
        System.Threading.Thread.Sleep(500);
        Console.Write(".");
        System.Threading.Thread.Sleep(500);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("   This is how the employee record was saved:");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\tName: [ {0} ] as string", firstName);
        Console.WriteLine();
        Console.WriteLine("\tSurname: [ {0} ] as string", surname);
        Console.WriteLine();
        Console.WriteLine("\tAge: [ {0} ] as byte", age);
        Console.WriteLine();
        Console.WriteLine("\tisMale: [ {0} ] as bool", isMale);
        Console.WriteLine();
        Console.WriteLine("\tEmployee ID card number: [ {0} ] as uint", idNum);
        Console.WriteLine();
        Console.WriteLine("\tEmployee unique identifier: [ {0} ] as uint.", employeeIDNum);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thank you for using our system!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
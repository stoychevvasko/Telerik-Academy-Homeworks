using System;
using System.Threading;
using System.Globalization;

class BankAccountRecords
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BankAccountRecords";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("   Welcome to FakeBank Inc. bank account entry.");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Enter the holder's first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the holder's middle name:");
        string middleName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the holder's surname:");
        string surname = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the current balance in EUR. Use dot (.) as your decimal mark:");
        decimal balance;
        string keyboardInput = Console.ReadLine();
        while (!decimal.TryParse(keyboardInput, out balance))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value.");
            Console.WriteLine();
            Console.WriteLine("Please enter balance again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Enter the the name of the holder's banking institution:");
        string bankName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the IBAN:");                      //Strings containing both letters and numbers
        string iBAN = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the BIC code:");                  //Strings containing both letters and numbers
        string bIC = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the first credit card:");         //CC numbers are unique identifiers - not meant for manipulation, must be faithfully represented.
        string creditCardOne = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the second credit card:");
        string creditCardTwo = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter the third credit card:");
        string creditCardThree = Console.ReadLine();


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
        Console.WriteLine("   This is how the bank record was saved:");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\tFirst name: [ {0} ] as string", firstName);
        Console.WriteLine();
        Console.WriteLine("\tMiddle name: [ {0} ] as string", middleName);
        Console.WriteLine();
        Console.WriteLine("\tSurname: [ {0} ] as string", surname);
        Console.WriteLine();
        Console.WriteLine("\tBalance [ {0} ] as decimal", balance);
        Console.WriteLine();
        Console.WriteLine("\tBanking institution name: [ {0} ] as string", bankName);
        Console.WriteLine();
        Console.WriteLine("\tIBAN: [ {0} ] as string", iBAN);
        Console.WriteLine();
        Console.WriteLine("\tBIC [ {0} ] as string", bIC);
        Console.WriteLine();
        Console.WriteLine("\tFirst credit card: [ {0} ] as string", creditCardOne);
        Console.WriteLine();
        Console.WriteLine("\tSecond credit card: [ {0} ] as string", creditCardTwo);
        Console.WriteLine();
        Console.WriteLine("\tThird credit card: [ {0} ] as string", creditCardThree);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("That will be $5, please!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;

class SubsetZeroSumCheck
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SubsetZeroSumCheck.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will check if any subset within the set of");
        Console.WriteLine();
        Console.WriteLine("5 integers provided by the user results in a zero sum.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter the first number: ");
        string keyboardInput = Console.ReadLine();
        int num1;

        while (!int.TryParse(keyboardInput, out num1))
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
        int num2;

        while (!int.TryParse(keyboardInput, out num2))
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
        int num3;

        while (!int.TryParse(keyboardInput, out num3))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the third number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the fourth number: ");
        keyboardInput = Console.ReadLine();
        int num4;

        while (!int.TryParse(keyboardInput, out num4))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the fourth number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the fifth number: ");
        keyboardInput = Console.ReadLine();
        int num5;

        while (!int.TryParse(keyboardInput, out num5))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the fifth number again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        bool zeroSumCheck;

        // a total of 26 unique combinations are possible

        if (num1 + num2 + num3 + num4 + num5 == 0)          
        {               
            zeroSumCheck = true;                            // combination between all 5 elements
        }
        else if ( (num2 + num3 + num4 + num5 == 0) || (num1 + num3 + num4 + num5 == 0) || 
            (num1 + num2 + num4 + num5 == 0) || (num1 + num2 + num3 + num5 == 0) || 
            (num1 + num2 + num3 + num4 == 0) )               
        {                                                   
            zeroSumCheck = true;                            // combinations between 4 elements
        }
        else if ( (num1 + num2 + num3 == 0) || (num1 + num2 + num4 == 0) || (num1 + num2 + num5 == 0) ||
            (num1 + num3 + num4 == 0) || (num1 + num3 + num5 == 0) || (num1 + num4 + num5 == 0) || 
            (num2 + num3 + num4 == 0) || (num2 + num3 + num5 == 0) || (num2 + num4 + num5 == 0) ||
            (num3 + num4 + num5 == 0) )
        {                                                   
            zeroSumCheck = true;                            // combinations between 3 elements
        }
        else if ( (num1 + num2 == 0) || (num1 + num3 == 0) || (num1 + num4 == 0) || (num1 + num5 == 0) || 
            (num2 + num3 == 0) || (num2 + num4 == 0) || (num2 + num5 == 0) || (num3 + num4== 0) ||
            (num3 + num5 == 0) || (num4 + num5 == 0) )
        {                                                   
            zeroSumCheck = true;                            // combinations between 2 elements
        }
        else
        {
            zeroSumCheck = false;                           // all possible combinations are exhausted
        }                                                   // with no zero sum found


        if (zeroSumCheck)
        {
            Console.WriteLine("There is at least one combination between the integers");
            Console.WriteLine("you entered that would result in a zero sum.");
        }
        else
        {
            Console.WriteLine("There are no combinations between the integers");
            Console.WriteLine("you entered that would result in a zero sum.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
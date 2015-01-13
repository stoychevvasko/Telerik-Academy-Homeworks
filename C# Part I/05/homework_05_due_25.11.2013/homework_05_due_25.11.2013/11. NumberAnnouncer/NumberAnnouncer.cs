using System;
using System.Threading;
using System.Globalization;
using System.Text;

class NumberAnnouncer
{
    // this method returns string numerals corresponding to a uint value
    
    public static string NumeralFromUint (uint num)
    {
        string numWords = null;


        if (num / 100 != 0)         // for numbers with hundreds
        {
            switch (num / 100)
            {
                case 1: numWords = "one hundred"; break;
                case 2: numWords = "two hundred"; break;
                case 3: numWords = "three hundred"; break;
                case 4: numWords = "four hundred"; break;
                case 5: numWords = "five hundred"; break;
                case 6: numWords = "six hundred"; break;
                case 7: numWords = "seven hundred"; break;
                case 8: numWords = "eight hundred"; break;
                case 9: numWords = "nine hundred"; break;
            }

            if (num % 100 < 20)         // for 101-119, 201-219, 301-319, etc.
            {
                switch (num % 100)
                {
                    case 1: numWords = numWords + " and one"; break;
                    case 2: numWords = numWords + " and two"; break;
                    case 3: numWords = numWords + " and three"; break;
                    case 4: numWords = numWords + " and four"; break;
                    case 5: numWords = numWords + " and five"; break;
                    case 6: numWords = numWords + " and six"; break;
                    case 7: numWords = numWords + " and seven"; break;
                    case 8: numWords = numWords + " and eight"; break;
                    case 9: numWords = numWords + " and nine"; break;
                    case 10: numWords = numWords + " and ten"; break;
                    case 11: numWords = numWords + " and eleven"; break;
                    case 12: numWords = numWords + " and twelve"; break;
                    case 13: numWords = numWords + " and thirteen"; break;
                    case 14: numWords = numWords + " and fourteen"; break;
                    case 15: numWords = numWords + " and fifteen"; break;
                    case 16: numWords = numWords + " and sixteen"; break;
                    case 17: numWords = numWords + " and seventeen"; break;
                    case 18: numWords = numWords + " and eighteen"; break;
                    case 19: numWords = numWords + " and nineteen"; break;
                }
            }
            else                        // for 120-199, 220-299, 320-399, etc.
            {
                switch ((num % 100) / 10)
                {
                    case 2: numWords = numWords + " and twenty"; break;
                    case 3: numWords = numWords + " and thirty"; break;
                    case 4: numWords = numWords + " and forty"; break;
                    case 5: numWords = numWords + " and fifty"; break;
                    case 6: numWords = numWords + " and sixty"; break;
                    case 7: numWords = numWords + " and seventy"; break;
                    case 8: numWords = numWords + " and eighty"; break;
                    case 9: numWords = numWords + " and ninety"; break;
                }

                switch (num % 10)
                {
                    case 1: numWords = numWords + "-one"; break;
                    case 2: numWords = numWords + "-two"; break;
                    case 3: numWords = numWords + "-three"; break;
                    case 4: numWords = numWords + "-four"; break;
                    case 5: numWords = numWords + "-five"; break;
                    case 6: numWords = numWords + "-six"; break;
                    case 7: numWords = numWords + "-seven"; break;
                    case 8: numWords = numWords + "-eight"; break;
                    case 9: numWords = numWords + "-nine"; break;
                }
            }
        }
        else                    // for numbers without hundreds
        {
            if (num < 20)       // for 0-19
            {
                switch (num)
                {
                    case 0: numWords = numWords + "zero"; break;
                    case 1: numWords = numWords + "one"; break;
                    case 2: numWords = numWords + "two"; break;
                    case 3: numWords = numWords + "three"; break;
                    case 4: numWords = numWords + "four"; break;
                    case 5: numWords = numWords + "five"; break;
                    case 6: numWords = numWords + "six"; break;
                    case 7: numWords = numWords + "seven"; break;
                    case 8: numWords = numWords + "eight"; break;
                    case 9: numWords = numWords + "nine"; break;
                    case 10: numWords = numWords + "ten"; break;
                    case 11: numWords = numWords + "eleven"; break;
                    case 12: numWords = numWords + "twelve"; break;
                    case 13: numWords = numWords + "thirteen"; break;
                    case 14: numWords = numWords + "fourteen"; break;
                    case 15: numWords = numWords + "fifteen"; break;
                    case 16: numWords = numWords + "sixteen"; break;
                    case 17: numWords = numWords + "seventeen"; break;
                    case 18: numWords = numWords + "eighteen"; break;
                    case 19: numWords = numWords + "nineteen"; break;
                }
            }
            else                // for 20-99
            {
                switch (num / 10)
                {
                    case 2: numWords = "twenty"; break;
                    case 3: numWords = "thirty"; break;
                    case 4: numWords = "forty"; break;
                    case 5: numWords = "fifty"; break;
                    case 6: numWords = "sixty"; break;
                    case 7: numWords = "seventy"; break;
                    case 8: numWords = "eighty"; break;
                    case 9: numWords = "ninety"; break;
                }

                switch (num % 10)
                {
                    case 1: numWords = numWords + "-one"; break;
                    case 2: numWords = numWords + "-two"; break;
                    case 3: numWords = numWords + "-three"; break;
                    case 4: numWords = numWords + "-four"; break;
                    case 5: numWords = numWords + "-five"; break;
                    case 6: numWords = numWords + "-six"; break;
                    case 7: numWords = numWords + "-seven"; break;
                    case 8: numWords = numWords + "-eight"; break;
                    case 9: numWords = numWords + "-nine"; break;
                }
            }
        }

        return numWords;        // returns the completed string value with numerals
    }                           // at the location where the method is called

    //end of NumeralFromUint(uint) method



    // program starts here

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NumberAnnouncer.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("Why, hello there! I am your friendly number announcer!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter a number from 0 to 999: ");
        Console.ForegroundColor = ConsoleColor.Green;
        uint inputNum = 0;
        string keyboardInput = Console.ReadLine();

        while (!uint.TryParse(keyboardInput, out inputNum) || (inputNum > 999))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, cannot convert to numeric value or value is out of range.");
            Console.WriteLine();
            Console.Write("Please enter a number from 0 to 999: ");
            Console.ForegroundColor = ConsoleColor.Green;
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This number is {0}.", NumeralFromUint(inputNum));
                                                            // calling the method I previously defined

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I'm just glad to have been of service! Come back anytime ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=)");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
    // end of program
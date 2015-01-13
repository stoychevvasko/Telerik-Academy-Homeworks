using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     * Write a program that shows the internal binary 
//     representation of given 32-bit signed floating-point 
//     number in IEEE 754 format (the C# type float). 
//     Example: -27,25 --> sign = 1, exponent = 10000011, 
//     mantissa = 10110100000000000000000.

class FloatBinaryRepresentation
{
    static public string ConvertHexToBin(string num)
    {
        string hexDigits = "0123456789ABCDEF";
        string resultString = "";

        for (int i = 0; i < num.Length; i++)
        {
            resultString += Convert.ToString(hexDigits.IndexOf(num[i]), 2);
        }

        //to make sure that results are always 4-characters long we add leading zeros if necessary

        while (resultString.Length < 4)
        {
            resultString = "0" + resultString;
        }

        return resultString;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "FloatBinaryRepresentation";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter your number here as float type:");
        string input = Console.ReadLine();
        float num = Single.Parse(input);

        byte[] bytes = BitConverter.GetBytes(num);
        Array.Reverse(bytes);

        string hexRepresentation = BitConverter.ToString(bytes);

        //since BitConverter.ToString concatenates the hexadecimal bytes with a dash ('-') separator
        //we've got to do this little clean-up here
        hexRepresentation = hexRepresentation.Replace("-", "");

        string binRepresentation = "";
               
        for (int i = 0; i < hexRepresentation.Length; i++)
        {
            binRepresentation += ConvertHexToBin(hexRepresentation.Substring(i, 1));
        }

        Console.WriteLine();
        Console.WriteLine("This is the binary representation of the float number you entered:");
        Console.WriteLine();
        Console.WriteLine("Sign:     {0}", binRepresentation.Substring(0, 1));
        Console.WriteLine("Exponent: {0}", binRepresentation.Substring(1, 8));
        Console.WriteLine("Mantissa: {0}", binRepresentation.Substring(9, 23));

        Console.WriteLine();
        Console.ReadKey();
    }
}
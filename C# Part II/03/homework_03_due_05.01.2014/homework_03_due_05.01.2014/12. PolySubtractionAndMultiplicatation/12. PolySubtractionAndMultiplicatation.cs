using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Extend the program to support also subtraction and 
//     multiplication of polynomials.

class PolySubtractionAndMultiplicatation
{
    // the collapsed methods are copied from task 11 without changes
    
    public static int[] PolyAddition(int[] polyOne, int[] polyTwo)
    {
        if (polyOne.Length >= polyTwo.Length)
        {
            int[] result = new int[polyOne.Length];

            for (int i = 0; i < polyTwo.Length; i++)
            {
                result[i] = polyOne[i] + polyTwo[i];
            }

            for (int i = polyTwo.Length; i < polyOne.Length; i++)
            {
                result[i] = polyOne[i];
            }

            return result;
        }
        else
        {
            int[] result = new int[polyTwo.Length];

            for (int i = 0; i < polyOne.Length; i++)
            {
                result[i] = polyOne[i] + polyTwo[i];
            }

            for (int i = polyOne.Length; i < polyTwo.Length; i++)
            {
                result[i] = polyTwo[i];
            }

            return result;
        }
    }
    
    public static int[] PolySubtraction(int[] polyOne, int[] polyTwo)
    {
        if (polyOne.Length >= polyTwo.Length)
        {
            int[] result = new int[polyOne.Length];

            for (int i = 0; i < polyTwo.Length; i++)
            {
                result[i] = polyOne[i] - polyTwo[i];
            }

            for (int i = polyTwo.Length; i < polyOne.Length; i++)
            {
                result[i] = polyOne[i];
            }

            return result;
        }
        else
        {
            int[] result = new int[polyTwo.Length];

            for (int i = 0; i < polyOne.Length; i++)
            {
                result[i] = polyOne[i] - polyTwo[i];
            }

            for (int i = polyOne.Length; i < polyTwo.Length; i++)
            {
                result[i] = polyTwo[i];
            }

            return result;
        }
    }

    public static int[] MultiplyPolynomialByMonomial(int[] poly, int monoPow, int monoQuotient)
    {
        int resultMaxPower = poly.Length - 1 + monoPow;
        int[] result = new int[resultMaxPower + 1];

        for (int i = 0; i < poly.Length; i++)
        {
            result[monoPow + i] = monoQuotient * poly[i];
        }

        return result;
    }

    public static int[] PolyMultiplication(int[] poly, int[] factor)
    {
        int[] finalResult = new int[poly.Length - 1 + factor.Length - 1];

        for (int i = 0; i < factor.Length; i++)
        {
            int[] result = MultiplyPolynomialByMonomial(poly, i, factor[i]);
            finalResult = PolyAddition(result, finalResult);
        }

        return finalResult;
    }

    public static string PolyString(int[] poly)
    {
        string result = "";

        for (int i = 0; i < poly.Length; i++)
        {
            if (i == 0)
            {
                if (poly[i] > 0)
                {
                    result += " + " + poly[i];
                }
                else if (poly[i] < 0)
                {
                    result += " - " + (-(poly[i]));
                }
            }
            else if (i == 1)
            {
                if (poly[i] > 0)
                {
                    if (poly[i] == 1)
                    {
                        result = " + x" + result;
                    }
                    else
                    {
                        result = " + " + poly[i] + "*x" + result;
                    }
                }
                else if (poly[i] < 0)
                {
                    if (poly[i] == -1)
                    {
                        result = " - x" + result;
                    }
                    else
                    {
                        result = " - " + (-1 * (poly[i])) + "*x" + result;
                    }
                }
            }
            else
            {
                if (poly[i] > 0)
                {
                    if (poly[i] == 1)
                    {
                        result = " + x^" + i + result;
                    }
                    else
                    {
                        result = " + " + poly[i] + "*x^" + i + result;
                    }
                }
                else if (poly[i] < 0)
                {
                    if (poly[i] == -1)
                    {
                        result = " - x^" + i + result;
                    }
                    else
                    {
                        result = " - " + (-1 * (poly[i])) + "*x^" + i + result;
                    }
                }
            }
        }

        if (result.Length != 0)
        {
            if (result[1] == '+')
            {
                result = result.Remove(0, 3);
            }

            if (result[1] == '-')
            {
                result = result.Remove(0, 1);
            }
        }

        if (result == "")
        {
            return "0";
        }
        else
        {
            return result;
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "12. PolySubtractionAndMultiplicatation";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("What is the highest power of your first polynomial? ");
        int polyOneMaxPower = int.Parse(Console.ReadLine());


        int[] polyOne = new int[polyOneMaxPower + 1];

        Console.WriteLine();

        for (int i = 0; i <= polyOneMaxPower; i++)
        {
            Console.Write("Quotient for x^{0} of the first polynomial: ", i);
            polyOne[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(PolyString(polyOne));

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("What is the highest power of your second polynomial? ");
        int polyTwoMaxPower = int.Parse(Console.ReadLine());


        int[] polyTwo = new int[polyTwoMaxPower + 1];

        Console.WriteLine();

        for (int i = 0; i <= polyTwoMaxPower; i++)
        {
            Console.Write("Quotient for x^{0} of the second polynomial: ", i);
            polyTwo[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(PolyString(polyTwo));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Here are the resulting polynomials:");

        Console.WriteLine();
        Console.WriteLine("Addition:");
        int[] result = PolyAddition(polyOne, polyTwo);
        Console.WriteLine(PolyString(result));

        Console.WriteLine();
        Console.WriteLine("Subtraction:");
        result = PolySubtraction(polyOne, polyTwo);
        Console.WriteLine(PolyString(result));

        Console.WriteLine();
        Console.WriteLine("Multiplication:");
        result = PolyMultiplication(polyOne, polyTwo);
        Console.WriteLine(PolyString(result));

        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}



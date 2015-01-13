using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

//     * Modify your last program and try to make it work 
//     for any number type, not just integer (e.g. decimal, 
//     float, byte, etc.). Use generic method (read in 
//     Internet about generic methods in C#).

class GenericMethods
{
    static public T MyMinimum<T>(params T[] nums)
    {
        dynamic min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }

        return min;
    }

    static public T MyMaximum<T>(params T[] nums)
    {
        dynamic max = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
            {
                max = nums[i];
            }
        }

        return max;
    }

    static public T MyAverage<T>(params T[] nums)
    {
        dynamic sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        dynamic result = sum / (nums.Length - 1);

        return result;
    }

    static public T MySum<T>(params T[] nums)
    {
        dynamic sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    static public T MyProduct<T>(params T[] nums)
    {
        dynamic product = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }

        return product;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "GenericMethods";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        
        Console.WriteLine("Integers:");
        Console.WriteLine("{ 15, -10, 5, 25, -15, 2, 10, 9 }");
        int[] ints = { 15, -10, 5, 25, -15, 2, 10, 9 };
        Console.WriteLine();

        Console.WriteLine("Min {0}", MyMinimum(ints));
        Console.WriteLine("Max {0}", MyMaximum(ints));
        Console.WriteLine("Avg {0}", MyAverage(ints));
        Console.WriteLine("Sum {0}", MySum(ints));
        Console.WriteLine("Prd {0}", MyProduct(ints));
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Floats:");
        Console.WriteLine("{ 15, -10, 5, 25, -15, 2, 10, 9 }");
        float[] floats = { 15.0f, -10.0f, 5.0f, 25.0f, -15.0f, 2.0f, 10.0f, 9.0f };
        Console.WriteLine();

        Console.WriteLine("Min {0}", MyMinimum(floats));
        Console.WriteLine("Max {0}", MyMaximum(floats));
        Console.WriteLine("Avg {0}", MyAverage(floats));
        Console.WriteLine("Sum {0}", MySum(floats));
        Console.WriteLine("Prd {0}", MyProduct(floats));
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Doubles:");
        Console.WriteLine("{ 15, -10, 5, 25, -15, 2, 10, 9 }");
        double[] doubles = { 15.0d, -10.0d, 5.0d, 25.0d, -15.0d, 2.0d, 10.0d, 9.0d };
        Console.WriteLine();

        Console.WriteLine("Min {0}", MyMinimum(doubles));
        Console.WriteLine("Max {0}", MyMaximum(doubles));
        Console.WriteLine("Avg {0}", MyAverage(doubles));
        Console.WriteLine("Sum {0}", MySum(doubles));
        Console.WriteLine("Prd {0}", MyProduct(doubles));
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Decimals:");
        Console.WriteLine("{ 15, -10, 5, 25, -15, 2, 10, 9 }");
        decimal[] decimals = { 15.0M, -10.0M, 5.0M, 25.0M, -15.0M, 2.0M, 10.0M, 9.0M };
        Console.WriteLine();

        Console.WriteLine("Min {0}", MyMinimum(decimals));
        Console.WriteLine("Max {0}", MyMaximum(decimals));
        Console.WriteLine("Avg {0}", MyAverage(decimals));
        Console.WriteLine("Sum {0}", MySum(decimals));
        Console.WriteLine("Prd {0}", MyProduct(decimals));
        Console.WriteLine();
        Console.WriteLine();

        Console.ReadKey();
    }
}



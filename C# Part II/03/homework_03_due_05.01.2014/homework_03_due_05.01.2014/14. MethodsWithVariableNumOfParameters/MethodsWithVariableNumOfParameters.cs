using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write methods to calculate minimum, maximum, 
//     average, sum and product of given set of integer 
//     numbers. Use variable number of arguments.

class MethodsWithVariableNumOfParameters
{  
    static public int MyMinimum(params int[] nums)
    {
        int min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }

        return min;
    }

    static public int MyMaximum(params int[] nums)
    {
        int max = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
            {
                max = nums[i];
            }
        }

        return max;
    }

    static public double MyAverage(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        double result = (double)sum / (nums.Length - 1);

        return result;
    }

    static public int MySum(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    static public int MyProduct(params int[] nums)
    {
        int product = 1;

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
        Console.Title = "MethodsWithVariableNumOfParameters";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("{ 15, -10, 5, 25, -15, 2, 10, 9 }");
        int[] nums = { 15, -10, 5, 25, -15, 2, 10, 9 };
        Console.WriteLine();

        Console.WriteLine("Min " + MyMinimum(nums));
        Console.WriteLine("Max " + MyMaximum(nums));
        Console.WriteLine("Avg " + MyAverage(nums));
        Console.WriteLine("Sum " + MySum(nums));
        Console.WriteLine("Prd " + MyProduct(nums));
        Console.WriteLine();

        Console.ReadKey();
    }
}



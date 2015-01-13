using System;
using System.Threading;
using System.Globalization;
using System.Text;

class MinMaxOfNNums
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MinMaxOfNNums";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will print the minimum and maximum");
        Console.WriteLine("numbers from a total of N numbers as provided by the user.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter how many numbers there are  N = ");

        int N;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter how many numbers there are  N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] numbers;
        numbers = new int[N];

        // number entry
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine();
            Console.Write("Please enter number {0}: ", i + 1);
            keyboardInput = Console.ReadLine();

            while (!int.TryParse(keyboardInput, out numbers[i]))
            {
                Console.WriteLine();
                Console.WriteLine("Cannot be converted to numeric value!");
                Console.WriteLine();
                Console.Write("Please enter number {0}: ", i + 1);
                keyboardInput = Console.ReadLine();
            }

        }

        // finding min and max numbers

        int min = numbers[0], max = numbers[0];

        for (int i = 0; i < N; i++)
        {

            if (min > numbers[i])
            {
                min = numbers[i];
            }

            if (max < numbers[i])
            {
                max = numbers[i];
            }

        }

        // printing final results

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The minimum number is {0}.", min);
        Console.WriteLine();
        Console.WriteLine("The maximum number is {0}.", max);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
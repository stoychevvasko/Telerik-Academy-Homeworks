using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program, that reads from the console an 
//     array of N integers and an integer K, sorts the array    
//     and using the method Array.BinSearch() finds 
//     the largest number in the array which is ≤ K. 


class ArrayOfNIntsFindLargestBelowK
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ArrayOfNIntsFindLargestBelowK";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program, that reads from the console an ");
        Console.WriteLine("  array of N integers and an integer K, sorts the array");
        Console.WriteLine("  and using the method Array.BinSearch() finds");
        Console.WriteLine("  the largest number in the array which is ≤ K.");
        Console.WriteLine();
        Console.WriteLine();


        int N = 0;
        Console.Write("  What is the length of the array? N = ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N) || (N == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array length, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the length of the array? N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("  array[{0}] = ", i);
            keyboardInput = Console.ReadLine();

            while (!int.TryParse(keyboardInput, out array[i]))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Cannot be converted to a valid numeric value, please try again!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  array[{0}] = ", i);
                keyboardInput = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        int K;
        Console.Write("  What enter an integer value K = ");
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out K))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid integer, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What enter an integer value K = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        
        Array.Sort(array);

        Console.WriteLine("  This is the array after sorting:");
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("  array[{0}] = {1}", i, array[i]);
        }

        Console.WriteLine();
        Console.WriteLine();

        int binSearchResult = Array.BinarySearch(array, K);
        
        if (binSearchResult < 0)
        {
            if (K < array[0])
            {
                Console.WriteLine("  {0} cannot be found in the array and all array values are larger than {0}!", K);
            }
            else if (K > array[array.Length - 1])
            {
                Console.WriteLine("  {0} cannot be found in the array.", K);
                Console.WriteLine("  The largest number ≤ {0} is array[{1}] = {2}.", K, array.Length - 1, array[array.Length - 1]);                
            }
            else
            {
                int index = -binSearchResult - 2;

                if (index < 0)
                {
                    index = 0;
                }
                
                Console.WriteLine("  {0} cannot be found in the array.", K);
                Console.WriteLine("  The largest number ≤ {0} is array[{1}] = {2}.", K, index, array[index]);     
            }
        }
        else if (binSearchResult >= 0)
        {
            Console.WriteLine("  K was found as array[{0}] = {1}.", binSearchResult, array[binSearchResult]);
        }
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}



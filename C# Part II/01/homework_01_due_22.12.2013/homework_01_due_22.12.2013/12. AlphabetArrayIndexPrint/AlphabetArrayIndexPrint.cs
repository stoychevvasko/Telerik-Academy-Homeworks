using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that creates an array containing all 
//     letters from the alphabet (A-Z). Read a word from 
//     the console and print the index of each of its letters 
//     in the array.

class AlphabetArrayIndexPrint
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "AlphabetArrayIndexPrint";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("  Write a program that creates an array containing all ");
        Console.WriteLine("  letters from the alphabet (A-Z). Read a word from ");
        Console.WriteLine("  the console and print the index of each of its letters ");
        Console.WriteLine("  in the array.");
        Console.WriteLine();
        Console.WriteLine();

        char[] letters = new char[]{'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 
            'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 
            'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 
            'Y', 'y', 'Z', 'z'};

        Console.Write("  Please enter your word here: ");

        string keyboardInput = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();

        bool found;

        for (int i = 0; i < keyboardInput.Length; i++)
        {
            found = false;

            for (int j = 0; j < 52; j++)
            {
                if(keyboardInput[i] == letters[j])
                {
                    Console.WriteLine("  letter <{0}> --> index {1, 2}", keyboardInput[i], j);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("  letter <{0}> --> not found", keyboardInput[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     You are given an array of strings. Write a method
//     that sorts the array by the length of its elements
//     (the number of characters composing them).

class SortStringArrayByLength
{
    static void SortStringByLength(string[] strings)
    {
        int pointer = -1;

        while (true)
        {
            bool isSorted = true;

            for (int i = 0; i < strings.Length - 1; i++)
            {
                if (strings[i].Length > strings[i + 1].Length)
                {
                    isSorted = false;
                }
            }

            if (isSorted)
            {
                return;
            }

            pointer++;

            if (pointer >= strings.Length)
            {
                return;
            }

            string tempString;
            int minLength = strings[pointer].Length, minIndex = pointer;

            for (int i = pointer; i <= strings.Length - 1; i++) 
            {
                if (strings[i].Length < minLength)
                {
                    minLength = strings[i].Length;
                    minIndex = i;
                }
            }

            tempString = strings[minIndex];
            strings[minIndex] = strings[pointer];
            strings[pointer] = tempString;
        }
    }


    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SortStringArrayByLength";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  You are given an array of strings. Write a method");
        Console.WriteLine("  that sorts the array by the length of its elements");
        Console.WriteLine("  (the number of characters composing them).");
        Console.WriteLine();
        Console.WriteLine();

        string[] strings = { 
                               "this_word_is_way_too_long_it_should_probably_go_last", "short", "miniword", 
                               "man_this_word_is_long!", "nunu", "average_sized_word", "yet_another_word", 
                               "ni", "medium", "semi-medium", "man_this_word_is_even_longer!"
                           };

        Console.WriteLine("  This is the original array of strings:");
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine("  {0}", strings[i]);
        }

        SortStringByLength(strings);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  The array of strings was sorted by string length thusly:");
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine("  {0}", strings[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
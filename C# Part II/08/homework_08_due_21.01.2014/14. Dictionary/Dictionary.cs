using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections.Generic;

/*
 A dictionary is stored as a sequence of text lines containing words and their explanations. 
 Write a program that enters a word and translates it by using the dictionary.  
 */

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "Dictionary";

            while (true)
            {
                try
                {
                    Console.Write("Enter a word search: ");
                    string input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    StreamReader dict = new StreamReader(@"../../dictionary.txt");

                    List<string> dictionary = new List<string>();

                    while (!dict.EndOfStream)
                    {
                        dictionary.Add(dict.ReadLine());
                    }

                    dict.Close();


                    foreach (string item in dictionary)
                    {
                        if (input == item.Substring(0, input.Length))
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            break;
                        }                        
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (System.ArgumentNullException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {
                    throw;
                }
            }            
        }
    }
}

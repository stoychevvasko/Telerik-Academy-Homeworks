using System;
using System.Threading;
using System.Globalization;
using System.Text;

//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. 

namespace _09.WordMasker
{
    class WordMasker
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "WordMasker";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.Write("Please enter a list of forbidden words, separated by commas:");
                    string listOfWords = Console.ReadLine();
                    Console.WriteLine();

                    if (listOfWords.Length == 0)
                    {
                        throw new System.ArgumentNullException();   
                    }

                    listOfWords = listOfWords.Replace(" ", "");
                    string[] words = listOfWords.Split(',');

                    Console.WriteLine("Please enter a text for masking:");
                    string text = Console.ReadLine();
                    Console.WriteLine();

                    if (text.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    StringBuilder result = new StringBuilder(text);

                    foreach (string item in words)
                    {
                        result = result.Replace(item, new string('*', item.Length));
                    }

                    Console.WriteLine();
                    Console.WriteLine("The resulting text:");
                    Console.WriteLine(result.ToString());
                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (System.ArgumentNullException)
                {
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

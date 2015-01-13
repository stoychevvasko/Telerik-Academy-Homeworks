using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that extracts from a given text all sentences containing given word.

namespace _08.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "SentenceExtractor";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the word you seek:");
                    string word = Console.ReadLine();
                    Console.WriteLine();

                    if (word.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    Console.WriteLine("Please enter the text to search:");
                    string text = Console.ReadLine();
                    Console.WriteLine();

                    if (text.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    char[] separators = { '.', '!', '?' };
                    string[] sentences = text.Split(separators);

                    foreach (string item in sentences)
                    {
                        if (item.IndexOf(' ' + word + ' ') > -1)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    
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
                finally
                {
                    Console.WriteLine();
                }
            }

        }
    }
}

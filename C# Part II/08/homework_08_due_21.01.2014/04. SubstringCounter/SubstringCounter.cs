using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that finds how many times a substring is contained
//in a given text (perform case insensitive search).

namespace _04.SubstringCounter
{
    class SubstringCounter
    {
        static int CountSubstrings(string sourceString, string substring)
        {
            int result = 0;
            sourceString = sourceString.ToLower();
            substring = substring.ToLower();

            for (int i = 0; i < sourceString.Length - substring.Length + 1; i++)
            {
                if (sourceString.Substring(i, substring.Length).CompareTo(substring) == 0)
                {
                    result++;
                    i += substring.Length;
                }

            }

            return result;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "SubstringCounter";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.Write("Enter your source string here: ");
                    string str = Console.ReadLine();

                    if (str == "")
                    {
                        throw new System.ArgumentNullException();
                    }

                    Console.WriteLine();
                    Console.Write("Enter a substring to search: ");
                    string substring = Console.ReadLine();

                    if (substring == "")
                    {
                        throw new System.ArgumentNullException();
                    }

                    int timesFound = CountSubstrings(str, substring);
                    Console.WriteLine();
                    Console.WriteLine("The substring was found {0} times.", timesFound);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (System.ArgumentNullException)
                {
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

            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            Console.WriteLine();
        }
    }
}

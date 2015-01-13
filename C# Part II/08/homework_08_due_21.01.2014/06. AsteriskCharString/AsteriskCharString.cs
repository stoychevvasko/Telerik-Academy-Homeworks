using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should 
//be filled with '*'. Print the result string into the console.

namespace _06.AsteriskCharString
{
    class AsteriskCharString
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "AsteriskCharString";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.Write("Please enter a string: ");
                    string str = Console.ReadLine();

                    if (str.CompareTo(String.Empty) == 0)
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }

                    StringBuilder result = new StringBuilder();
                    for (int i = 0; i < 20; i++)
                    { 
                        if (i <= str.Length - 1)
                        {
                            result.Append(str[i]);
                        }
                        else
                        {
                            result.Append('*');
                        }                        
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The resulting string is {0}", result.ToString());
                    Console.WriteLine();
                }
                catch (System.ArgumentOutOfRangeException)
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

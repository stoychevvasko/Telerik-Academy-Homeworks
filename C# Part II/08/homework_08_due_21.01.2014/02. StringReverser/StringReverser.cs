using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" --> "elpmas".

namespace _02.StringReverser
{
    class StringReverser
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "StringReverser";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.Write("Enter your string here: ");
                    string str = Console.ReadLine();

                    if (str == "")
                    {
                        throw new System.ArgumentNullException();
                    }

                    StringBuilder strB = new StringBuilder();

                    for (int i = str.Length - 1; i >= 0; i--)
                    {
                        strB.Append(str[i]);
                    }

                    string result = strB.ToString();

                    Console.WriteLine();
                    Console.Write("The reversed string is: ");
                    Console.WriteLine(result);
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
            }

            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            Console.WriteLine();            
        }
    }
}

using System;
using System.Threading;
using System.Globalization;
using System.Text;

//You are given a text. Write a program that changes the text in all regions 
//surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

namespace _05.UpcaseTag
{
    class UpcaseTag
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "UpcaseTag";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.Write("Enter your source TEXT here: ");
                    string str = Console.ReadLine();


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

using System;
using System.Threading;
using System.Globalization;
using System.Text;

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

namespace _16.DaysBetweenDates
{
    class DaysBetweenDates
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "DaysBetweenDates";

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter date1 in the following format day.month.year:");
                    string input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    string[] dateOne = input.Split('.');

                    Console.WriteLine();
                    Console.WriteLine("Please enter date2 in the following format day.month.year:");
                    input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    string[] dateTwo = input.Split('.');

                    DateTime firstDate = new DateTime(int.Parse(dateOne[2]), int.Parse(dateOne[1]), int.Parse(dateOne[0]));
                    DateTime secondDate = new DateTime(int.Parse(dateTwo[2]), int.Parse(dateTwo[1]), int.Parse(dateTwo[0]));

                    TimeSpan span = (firstDate >= secondDate) ? (firstDate - secondDate) : (secondDate - firstDate);

                    // printing result in days

                    Console.WriteLine();
                    Console.WriteLine("There are {0} days between these two dates.", span.Days);
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
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid date!");
                    Console.WriteLine();
                    continue;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

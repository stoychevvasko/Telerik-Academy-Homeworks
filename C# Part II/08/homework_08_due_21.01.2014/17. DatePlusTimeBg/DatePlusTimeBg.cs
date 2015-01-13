using System;
using System.Threading;
using System.Globalization;
using System.Text;

/*
 Write a program that reads a date and time given in the format: day.month.year hour:minute:second
 and prints the date and time after 6 hours and 30 minutes (in the same format) along with 
 the day of week in Bulgarian.
 */

namespace _17.DatePlusTimeBg
{
    class DatePlusTimeBg
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "DatePlusTimeBg";

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a date and time in the following format:");
                    Console.WriteLine("day.month.year hour:minute:second");
                    Console.WriteLine();
                    string input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    int day = int.Parse(input.Substring(0, input.IndexOf('.')));
                    Console.WriteLine("day {0}", day);

                    int month = int.Parse(input.Substring(input.IndexOf('.') + 1, 2));
                    Console.WriteLine("month {0}", month);

                    int year = int.Parse(input.Substring(input.LastIndexOf('.') + 1, 4));
                    Console.WriteLine("year {0}", year);

                    int hour = int.Parse(input.Substring(input.IndexOf(' ') + 1, 2));
                    Console.WriteLine("hour {0}", hour);


                }
                catch (System.ArgumentNullException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bye!");
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

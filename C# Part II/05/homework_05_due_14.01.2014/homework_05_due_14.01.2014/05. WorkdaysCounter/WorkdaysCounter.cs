using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that calculates the number of 
//     workdays between today and given date, passed as 
//     parameter. Consider that workdays are all days from 
//     Monday to Friday except a fixed list of public 
//     holidays specified preliminary as array.

class WorkdaysCounter
{
    public static DateTime[] holidays = new DateTime[] { new DateTime(2014, 1, 1), new DateTime(2014, 3, 3), new DateTime(2014, 4, 18), 
    new DateTime(2014, 4, 19), new DateTime(2014, 4, 20), new DateTime(2014, 5, 1), new DateTime(2014, 5, 6), new DateTime(2014, 5, 24),
    new DateTime(2014, 9, 6), new DateTime(2014, 9, 22), new DateTime(2014, 11, 1), new DateTime(2014, 12, 24), new DateTime(2014, 12, 25),
    new DateTime(2014, 12, 26), new DateTime(2014, 12, 31)};

    //"otrabotvane"
    public static DateTime[] workingWeekends = new DateTime[] { new DateTime(2014, 5, 10), new DateTime(2014, 5, 31), new DateTime(2014, 12, 13) };
    
    public static void DateTimeSwap(ref DateTime one, ref DateTime two)
    {
        DateTime temp = two;
        two = one;
        one = temp;
    }

    public static int CountWorkdays(DateTime target)
    {
        DateTime current = new DateTime(2014, DateTime.Now.Month, DateTime.Now.Day);            
            
        TimeSpan span = target - current;

        //for counting days backwards
        if (span < new TimeSpan(0,0,0))
        {
            DateTimeSwap(ref current, ref target);            
        }
        
        int count = 1;

        while (current != target)
        {
            if (current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int i = 0; i < workingWeekends.Length; i++)
                {
                    if (current == workingWeekends[i])
                    {
                        count++;
                        break;
                    }
                }                
                
                current = current.AddDays(1);
            }
            else
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (current == holidays[i])
                    {                        
                        count--;
                        break;
                    }
                }

                count++;
                current = current.AddDays(1);
            }
        }

        return count;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "WorkdaysCounter";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("This application will calculate workdays from today to another date");
        Console.WriteLine("in 2014 only.");

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Enter the target month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the target day: ");
        int day = int.Parse(Console.ReadLine());

        DateTime target = new DateTime(2014, month, day);
                
        Console.WriteLine();
        
        int count = CountWorkdays(target);

        Console.WriteLine("Between {0} and {1} there are {2} working days (including).", 
            DateTime.Now.ToShortDateString(), target.ToShortDateString(), count);
        
        Console.WriteLine();
        Console.ReadKey();
    }
}



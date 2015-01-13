using System;


// this is the Next Date problem from Practice "Telerik Academy Exam 1 @ 27 Dec 2012" 

class NextDate
{
    static void Main()
    {
        int day, month, year;
        day = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
        year = int.Parse(Console.ReadLine());

        if (month == 1 && day == 31)
        {
            day = 1;
            month = 2;
        }
        else if ((month == 2) && (day == 28) && (year % 4 != 0))
        {
            day = 1;
            month = 3;
        }
        else if ((month == 2) && (day == 29) && (year % 4 == 0))
        {
            day = 1;
            month = 3;
        }
        else if ((month == 2) && (day == 28) && (year % 4 == 0))
        {
            day = 29;            
        }
        else if ((month == 3) && (day == 31))
        {
            day = 1;
            month = 4;
        }
        else if ((month == 4) && (day == 30))
        {
            day = 1;
            month = 5;
        }
        else if ((month == 5) && (day == 31))
        {
            day = 1;
            month = 6;
        }
        else if ((month == 6) && (day == 30))
        {
            day = 1;
            month = 7;
        }
        else if ((month == 7) && (day == 31))
        {
            day = 1;
            month = 8;
        }
        else if ((month == 8) && (day ==31))
        {
            day = 1;
            month = 9;
        }
        else if ((month == 9) && (day == 30))
        {
            day = 1;
            month = 10;
        }
        else if ((month == 10) && (day == 31))
        {
            day = 1;
            month = 11;
        }
        else if ((month == 11) && (day == 30))
        {
            day = 1;
            month = 12;
        }
        else if ((month == 12) && (day == 31))
        {
            day = 1;
            month = 1;
            ++year;
        }
        else
        {
            ++day;
        }

        Console.WriteLine("{0}.{1}.{2}", day, month, year);

    }
}
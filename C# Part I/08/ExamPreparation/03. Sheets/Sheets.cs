using System;


// this is the Sheets problem from Practice "Telerik Academy Exam 1 @ 27 Dec 2012" 


class Sheets
{
    static void Main()
    {
        int N;
        N = int.Parse(Console.ReadLine());

        if ((N & 1) == 0)
        {
            Console.WriteLine("A10");
        }

        if ((N & 2) == 0)
        {
            Console.WriteLine("A9");
        }

        if ((N & 4) == 0)
        {
            Console.WriteLine("A8");
        }

        if ((N & 8) == 0)
        {
            Console.WriteLine("A7");
        }

        if ((N & 16) == 0)
        {
            Console.WriteLine("A6");
        }

        if ((N & 32) == 0)
        {
            Console.WriteLine("A5");
        }

        if ((N & 64) == 0)
        {
            Console.WriteLine("A4");
        }

        if ((N & 128) == 0)
        {
            Console.WriteLine("A3");
        }

        if ((N & 256) == 0)
        {
            Console.WriteLine("A2");
        }

        if ((N & 512) == 0)
        {
            Console.WriteLine("A1");
        }

        if ((N & 1024) == 0)
        {
            Console.WriteLine("A0");
        }
    }
}


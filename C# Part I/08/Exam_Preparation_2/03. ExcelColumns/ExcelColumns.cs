using System;


// this is the Excel Columns problem from Practice "Telerik Academy Exam 1 @ 28 Dec 2012" 

class ExcelColumns
{


    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        char[] chars = new char[N];
        string input;

        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine();
            chars[i] = input[0];
        }

        int num = 0, count = 0;
        long identifier = 0;


        for (int i = (N - 1); i >= 0; i--)
        {
            switch (chars[i])
            {
                case 'A': num = 1; break;
                case 'B': num = 2; break;
                case 'C': num = 3; break;
                case 'D': num = 4; break;
                case 'E': num = 5; break;
                case 'F': num = 6; break;
                case 'G': num = 7; break;
                case 'H': num = 8; break;
                case 'I': num = 9; break;
                case 'J': num = 10; break;
                case 'K': num = 11; break;
                case 'L': num = 12; break;
                case 'M': num = 13; break;
                case 'N': num = 14; break;
                case 'O': num = 15; break;
                case 'P': num = 16; break;
                case 'Q': num = 17; break;
                case 'R': num = 18; break;
                case 'S': num = 19; break;
                case 'T': num = 20; break;
                case 'U': num = 21; break;
                case 'V': num = 22; break;
                case 'W': num = 23; break;
                case 'X': num = 24; break;
                case 'Y': num = 25; break;
                case 'Z': num = 26; break;
            }

            identifier += num * (long)Math.Pow(26, count);
            count++;
        }

        Console.WriteLine(identifier);      

    }
}
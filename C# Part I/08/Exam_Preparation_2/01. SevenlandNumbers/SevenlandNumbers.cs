using System;


// this is the Sevenland Numbers problem from Practice "Telerik Academy Exam 1 @ 28 Dec 2012" 

class SevenlandNumbers
{


    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int nextNumber = 0, n = 0, remainder = 0;
        string finalNumber = "";

        while (number != 0)
        {
            nextNumber += (number % 10) * (int)Math.Pow(7, n);
            n++;
            number /= 10;            
        }

        nextNumber++;

        while (nextNumber != 0)
        {
            remainder = (nextNumber % 7);
            nextNumber = nextNumber / 7;
            finalNumber = finalNumber + remainder;
        }
        

        for (int i = finalNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(finalNumber[i]);
        }

        Console.WriteLine();

    }
}
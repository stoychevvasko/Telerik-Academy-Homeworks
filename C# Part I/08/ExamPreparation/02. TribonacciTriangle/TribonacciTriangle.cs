using System;

// this is the Tribonacci Triangle problem from Practice "Telerik Academy Exam 1 @ 27 Dec 2012" 

namespace _02.TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main()
        {
            long num1, num2, num3;

            num1 = long.Parse(Console.ReadLine());
            num2 = long.Parse(Console.ReadLine());
            num3 = long.Parse(Console.ReadLine());

            int L;
            L = int.Parse(Console.ReadLine());

            int arraySize = 0;

            for (int i = 1; i <= L; i++)
            {
                arraySize += i;
            }

            long[] numbers;
            numbers = new long[arraySize];

            numbers[0] = num1;
            numbers[1] = num2;
            numbers[2] = num3;

            if (L > 2)
            {
                for (int i = 3; i < arraySize; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
                }
            }

            int countOnRow = 1;
            int index = 0;

            for (int row = 1; row <= L; row++)
            {
                for (int col = 1; col <= countOnRow; col++)
                {
                    if ((col != countOnRow + 1) && (col != 1))
                    {
                        Console.Write(" ");
                    }

                    Console.Write(numbers[index]);                    
                    index++;
                }
                countOnRow++;
                Console.WriteLine();
            }
            
        }
    }
}

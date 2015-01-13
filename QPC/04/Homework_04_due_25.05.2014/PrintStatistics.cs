
namespace Homework04.Task02
{
    using System;

    class Statistics
    {
        public void PrintStatistics(double[] array, int limit)
        {
            PrintMaxElement(array, limit);
            PrintMinElement(array, limit);
            PrintAverage(array, limit);
        }

        public void PrintMinElement(double[] array, int limit)
        {
            double currentMin = array[0];

            for (int i = 1; i < limit; i++)
            {
                if (array[i] < currentMin)
                {
                    currentMin = array[i];
                }
            }

            Console.WriteLine(currentMin);
        }

        public void PrintMaxElement(double[] array, int limit)
        {
            double currentMax = array[0];

            for (int i = 1; i < limit; i++)
            {
                if (array[i] > currentMax)
                {
                    currentMax = array[i];
                }
            }

            Console.WriteLine(currentMax);
        }

        public void PrintAverage(double[] array, int numberOfElements)
        {
            double currentSum = 0;

            for (int i = 0; i < numberOfElements; i++)
            {
                currentSum += array[i];
            }

            double average = currentSum / numberOfElements;
            Console.WriteLine(average);
        }
    }
}
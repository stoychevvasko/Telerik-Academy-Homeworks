/*

<Problem 02>

Implement a set of extension methods for 
IEnumerable<T> that implement the following 
group functions: sum, product, min, max, average.

*/

namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;

            foreach (var item in collection)
            {
                result *= (dynamic)item;

                if (result == 0)
                {
                    return result;
                }
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic result = long.MaxValue;

            foreach (var item in collection)
            {
                if (item < result)
                    result = item;
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic result = long.MinValue;

            foreach (var item in collection)
            {
                if (item > result)
                    result = item;
            }

            return result;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0, counter = 0;

            foreach (var item in collection)
            {
                result += item;
                counter++;
            }

            if (counter == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            return result / counter;
        }

        static void Main()
        {
            Console.Title = "02.IEnumerableExtensions";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;


            HashSet<float> testCollection = new HashSet<float> { -25, 1, 2, 3, -40, 4, 5, 150, -10, -11, -12, -13, -14 };

            Console.WriteLine("SUM: {0}", testCollection.Sum<float>());
            Console.WriteLine("PRODUCT: {0}", testCollection.Product<float>());
            Console.WriteLine("MIN: {0}", testCollection.Min<float>());
            Console.WriteLine("MAX: {0}", testCollection.Max<float>());
            Console.WriteLine("AVG: {0}", testCollection.Average<float>());


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

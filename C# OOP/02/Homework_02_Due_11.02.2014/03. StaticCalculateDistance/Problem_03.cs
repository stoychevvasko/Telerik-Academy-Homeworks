/*

<Problem 03>

Write a static class with a static method to calculate 
the distance between two points in the 3D space.

*/

namespace _03.StaticCalculateDistance
{
    using System;
    using System.Threading;
    using System.Globalization;
    using _01.StructurePoint3D;   

    // added reference to <Problem 01>

    class Problem_03
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "03. StaticCalculateDistance";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;

            
            Point3D startPoint = Point3D.PointZero;
            Console.WriteLine("startPoint " + startPoint.ToString());
            Console.WriteLine();
                        
            Point3D endPoint = new Point3D(1.236M, 2.3265M, -3.1597M);
            Console.WriteLine("endPoint " + endPoint.ToString());
            Console.WriteLine();

            Console.WriteLine("Distance: " + CalcDistance.Calc(startPoint, endPoint));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

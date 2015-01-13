/*

<Problem 02>

Add a private static read-only field to hold the start 
of the coordinate system – the point O{0, 0, 0}. 
Add a static property to return the point O.

 */

// added a reference to <Problem 01>
// added "using" line to access namespace _01.StructurePoint3D

// added a static private field on line 16 of Point3D.cs
// added static property on line 40 of Point3D.cs
 
namespace _02.StartOfCoordSys
{
    using System;
    using _01.StructurePoint3D;

    class Problem_02
    {
        static void Main()
        {
            Console.Title = "02. StartOfCoordSys";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;

            Point3D testPoint01 = Point3D.PointZero;
            Console.WriteLine("testPoint01 " + testPoint01.ToString());
            Console.WriteLine();

            // read-only test

            // Point3D.PointZero = new Point3D(0, 1, 2);            
        }
    }
}

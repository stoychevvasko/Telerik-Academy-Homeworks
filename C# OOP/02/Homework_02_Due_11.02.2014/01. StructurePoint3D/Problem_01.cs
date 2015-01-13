/*

<Problem 01>

Create a structure Point3D to hold a 3D-coordinate 
{X, Y, Z} in the Euclidian 3D space. Implement the 
ToString() to enable printing a 3D point.

*/

namespace _01.StructurePoint3D
{
    using System;

    class Problem_01
    {
        static void Main()
        {
            Console.Title = "01. StructurePoint3D";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;

            Point3D pointOne = new Point3D();
            System.Console.WriteLine("pointOne " + pointOne.ToString());
            System.Console.WriteLine();

            Point3D pointTwo = new Point3D(1, 2, 3);
            System.Console.WriteLine("pointTwo " + pointTwo.ToString());
            System.Console.WriteLine();

            Point3D pointThree = new Point3D(-4, -5, -6);
            System.Console.WriteLine("pointThree " + pointThree.ToString());
            System.Console.WriteLine();

            Console.WriteLine();
        }
    }
}

/*

<Problem 04>

Create a class Path to hold a sequence of points in 
the 3D space. Create a static class PathStorage 
with static methods to save and load paths from a 
text file. Use a file format of your choice.

*/

namespace _04.PathAndSave
{
    using System;
    using System.Threading;
    using System.Globalization;
    using _01.StructurePoint3D;
    using System.Collections.Generic;

    // added reference to <Problem 01>

    class Problem_04
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "04. PathAndSave";
            Console.SetWindowSize(80, 40);
            Console.BufferWidth = Console.WindowWidth = 80;
            Console.BufferHeight = Console.WindowHeight = 40;


            Path testPath1 = new Path();

            Path testPath2 = new Path(new Point3D());

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                testPath2.AddPoint(new Point3D(rand.Next(100), rand.Next(100), rand.Next(100)));
            }

            PathStorage.Save(testPath2, "../../test_file_01.path");

            Path testPath3 = PathStorage.Load("../../test_file_01.path");

            Console.WriteLine(testPath1.ToString());
            Console.WriteLine();
            Console.WriteLine(testPath2.ToString());
            Console.WriteLine();
            Console.WriteLine(testPath3.ToString());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

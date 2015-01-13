// <copyright file="MethodDemo.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace CohesionAndCoupling
{
    using System;

    /// <summary>Demos the various methods from Task 03 of this homework.</summary>
    public class MethodDemo
    {
        /// <summary>Starts program execution.</summary>
        public static void Main()
        {
            // Console.WriteLine(StringProcessor.GetFileExtension("example"));
            Console.WriteLine(StringProcessor.GetFileExtension("example.pdf"));
            Console.WriteLine(StringProcessor.GetFileExtension("example.new.pdf"));

            // Console.WriteLine(StringProcessor.GetFileNameWithoutExtension("example"));
            Console.WriteLine(StringProcessor.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(StringProcessor.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Geometry2D.CalculateDistance2D(1, -2, 3, 4));

            Console.WriteLine("Distance in the 3D space = {0:f2}", Geometry3D.CalculateDistance3D(5, 2, -1, 3, -6, 4));
            
            double widthTestValue = 3, 
                   heightTestValue = 4, 
                   depthTestValue = 5;

            Console.WriteLine("Volume = {0:f2}", Geometry3D.CalculateCuboidVolume(widthTestValue, heightTestValue, depthTestValue));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Geometry3D.CalculateDistanceToZero3D(widthTestValue, heightTestValue, depthTestValue));
            Console.WriteLine("Diagonal XY = {0:f2}", Geometry2D.CalculateDistanceToZero2D(widthTestValue, heightTestValue));
            Console.WriteLine("Diagonal XZ = {0:f2}", Geometry2D.CalculateDistanceToZero2D(widthTestValue, depthTestValue));
            Console.WriteLine("Diagonal YZ = {0:f2}", Geometry2D.CalculateDistanceToZero2D(heightTestValue, depthTestValue));
        }
    }
}

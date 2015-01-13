// <copyright file="Geometry2D.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace CohesionAndCoupling
{
    using System;

    /// <summary>A static class that contains geometrical calculation functionality in two dimensions.</summary>
    public static class Geometry2D
    {
        /// <summary>Calculates the distance between two points in two-dimensional space.</summary>
        /// <param name="firstPointXCoord">the X coordinate of the first point</param>
        /// <param name="firstPointYCoord">the Y coordinate of the first point</param>
        /// <param name="secondPointXCoord">the X coordinate of the second point</param>
        /// <param name="secondPointYCoord">the Y coordinate of the second point</param>
        /// <returns>a double numeric value</returns>
        public static double CalculateDistance2D(double firstPointXCoord, double firstPointYCoord, double secondPointXCoord, double secondPointYCoord)
        {
            double distance = Math.Sqrt(((secondPointXCoord - firstPointXCoord) * (secondPointXCoord - firstPointXCoord)) + ((secondPointYCoord - firstPointYCoord) * (secondPointYCoord - firstPointYCoord)));
            return distance;
        }

        /// <summary>Calculates the 2D distance between a given point and the beginning of the coordinate system.</summary>
        /// <param name="coordinateX">the X coordinate of the argument point</param>
        /// <param name="coordinateY">the Y coordinate of the argument point</param>
        /// <returns>a double numeric value</returns>
        public static double CalculateDistanceToZero2D(double coordinateX, double coordinateY)
        {
            double distance = Geometry2D.CalculateDistance2D(coordinateX, coordinateY, 0, 0);
            return distance;
        }
    }
}

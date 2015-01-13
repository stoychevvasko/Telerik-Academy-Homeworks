// <copyright file="Geometry3D.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace CohesionAndCoupling
{
    using System;

    /// <summary>A static class that contains geometrical calculation functionality in three dimensions.</summary>
    public static class Geometry3D
    {
        /// <summary>Calculates the distance between two points in three-dimensional space.</summary>
        /// <param name="firstPointXCoord">the X coordinate of the first point</param>
        /// <param name="firstPointYCoord">the Y coordinate of the first point</param>
        /// <param name="firstPointZCoord">the Z coordinate of the first point</param>
        /// <param name="secondPointXCoord">the X coordinate of the second point</param>
        /// <param name="secondPointYCoord">the Y coordinate of the second point</param>
        /// <param name="secondPointZCoord">the Z coordinate of the second point</param>
        /// <returns>a double numeric value</returns>
        public static double CalculateDistance3D(double firstPointXCoord, double firstPointYCoord, double firstPointZCoord, double secondPointXCoord, double secondPointYCoord, double secondPointZCoord)
        {
            double distance = Math.Sqrt(((secondPointXCoord - firstPointXCoord) * (secondPointXCoord - firstPointXCoord)) + ((secondPointYCoord - firstPointYCoord) * (secondPointYCoord - firstPointYCoord)) + ((secondPointZCoord - firstPointZCoord) * (secondPointZCoord - firstPointZCoord)));
            return distance;
        }

        /// <summary>Calculates the volume of a rectangular prism (cuboid).</summary>
        /// <param name="width">the width of the cuboid</param>
        /// <param name="height">the height of the cuboid</param>
        /// <param name="depth">the depth of the cuboid</param>
        /// <returns>a double numeric value</returns>
        public static double CalculateCuboidVolume(double width, double height, double depth)
        {
            if (width <= 0 || height <= 0 || depth <= 0)
            {
                throw new ArgumentOutOfRangeException("Cannot create a cuboid with non-positive dimensions!");
            }
            
            double volume = width * height * depth;
            return volume;
        }

        /// <summary>Calculates the 3D distance between a given point and the beginning of the coordinate system.</summary>
        /// <param name="coordinateX">the x coordinate of the argument point</param>
        /// <param name="coordinateY">the y coordinate of the argument point</param>
        /// <param name="coordinateZ">the z coordinate of the argument point</param>
        /// <returns>a double numeric value</returns>
        public static double CalculateDistanceToZero3D(double coordinateX, double coordinateY, double coordinateZ)
        {
            double distance = Geometry3D.CalculateDistance3D(coordinateX, coordinateY, coordinateZ, 0, 0, 0);
            return distance;
        }
    }
}

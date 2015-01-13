// <copyright file="Methods.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Homework06
{
    using System;

    /// <summary>    
    /// A collection of miscellaneous methods that form the rest of this homework</summary>
    public class Methods
    {
        /// <summary>
        /// Calculates the surface area of a triangle.</summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <param name="c">length of side c</param>
        /// <returns>Returns double result.</returns>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Cannot create triangle with non-positive sides!");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>Converts a single-digit integer to its English pronunciation in string form.</summary>
        /// <param name="number">digit value</param>
        /// <returns>Returns string with the English word for that digit.</returns>
        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException(string.Format("Cannot recognize [ {0} ] as a valid digit!", number));
            }
        }

        /// <summary>Finds the greatest amongst an array of integers.</summary>
        /// <param name="elements">an array of integer values</param>
        /// <returns>the greatest element as integer</returns>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Cannot find greatest int in empty array!");
            }

            int result = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > result)
                {
                    result = elements[i];
                }
            }

            return result;
        }
        
        /// <summary>Creates a formatted string from any numeric value according to formatting parameter.</summary>
        /// <param name="number">numeric value</param>
        /// <param name="format">f for f2 format (two digits after decimal mark), 
        /// % for fractions of 1 as percentage, r for 8-character string (whitespace on left)</param>
        /// <returns>formatted string result</returns>
        public static string FormatNumber(object number, string format)
        {
            switch (format)
            {
                case "f": return string.Format("{0:f2}", number);
                case "%": return string.Format("{0:p0}", number);
                case "r": return string.Format("{0,8}", number);
                default: throw new ArgumentException(string.Format("Cannot format string with invalid format [{0}]", format));
            }            
        }

        /// <summary>Calculates the distance between two points.</summary>
        /// <param name="x1">The X coordinate of the first point</param>
        /// <param name="y1">The Y coordinate of the first point</param>
        /// <param name="x2">The X coordinate of the second point</param>
        /// <param name="y2">The Y coordinate of the second point</param>
        /// <param name="isHorizontal">true for horizontal lines</param>
        /// <param name="isVertical">true for vertical lines</param>
        /// <returns>distance between the first and second points as double value</returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = y1 == y2;
            isVertical = x1 == x2;

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }        
    }
}

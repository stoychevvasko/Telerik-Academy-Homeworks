// <copyright file="Figure.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Abstraction
{
    using System;
    using System.Text;

    /// <summary>Represents a generic geometrical shape.</summary>
    public abstract class Figure
        : IHasPerimeter, IHasSurfaceArea
    {
        /// <summary>Default length measurement for use in default constructors of shapes.</summary>
        public const double DefaultMeasurement = 1.0;

        /// <summary>Initializes a new instance of the <see cref="Figure"/> class.</summary>
        public Figure()
        {
        }

        /// <summary>Calculates the perimeter of a figure</summary>
        /// <returns>a double numeric value</returns>
        public abstract double CalculatePerimeter();

        /// <summary>Calculates the surface area of a figure</summary>
        /// <returns>a double numeric value</returns>
        public abstract double CalculateSurfaceArea();

        /// <summary>Convert this object to a string in the following format: "I am a SHAPE. My perimeter is PERIMETER. My surface is SURFACE."</summary>
        /// <returns>a string value</returns>
        public override string ToString()
        {
            string result = string.Format(
                            "I am a {0}. My perimeter is {1:f2}. My surface is {2:f2}.",
                            this.GetType().Name.ToLower(),
                            this.CalculatePerimeter(),
                            this.CalculateSurfaceArea());
            return result;
        }
    }
}

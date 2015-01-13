// <copyright file="Circle.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Abstraction
{
    using System;

    /// <summary>Represents a circle as a geometrical shape.</summary>
    public class Circle
        : Figure, IHasPerimeter, IHasSurfaceArea
    {
        /// <summary>Holds the radius of a circle.</summary>
        private double radius;

        /// <summary>Initializes a new instance of the Circle class.</summary>
        public Circle()
            : this(Figure.DefaultMeasurement)
        {
        }

        /// <summary>Initializes a new instance of the Circle class.</summary>
        /// <param name="radius">the radius of a circle/></param>
        public Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        /// <summary>Gets or sets the radius of a circle.</summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Circle radius cannot be a non-positive value!");
                }

                this.radius = value;
            }
        }

        /// <summary>Calculates the perimeter of a circle.</summary>
        /// <returns>a double numeric value</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>Calculates the surface area of a circle disc.</summary>
        /// <returns>a double numeric value</returns>
        public override double CalculateSurfaceArea()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}

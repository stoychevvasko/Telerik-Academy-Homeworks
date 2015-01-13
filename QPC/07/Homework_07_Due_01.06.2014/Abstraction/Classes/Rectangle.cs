// <copyright file="Rectangle.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Abstraction
{
    using System;

    /// <summary>Represents a rectangle geometrical shape.</summary>
    public class Rectangle 
        : Figure, IHasPerimeter, IHasSurfaceArea
    {
        /// <summary>Holds the width of a rectangle.</summary>
        private double width;

        /// <summary>Holds the height of a rectangle.</summary>
        private double height;

        /// <summary>Initializes a new instance of the Rectangle class.</summary>
        public Rectangle()
            : this(Figure.DefaultMeasurement, Figure.DefaultMeasurement)
        {            
        }

        /// <summary>Initializes a new instance of the Rectangle class.</summary>
        /// <param name="width">the width of a rectangle"</param>
        /// <param name="height">the height of a rectangle/></param>
        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>Gets or sets the width of a rectangle.</summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rectangle width cannot be a non-positive value!");
                }

                this.width = value;
            }
        }

        /// <summary>Gets or sets the height of a rectangle.</summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rectangle height cannot be a non-positive value!");
                }

                this.height = value;
            }
        }

        /// <summary>Calculates the perimeter of a rectangle.</summary>
        /// <returns>a double numeric value</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>Calculates the surface area of a rectangle.</summary>
        /// <returns>a double numeric value</returns>
        public override double CalculateSurfaceArea()
        {
            double surface = this.Width * this.Height;
            return surface;
        }        
    }
}

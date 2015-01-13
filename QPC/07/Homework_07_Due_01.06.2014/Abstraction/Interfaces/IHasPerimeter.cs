// <copyright file="IHasPerimeter.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Abstraction
{
    /// <summary>Inheritors of this interface implement the CalculatePerimeter() method.</summary>
    public interface IHasPerimeter
    {
        /// <summary>Calculates the perimeter of a geometrical figure.</summary>
        /// <returns>double numeric value</returns>
        double CalculatePerimeter();
    }
}

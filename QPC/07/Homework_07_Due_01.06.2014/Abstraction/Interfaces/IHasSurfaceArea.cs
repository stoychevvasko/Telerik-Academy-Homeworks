// <copyright file="IHasSurfaceArea.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Abstraction
{
    /// <summary>Inheritors of this interface implement the CalculateSurfaceArea() method.</summary>
    public interface IHasSurfaceArea
    {
        /// <summary>Calculates the surface area of a geometrical figure.</summary>
        /// <returns>a double numeric value</returns>
        double CalculateSurfaceArea();
    }
}

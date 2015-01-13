/*

Define class Circle and suitable constructor so that
at initialization height must be kept equal to width 
and implement the CalculateSurface() method. 

*/
namespace _01.Problem01
{
    public class Circle
        : Shape
    {
        public Circle(decimal radius)
        {
            this.Width = radius;
            this.Height = radius;
        }

        public Circle()
            : this(1M)
        {
        }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Width * 3.14159M;
        }
    }
}

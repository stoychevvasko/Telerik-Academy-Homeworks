/*

Define two new classes Triangle and 
Rectangle that implement the virtual method 
and return the surface of the figure (height*width for
rectangle and height*width/2 for triangle).

*/
namespace _01.Problem01
{
    public class Rectangle
        : Shape
    {
        public Rectangle(decimal width, decimal height)
            : base(width, height)
        {            
        }

        public Rectangle()
            : base()
        {
        }
        
        public override decimal CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}

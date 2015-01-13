/*

<Problem 01>

Define abstract class Shape with only one abstract
method CalculateSurface() and fields width and 
height. Define two new classes Triangle and 
Rectangle that implement the virtual method 
and return the surface of the figure (height*width for
rectangle and height*width/2 for triangle). Define 
class Circle and suitable constructor so that at 
initialization height must be kept equal to width 
and implement the CalculateSurface() method. 
Write a program that tests the behavior of  the 
CalculateSurface() method for different shapes 
(Circle, Rectangle, Triangle) stored in an array.

*/




namespace _01.Problem01
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Globalization;

    class Problem01
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "<Problem 01>";
            Console.SetWindowSize(44, 12);
            Console.BufferWidth = Console.WindowWidth = 44;
            Console.BufferHeight = Console.WindowHeight = 12;


            Shape[] arrayOfShapes = new Shape[]
            {
                new Rectangle(),
                new Rectangle(1M,2M),
                new Triangle(),
                new Triangle(5M,3M),
                new Circle(),
                new Circle(2.345M),
                new Rectangle(4M,5M),
                new Triangle(2M,8M),
                new Circle(6M)
            };

            foreach (var shape in arrayOfShapes)
            {
                Console.WriteLine("{0, -10}  Surface area:   {1, -2}", shape.Type, shape.CalculateSurface());                
            }


            Console.WriteLine();
        }

        

        
    }
}

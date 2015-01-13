// <copyright file="FiguresExample.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Abstraction
{
    using System;

    /// <summary>Example figures for demonstration purposes. Main() method.</summary>
    public class FiguresExample
    {
        /// <summary>Demonstrates shapes.</summary>
        public static void Main()
        {
            Circle circle = new Circle(5);            
            Console.WriteLine(circle);
            Console.WriteLine();
            
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

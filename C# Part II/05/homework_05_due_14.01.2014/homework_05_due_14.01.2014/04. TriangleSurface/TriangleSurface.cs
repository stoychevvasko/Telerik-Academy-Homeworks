using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write methods that calculate the surface of a 
//     triangle by given:
//     Side and an altitude to it; Three sides; Two sides 
//     and an angle between them. Use System.Math.

class TriangleSurface
{
    static public double TriangleSurfaceBySideAndAltitude(double side, double altitude)
    {
        double result = (side * altitude) / 2;
        return result;
    }
    
    static public double TriangleSurfaceByHero(double sideA, double sideB, double sideC)
    {
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        return result;
    }

    static public double TriangleSurfaceBytrigonometry(double sideA, double sideB, double angle)
    {
        double result = (sideA * sideB * Math.Sin(angle)) / 2;
        return result;
    }

    static public double DegreesToRadians(double degrees)
    {
        double radians = degrees * (Math.PI / 180);
        return radians;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "TriangleSurface";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Calculate surface area by side and altitude");
        Console.WriteLine();
        Console.Write("Please enter a side: ");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter an altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The surface area of this triangle is {0}.", TriangleSurfaceBySideAndAltitude(side, altitude));

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Calculate surface area by three sides");
        Console.WriteLine();
        Console.Write("Please enter sideA: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter sideB: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter sideC: ");
        double sideC = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The surface area of this triangle is {0}.", TriangleSurfaceByHero(sideA, sideB, sideC));

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Calculate surface area by trigonometry");
        Console.WriteLine();
        Console.Write("Please enter sideA: ");
        double sideAA = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter sideB: ");
        double sideBB = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter the angle between them in degrees: ");
        double angle = double.Parse(Console.ReadLine());
        angle = DegreesToRadians(angle);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The surface area of this triangle is {0}.", TriangleSurfaceBytrigonometry(sideAA, sideBB, angle));

        Console.WriteLine();
        Console.ReadKey();
    }
}



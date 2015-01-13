namespace _03.StaticCalculateDistance
{
    using _01.StructurePoint3D;    

    using System;

    public static class CalcDistance
    {
        public static decimal Calc(Point3D start, Point3D end)
        {
            // distance formula is Sqrt((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)

            // some unfortunate type casting follows

            double sqrtFeed = (double)
                (
                    (end.X - start.X) * (end.X - start.X) 
                    + (end.Y - start.Y) * (end.Y - start.Y) 
                    + (end.Z - start.Z) * (end.Z - start.Z)
                );

            decimal result = (decimal)Math.Sqrt(sqrtFeed);            
            
            return result;
        }
    }
}

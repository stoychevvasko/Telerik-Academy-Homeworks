namespace _01.StructurePoint3D
{
    using System;

    public struct Point3D
    {
        // fields

        private decimal x;
        private decimal y;
        private decimal z;

        // <Problem 02> Add a private static read-only field to hold the start of 
        // the coordinate system – the point O{0, 0, 0}. 

        private static Point3D pointZero = new Point3D(0, 0, 0);

        // properties

        public decimal X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public decimal Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public decimal Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // <Problem 02> Add a static property to return the point O.

        public static Point3D PointZero
        {
            get { return Point3D.pointZero; }
        }

        // constructor

        public Point3D(decimal xValue, decimal yValue, decimal zValue)
            : this()
        {
            this.X = xValue;
            this.Y = yValue;
            this.Z = zValue;
        }

        // ToString() overload

        public string ToString()
        {
            string result = String.Format("{0}, {1}, {2}",
            this.X, this.Y, this.Z).ToString();

            return '{' + result + '}';
        }
    }
}

//01. Refactor the following code to use proper variable naming and simplified expressions.


namespace Homework04.Task01 
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public double Width 
        {
            get { return this.width; }
            set
            {
                if (value <= 0) 
                {
                    throw new System.ArgumentOutOfRangeException("Non-positive sizes disallowed!");
                } 
                else 
                {
                    this.width = value;
                }	 
            }
        }

        
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentOutOfRangeException("Non-positive sizes disallowed!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Size GetRotatedSize(Size size, double angle)
        {
            double cosinus = Math.Abs(Math.Cos(angle));
            double sinus = Math.Abs(Math.Sin(angle));

            double widthAfterRotation = cosinus * size.width + sinus * size.height;
            double heightAfterRotation = sinus * size.width + cosinus * size.height;

            Size rotatedSize = new Size(widthAfterRotation, heightAfterRotation);

            return rotatedSize;
        }
    }
}
/*

Define abstract class Shape with only one abstract
method CalculateSurface() and fields width and 
height.

*/



namespace _01.Problem01
{
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public string Type
        {
            get
            {
                string result = this.GetType().ToString();
                return result.Substring(result.LastIndexOf('.') + 1);
            }
        }

        public decimal Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Invalid width!");
                };
                this.width = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Invalid height!");
                };
                this.height = value;
            }
        }

        public Shape(decimal width, decimal height)
        {
            this.Height = height;
            this.Width = width;
        }

        public Shape()
            : this(1M, 1M)
        {
        }

        public virtual decimal CalculateSurface()
        {
            return 0;
        }

    }
}

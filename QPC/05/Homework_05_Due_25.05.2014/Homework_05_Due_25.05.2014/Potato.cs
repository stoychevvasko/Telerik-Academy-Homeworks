namespace Homework05
{
    using System;

    /// <summary>
    /// Represents a potato.
    /// </summary>
    public class Potato
        : Vegetable
    {
        public Potato(float weightArg, bool isPeeledArg, bool isCutArg, bool isCookedArg, bool isRottenArg)
            : base(weightArg, isPeeledArg, isCutArg, isCookedArg, isRottenArg)
        {
            Console.WriteLine("New custom potato created!");
        }

        public Potato()
            : base()
        {
            Console.WriteLine("New default potato created!");
            Console.WriteLine(this.ToString());            
        }
    }
}

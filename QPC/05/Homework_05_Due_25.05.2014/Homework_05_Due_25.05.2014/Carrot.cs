namespace Homework05
{
    using System;

    /// <summary>
    /// Represents a carrot.
    /// </summary>
    public class Carrot
        : Vegetable
    {
        public Carrot(float weightArg, bool isPeeledArg, bool isCutArg, bool isCookedArg, bool isRottenArg)
            : base(weightArg, isPeeledArg, isCutArg, isCookedArg, isRottenArg)
        {
            Console.WriteLine("New custom carrot created!");
        }

        public Carrot()
            : base()
        {
            Console.WriteLine("New default carrot created!");
            Console.WriteLine(this.ToString());
        }
    }
}

namespace Homework05
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a bowl.
    /// </summary>
    public class Bowl
    {
        List<Vegetable> contents;

        public Bowl()
        {
            this.contents = new List<Vegetable>();
            Console.WriteLine("New bowl created!");
            Console.WriteLine(this.ToString());
            Console.WriteLine();
        }

        public void Add(Vegetable vegetableArg)
        {
            this.contents.Add(vegetableArg);
            Console.WriteLine("Vegetable added to bowl!");            
        }

        public override string ToString()
        {
            return "This is a bowl!";
        }
    }
}

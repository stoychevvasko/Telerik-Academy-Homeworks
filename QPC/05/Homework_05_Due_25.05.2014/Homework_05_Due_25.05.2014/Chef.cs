namespace Homework05
{
    using System;

    public class Chef
    {
        private static Bowl GetBowl()
        {
            return new Bowl();
        }

        private static Carrot GetCarrot()
        {
            return new Carrot();
        }

        private static Potato GetPotato()
        {
            return new Potato();
        }

        private static void Peel(Vegetable vegetableArg)
        {
            vegetableArg.IsPeeled = true;
            Console.WriteLine("Vegetable peeled!");
            Console.WriteLine();
            //Console.WriteLine(vegetableArg.ToString());
        }

        private static void Cut(Vegetable vegetableArg)
        {
            vegetableArg.IsCut = true;
            Console.WriteLine("Vegetable cut!");
            Console.WriteLine();
            //Console.WriteLine(vegetableArg.ToString());
        }

        private static void Cook(Vegetable vegetableArg)
        {
            vegetableArg.IsCooked = true;
            Console.WriteLine("Vegetable cooked!");
            Console.WriteLine();
            //Console.WriteLine(vegetableArg.ToString());
        }

        private static void AutoCook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;

            Peel(potato);
            Peel(carrot);

            bowl = GetBowl();

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        public static void Main()
        {
            // Task 01 - Refactor the following class using best practices for organizing straight-line code

            AutoCook();
            Console.WriteLine();



            // Task 02 - Refactor the following if statements

            Potato potatoForIf = new Potato();

            // IF statement #1

            if (potatoForIf != null)
            {
                if ((potatoForIf.IsPeeled == true) && (potatoForIf.IsRotten == false))
                {
                    Cook(potatoForIf);
                }
            }

            // IF statement #2

            {
                int x = 0;
                int y = 0;
                int minX = 0;
                int maxX = 0;
                int maxY = 0;
                int minY = 0;
                bool shouldVisitCell = true;
                bool isYBetweemMinMax = minY <= y && y <= maxY;
                bool isXBetweenMinMax = minX <= x && x <= maxX;

                if (isXBetweenMinMax && (isYBetweemMinMax && shouldVisitCell))
                {
                    VisitCell();
                }
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("I \"visited\" a cell.");
            Console.WriteLine();
        }
    }
}

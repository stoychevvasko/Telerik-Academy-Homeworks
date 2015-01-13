/*

<Problem 03>

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat 
and define useful constructors and methods. Dogs, 
frogs and cats are Animals. All animals can produce 
sound (specified by the ISound interface). Kittens 
and tomcats are cats. All animals are described by 
age, name and sex. Kittens can be only female and 
tomcats can be only male. Each animal produces a 
specific sound. Create arrays of different kinds of 
animals and calculate the average age of each kind 
of animal using a static method (you may use LINQ).

*/


namespace _03.VariousAnimals
{
    using System;
    using System.Linq;
    using System.Globalization;    
    using System.Threading;

    class VariousAnimals
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "03.VariousAnimals";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;

            Dog dog1 = new Dog("Rex", 5, true);
            Dog dog2 = new Dog("Linda", 2, false);
            
            dog1.MakeSound();
            dog2.MakeSound();

            Dog[] dogs = new Dog[] { dog1, dog2 };
            Console.WriteLine("Avg. dog age: {0} years", dogs.Average(x => x.Age));
            Console.WriteLine();

            Cat cat1 = new Cat("Jynx", 3.5f, true);
            Kitten cat2 = new Kitten("Suzy", 6f);
            Tomcat cat3 = new Tomcat("Fuzzy", 0.5f);

            cat1.MakeSound();
            cat2.MakeSound();
            cat3.MakeSound();

            Cat[] cats = new Cat[] { cat1, cat2, cat3 };
            Console.WriteLine("Avg. cat age: {0} years", cats.Average(x => x.Age));
            Console.WriteLine();

            Frog frog1 = new Frog("Kermit", 0.2f, true);
            Frog frog2 = new Frog("Kermitta", 1f, false);

            frog1.MakeSound();
            frog2.MakeSound();

            Frog[] frogs = new Frog[] { frog1, frog2 };
            Console.WriteLine("Avg. frog age: {0} years", frogs.Average(x => x.Age));
            Console.WriteLine();
        }
    }
}

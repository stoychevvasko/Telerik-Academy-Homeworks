namespace _03.VariousAnimals
{
    public class Cat
        : Animal
    {
        public Cat(string name, float age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public Cat()
            : base()
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Miaow!");
        }
    }
}

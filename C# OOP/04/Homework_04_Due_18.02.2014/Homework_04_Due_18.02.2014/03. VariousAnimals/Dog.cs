namespace _03.VariousAnimals
{
    public class Dog
        : Animal
    {
        public Dog(string name, float age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public Dog()
            : base()
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Woof!");
        }
    }
}

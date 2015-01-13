namespace _03.VariousAnimals
{
    public class Frog
        : Animal
    {
        public Frog(string name, float age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public Frog()
            : base()
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Croak!");
        }
    }
}

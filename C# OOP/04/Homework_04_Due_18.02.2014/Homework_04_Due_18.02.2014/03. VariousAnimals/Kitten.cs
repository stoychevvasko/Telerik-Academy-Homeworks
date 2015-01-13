namespace _03.VariousAnimals
{
    public class Kitten
        : Cat
    {
        public Kitten(string name, float age)
            : base(name, age, false)
        {
        }

        public Kitten()
            : base()
        {
            this.IsMale = false;
        }
    }
}

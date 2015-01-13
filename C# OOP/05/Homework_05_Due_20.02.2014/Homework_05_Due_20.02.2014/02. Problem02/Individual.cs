namespace _02.Problem02
{
    public class Individual
        : Customer
    {
        public Individual(string individualName)
            : base(individualName)
        {
        }

        public Individual()
            : this("Unknown individual")
        {
        }
    }
}

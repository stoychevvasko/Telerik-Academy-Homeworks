namespace _03.VariousAnimals
{
    public class Tomcat
        : Cat
    {
        public Tomcat(string name, float age)
            : base(name, age, true)
        {
        }

        public Tomcat()
            : base()
        {
            this.IsMale = true;
        }
    }
}

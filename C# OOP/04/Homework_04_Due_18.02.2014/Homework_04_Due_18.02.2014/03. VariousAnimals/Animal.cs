namespace _03.VariousAnimals
{
    abstract public class Animal
        : ISound
    {
        private string name;
        private float age;
        private bool isMale;

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (value == "" || value == null)
                {
                    throw new System.ArgumentNullException("Name cannot be empty or null!");
                }

                this.name = value;
            }
        }

        public float Age
        {
            get { return this.age; }
            protected set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Age cannot be negative!");
                }

                this.age = value;
            }
        }

        public bool IsMale
        {
            get { return this.isMale; }
            protected set { this.isMale = value; }
        }

        public Animal(string name, float age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public Animal()
            : this("NoName", 0f, false)
        {
        }

        public abstract void MakeSound();        
    }
}

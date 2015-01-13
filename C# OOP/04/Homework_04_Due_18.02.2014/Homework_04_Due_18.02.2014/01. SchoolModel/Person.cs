namespace _01.SchoolModel
{
    abstract public class Person
        : SchoolObject
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            protected set 
            {
                if (value == null || value == "")
                {
                    throw new System.ArgumentNullException("Name cannot be null or empty!");
                }

                this.name = value; 
            }
        }

        public Person(string name, string comment = "")
            : base(comment)
        {
            this.Name = name;
        }

        public Person()
            : this("NoName NoSurname")
        {
        }
    }
}

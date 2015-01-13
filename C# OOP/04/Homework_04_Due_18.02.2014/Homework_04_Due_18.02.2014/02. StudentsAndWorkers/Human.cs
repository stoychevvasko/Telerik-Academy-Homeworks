namespace _02.StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (value == "" || value == null)
                {
                    throw new System.ArgumentNullException("First name cannot be empty or null!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (value == "" || value == null)
                {
                    throw new System.ArgumentNullException("Last name cannot be empty or null!");
                }

                this.lastName = value;
            }
        } 

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public Human()
            : this("NoName", "NoSurname")
        {
        }       
    }
}

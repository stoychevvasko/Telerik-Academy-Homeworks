namespace _02.StudentsAndWorkers
{
    public class Student
        : Human
    {
        private float grade;

        public float Grade
        {
            get { return this.grade; }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new System.ArgumentException("Invalid grade!");
                }

                this.grade = value;
            }
        }

        public Student(string fName, string lName, float grade)
            : base(fName, lName)
        {
            this.Grade = grade;
        }

        public Student()
            : base()
        {
            this.Grade = 2;
        }

        public override string ToString()
        {
            return string.Format("{0}  {1}      Успех:  {2:F}", this.FirstName, this.LastName, this.Grade);
        }
    }
}

namespace _01.SchoolModel
{
    public class Student
        : Person
    {
        private uint classNumber;

        public uint ClassNumber
        {
            get { return this.classNumber; }
            protected set
            {
                if (value < 1)
                {
                    throw new System.ArgumentOutOfRangeException("Class number cannot be zero!");
                }

                this.classNumber = value;
            }
        }

        public Student(string name, uint classNum, string comment = "")
            : base(name, comment)
        {
            this.ClassNumber = classNum;
        }

        public Student()
            : base()
        {
            this.ClassNumber = 1;
        }

        public override string ToString()
        {
            return string.Format("Student name: {0} \nClass number: {1} \nComment: {2}", this.Name, this.ClassNumber, this.Comment);                
        }
    }
}

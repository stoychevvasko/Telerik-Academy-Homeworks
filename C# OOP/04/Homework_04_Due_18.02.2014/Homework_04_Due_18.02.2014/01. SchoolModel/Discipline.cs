namespace _01.SchoolModel
{
    public class Discipline
        : SchoolObject
    {
        private string name;
        private uint numberOfLectures;
        private uint numberofExcercises;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public uint NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set 
            {
                if (value < 1)
                {
                    throw new System.ArgumentOutOfRangeException("Disciplines must have at least a single lecture.");
                }
                this.numberOfLectures = value; 
            }
        }

        public uint NumberOfExcercises
        {
            get { return this.numberofExcercises; }
            private set
            {
                if (value < 1)
                {
                    throw new System.ArgumentOutOfRangeException("Disciplines must have at least a single excercise");
                }
                this.numberofExcercises = value;
            }
        }

        public Discipline(string name, uint numOfLectures, uint numOfExcercises, string comment = "")
            : base(comment)
        {
            this.Name = name;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExcercises = numOfExcercises;
        }

        public Discipline()
            : this("Unnamed Discipline", 1, 1, "")
        {
        }

        public override string ToString()
        {
            return string.Format("Discipline name: {0} \nNumber of lectures: {1} \nNumber of excercises: {2} \nComment: {3}",
                this.Name, this.NumberOfLectures, this.NumberOfExcercises, this.Comment);
        }
    }
}

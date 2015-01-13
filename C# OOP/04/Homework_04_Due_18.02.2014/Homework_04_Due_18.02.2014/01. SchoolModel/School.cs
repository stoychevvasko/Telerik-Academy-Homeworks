namespace _01.SchoolModel
{
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string schoolName;
        private HashSet<SchoolClass> setOfClasses;

        public string SchoolName
        {
            get { return this.schoolName; }
            private set 
            {
                if (value == "" || value == null)
                {
                    throw new System.ArgumentNullException("School name cannot be null or empty!");
                }

                this.schoolName = value;
            }
        }

        public HashSet<SchoolClass> SetOfClasses
        {
            get { return new HashSet<SchoolClass>(this.setOfClasses); }
            private set { this.setOfClasses = new HashSet<SchoolClass>(value); }
        }

        public School(string name, HashSet<SchoolClass> classes)
        {
            this.SchoolName = name;
            this.SetOfClasses = classes;
        }

        public School()
            : this("NoName School", new HashSet<SchoolClass>())
        {
        }

        public void AddClass(SchoolClass cl)
        {
            this.setOfClasses.Add(cl);
        }

        public void RemoveClass(SchoolClass cl)
        {
            this.setOfClasses.Remove(cl);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(string.Format("{0}\nClasses:\n", this.SchoolName));

            foreach (var item in this.SetOfClasses)
            {
                result.Append("Class iD: " + item.UniqueIdentifier + '\n');
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
    }
}

namespace _01.SchoolModel
{
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass
        : SchoolObject
    {
        private string uniqueIdentifier;
        private HashSet<Teacher> setOfTeachers;
        private HashSet<Student> setOfStudents;

        public string UniqueIdentifier
        {
            get { return this.uniqueIdentifier; }
            private set { this.uniqueIdentifier = value; }
        }

        public HashSet<Teacher> SetOfTeachers
        {
            get { return new HashSet<Teacher>(this.setOfTeachers); }
            private set { this.setOfTeachers = new HashSet<Teacher>(value); }
        }

        public HashSet<Student> SetOfStudents
        {
            get { return new HashSet<Student>(this.setOfStudents); }
            private set { this.setOfStudents = new HashSet<Student>(value); }
        }

        public SchoolClass(string iD, HashSet<Teacher> teachers, HashSet<Student> students, string comment = "")
            : base(comment)
        {
            this.uniqueIdentifier = iD;
            this.setOfTeachers = teachers;
            this.SetOfStudents = students;
        }

        public SchoolClass()
            : this("default identifier", new HashSet<Teacher>(), new HashSet<Student>(),"")
        {
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            this.setOfStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.setOfStudents.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(string.Format("{0}\nComment: {1}\nTeachers:\n", this.UniqueIdentifier, this.Comment));

            foreach (var item in this.SetOfTeachers)
            {
                result.Append(item.Name + '\n');
            }
            
            result.Append("Students:\n");

            foreach (var item in this.SetOfStudents)
            {
                result.Append(item.Name + '\n');
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
    }
}

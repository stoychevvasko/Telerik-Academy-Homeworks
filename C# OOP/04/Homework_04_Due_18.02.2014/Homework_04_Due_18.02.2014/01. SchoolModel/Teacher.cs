namespace _01.SchoolModel
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher
        : Person
    {
        private HashSet<Discipline> listOfDisciplines;

        public HashSet<Discipline> ListOfDisciplines
        {
            get 
            { 
                return new HashSet<Discipline>(this.listOfDisciplines); 
            }
            private set { this.listOfDisciplines = new HashSet<Discipline>(value); }
        }

        public Teacher(string name, HashSet<Discipline> disciplines, string comment = "")
            : base(name, comment)
        {
            this.Name = name;
            this.ListOfDisciplines = disciplines;            
        }

        public Teacher()
            : this("NoName NoSurname", new HashSet<Discipline>(), "")
        {
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(string.Format("Teacher name: {0}\nComment: {1}\nDisciplines taught:\n", 
                                                                    this.Name, this.Comment));

            foreach (var item in ListOfDisciplines)
            {
                result.Append(item.Name + '\n');
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.listOfDisciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.listOfDisciplines.Remove(discipline);
        }
    }
}

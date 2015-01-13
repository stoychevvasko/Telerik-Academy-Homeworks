namespace _03.StudentsFirstBeforeLastName
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student()
            : this("NoName", "NoLastName", 255)
        {            
        }
    }
}

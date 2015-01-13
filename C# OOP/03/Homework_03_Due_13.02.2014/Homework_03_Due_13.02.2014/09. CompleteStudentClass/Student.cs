namespace _09.CompleteStudentClass
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string fName, string lName, string fN, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public Student()
            : this("NoName", "NoLastName", "", "", "", new List<int>(), 0)
        {
        }
    }
}

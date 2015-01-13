// chose strings because they're immutable

namespace _01.DefineClassStudent
{
    using System;
    using System.Text;

    public class Student
    {
        #region fields

        private string firstName;
        private string middleName;
        private string lastName;
        private string sSN;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;

        #endregion

        #region properties

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's first name cannot be a null or empty string!");
                }
                else if (value.Length > 15)
                {
                    throw new System.ArgumentOutOfRangeException("First name too long! Up to 15 characters allowed.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's middle name cannot be a null or empty string!");
                }
                else if (value.Length > 15)
                {
                    throw new System.ArgumentOutOfRangeException("Middle name too long! Up to 15 characters allowed.");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's last name cannot be a null or empty string!");
                }
                else if (value.Length > 15)
                {
                    throw new System.ArgumentOutOfRangeException("First name too long! Up to 15 characters allowed.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string SSN
        {
            get { return this.sSN; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's SSN cannot be a null or empty string!");
                }
                else if (value.Length != 9)
                {
                    throw new System.ArgumentOutOfRangeException("SSN must be exactly 9 digits long!");
                }                
                else
                {                    
                    this.sSN = value;
                }
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's permanent address cannot be a null or empty string!");
                }
                else if (value.Length > 50)
                {
                    throw new System.ArgumentOutOfRangeException("Student's address must be no more than 50 characters long!");
                }
                else
                {
                    this.permanentAddress = value;
                }
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's mobile phone number cannot be a null or empty string!");
                }
                else
                {
                    this.mobilePhone = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's email cannot be a null or empty string!");
                }
                else if ((!value.Contains("@") || (!value.Contains(".")) || value.Contains(" ")))
                {
                    // throw an exception if email has no @ or . chars or if it contains spaces

                    throw new System.ArgumentException("Invalid email address!");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public string Course
        {
            get { return this.course; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Student's course cannot be a null or empty string!");
                }
                else
                {
                    this.course = value;
                }
            }
        }

        public Specialties Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public Universities University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        #endregion

        #region constructors

        public Student(string fName, string mName, string lName, string sSN, string address, string mobilePhone,
            string email, string course, Specialties spec, Universities uni, Faculties faculty)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = sSN;
            this.PermanentAddress = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = spec;
            this.University = uni;
            this.Faculty = faculty;
        }

        public Student()
            : this
            (
                "NoFirstName",
                "NoMiddleName",
                "NoLastName",
                "000000000",
                "Country, City, Address",
                "0000 000 000",
                "email@domain.top",
                "default course",
                Specialties.DefaultSpecialty,
                Universities.DefaultUniversity,
                Faculties.DefaultFaculty
            )
        {
        }

        #endregion

        #region method overrides

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("First name:           {0}\n", this.FirstName));
            result.Append(string.Format("Middle name:          {0}\n", this.MiddleName));
            result.Append(string.Format("Last name:            {0}\n", this.LastName));
            result.Append(string.Format("SSN:                  {0}\n", this.SSN));
            result.Append(string.Format("Permanent address:    {0}\n", this.PermanentAddress));
            result.Append(string.Format("Mobile phone:         {0}\n", this.MobilePhone));
            result.Append(string.Format("Email:                {0}\n", this.Email));
            result.Append(string.Format("Course:               {0}\n", this.Course));
            result.Append(string.Format("Specialty:            {0}\n", this.Specialty));
            result.Append(string.Format("University:           {0}\n", this.University));
            result.Append(string.Format("Faculty:              {0}\n\n", this.Faculty));

            return result.ToString();
        }        

        public override bool Equals(Object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (this.FirstName == student.FirstName)
            {
                if (this.MiddleName == student.MiddleName)
                {
                    if (this.LastName == student.LastName)
                    {
                        if (this.SSN == student.SSN)
                        {
                            if (this.PermanentAddress == student.PermanentAddress)
                            {
                                if (this.MobilePhone == student.MobilePhone)
                                {
                                    if (this.Email == student.Email)
                                    {
                                        if (this.Course == student.Course)
                                        {
                                            if (this.Specialty == student.Specialty)
                                            {
                                                if (this.University == student.University)
                                                {
                                                    if (this.Faculty == student.Faculty)
                                                    {
                                                        return true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // if this code is reached it means that at least a single pair of corresponding properties were unequal

            return false;
        }

        public override int GetHashCode()
        {
            return (this.FirstName + this.MiddleName + this.LastName).GetHashCode() ^ this.SSN.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }

        #endregion

    }
}

// <copyright file="Student.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace Homework06
{
    using System;

    /// <summary>
    /// Represents a student.</summary>    
    public class Student
    {
        /// <summary>
        /// Holds the date of birth of a student.</summary>
        private DateTime? dateOfBirth;

        /// <summary>
        /// Holds the first name of a student.</summary>
        private string firstName;

        /// <summary>
        /// Holds the last name of a student.</summary>
        private string lastName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.</summary>
        public Student()
            : this("Default_First_Name", "Default_Last_Name", DateTime.Now)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Student"/> class.</summary>
        /// <param name="firstName">the first name of the student</param>
        /// <param name="lastName">the last name of the student</param>
        /// <param name="dateOfBirth">the date of birth of the student</param>
        public Student(string firstName, string lastName, DateTime? dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>Initializes a new instance of the <see cref="Student"/> class.</summary>
        /// <param name="firstName">the first name of the student</param>
        /// <param name="lastName">the last name of the student</param>
        public Student(string firstName, string lastName)
            : this(firstName, lastName, null)
        {
        }

        /// <summary>
        /// Gets or sets the date of birth of the student</summary>        
        public DateTime? DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            protected set
            {
                this.dateOfBirth = value;
            }
        }

        /// <summary>
        /// Gets or sets the first name of the student</summary>        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot assign null value to first name.");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentException("Cannot assign empty string to first name.");
                }

                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name of the student</summary>        
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot assign null value to last name.");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentException("Cannot assign empty string to last name.");
                }

                this.lastName = value;
            }
        }

        /// <summary>        
        /// Gets or sets additional information about a student.</summary>
        public string OtherInfo
        {
            get;
            set;
        }

        /// <summary>Returns true if this Student is older than the other Student passed as parameter.</summary>
        /// <param name="other">an instance of Student</param>
        /// <returns>Returns boolean result (true or false)</returns>
        public bool IsOlderThan(Student other)
        {
            DateTime? ownDateOfBirth = this.DateOfBirth;
            DateTime? otherDateOfBirth = other.DateOfBirth;

            if (ownDateOfBirth < otherDateOfBirth)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        /// <summary>Returns a Student as string value</summary>
        /// <returns>this.FirstName this.LastName this.DateOfBirth this.OtherInfo</returns>
        public string ToString()
        {
            string result = this.FirstName + " " + this.LastName + " born on " + this.DateOfBirth.Value.Date.ToString().Split(' ')[0] + " " + this.OtherInfo;
            return result;
        }
    }
}

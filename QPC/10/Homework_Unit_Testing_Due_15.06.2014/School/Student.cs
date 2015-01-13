// <copyright file="Student.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace School
{
    using System;    

    /// <summary>Represents a student.</summary>
    public class Student
    {
        /// <summary>Holds a default name value for the student class./// </summary>
        private const string DefaultName = "Default Student Name";
        
        /// <summary>Holds the current uniqueID number for new students.</summary>
        private static uint currentUniqueID = 10000;
        
        /// <summary>Contains the name of a student.</summary>
        private string name;

        /// <summary>Holds the unique number of the student.</summary>
        private uint uniqueID;

        /// <summary>Initializes a new instance of the <see cref="Student"/> class.</summary>
        public Student()
            : this(Student.DefaultName)
        {
        }
             
        /// <summary>Initializes a new instance of the <see cref="Student"/> class.</summary>
        /// <param name="name">student name</param>
        public Student(string name)
        {
            this.Name = name;
            this.uniqueID = Student.currentUniqueID;
            Student.currentUniqueID++;
            if (Student.currentUniqueID > 99999)
            {
                Student.currentUniqueID = 10000;
            }
        }

        /// <summary>Gets or sets the value of the name of a student.</summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student name cannot be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Student name cannot be empty string!");
                }

                this.name = value;
            }
        }

        /// <summary>Gets the unique ID number of a student.</summary>
        public uint UniqueID 
        {
            get
            {
                return this.uniqueID;
            }
        }
    }
}

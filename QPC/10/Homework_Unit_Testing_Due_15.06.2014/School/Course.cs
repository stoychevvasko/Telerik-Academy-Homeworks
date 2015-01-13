// <copyright file="Course.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace School
{
    using System;
    using System.Collections.Generic;

    /// <summary>Represents a course of study at school.</summary>
    public class Course
    {
        /// <summary>Holds a default name value for the course class./// </summary>
        private const string DefaultName = "Default Course Name";
        
        /// <summary>Holds the course name.</summary>
        private string name;

        /// <summary>Holds students in a course.</summary>
        private HashSet<Student> students;

        /// <summary>Initializes a new instance of the <see cref="Course"/> class.</summary>
        public Course()
            : this(Course.DefaultName)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Course"/> class.</summary>
        /// <param name="name">course name</param>
        public Course(string name)
        {
            this.Name = name;
            this.students = new HashSet<Student>();
        }

        /// <summary>Gets or sets the name of a course.</summary>        
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
                    throw new ArgumentNullException("Course name cannot be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Course name cannot be empty string!");
                }

                this.name = value;
            }
        }

        /// <summary>Tries to add a student to a course.</summary>
        /// <param name="student">student object instance</param>
        public void AddStudent(Student student)
        {
            this.students.Add(student);

            if (this.students.Count >= 30)
            {
                this.students.Remove(student);
                throw new ArgumentOutOfRangeException("Cannot more than 29 students to course!");
            }
        }

        /// <summary>Tries to remove a student from a course.</summary>
        /// <param name="student">student object instance</param>
        public void RemoveStudent(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("Cannot remove student! Not part of course.");
            }

            this.students.Remove(student);
        }
    }
}

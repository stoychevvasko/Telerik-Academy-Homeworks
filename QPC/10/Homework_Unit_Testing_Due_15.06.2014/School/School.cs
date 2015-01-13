// <copyright file="School.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace School
{
    using System;
    using System.Collections.Generic;

    /// <summary>Represents a school.</summary>
    public class School
    {
        /// <summary>Holds a default name value for the school class./// </summary>
        private const string DefaultName = "Default School Name";

        /// <summary>Holds the school name.</summary>
        private string name;

        /// <summary>Holds all courses currently available at a school.</summary>
        private HashSet<Course> courses;

        /// <summary>Initializes a new instance of the <see cref="School"/> class.</summary>
        /// <param name="name">school name parameter</param>
        public School(string name)
        {
            this.Name = name;
            this.courses = new HashSet<Course>();
        }

        /// <summary>Initializes a new instance of the <see cref="School"/> class.</summary>
        public School()
            : this(School.DefaultName)
        {
        }

        /// <summary>Gets or sets the name of a school.</summary>        
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
                    throw new ArgumentNullException("School name cannot be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("School name cannot be empty string!");
                }

                this.name = value;
            }
        }

        /// <summary>Tries to add a course to a school.</summary>
        /// <param name="course">course object instance</param>
        public void AddCourse(Course course)
        {
            this.courses.Add(course);            
        }

        /// <summary>Tries to remove a course from a school.</summary>
        /// <param name="course">course object instance</param>
        public void RemoveCourse(Course course)
        {
            if (!this.courses.Contains(course))
            {
                throw new ArgumentException("Cannot remove course! Not part of school.");
            }

            this.courses.Remove(course);
        }
    }
}

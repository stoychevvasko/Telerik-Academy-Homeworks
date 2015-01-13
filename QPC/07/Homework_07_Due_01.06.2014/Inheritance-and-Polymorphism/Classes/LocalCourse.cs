// <copyright file="LocalCourse.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>Represents a course of study done locally.</summary>
    public class LocalCourse
        : Course
    {
        /// <summary>Holds the lab name value for default constructor calls.</summary>
        public const string DefaultLabName = "DEFAULT_LAB_NAME";

        /// <summary>Holds the name of the local course lab.</summary>
        private string lab;
        
        /// <summary>Initializes a new instance of the <see cref="LocalCourse"/> class.</summary>
        /// <param name="courseName">the name of the <see cref="LocalCourse"/></param>
        public LocalCourse(string courseName)
            : this(courseName, Course.DefaultTeacherName)
        {            
        }

        /// <summary>Initializes a new instance of the <see cref="LocalCourse"/> class.</summary>
        /// <param name="courseName">the name of the local course</param>
        /// <param name="teacherName">the name of the teacher of the local course</param>
        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        /// <summary>Initializes a new instance of the <see cref="LocalCourse"/> class.</summary>
        /// <param name="courseName">the name of the local course</param>
        /// <param name="teacherName">the name of the teacher of the local course</param>
        /// <param name="students">the list of student names in the local course</param>
        public LocalCourse(string courseName, string teacherName, List<string> students)
            : base(courseName, teacherName, students)
        {            
            this.Lab = LocalCourse.DefaultLabName;
        }

        /// <summary>Gets the lab name of the local course</summary>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            internal set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot create local course! Null is an invalid lab name!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot create local course! Empty string is an invalid lab name!");
                }

                this.lab = value;
            }
        }

        /// <summary>Converts the information about the local course to string format.</summary>
        /// <returns>a string value</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}

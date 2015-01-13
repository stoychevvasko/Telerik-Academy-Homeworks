// <copyright file="OffsiteCourse.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>Represents a course of study done offsite.</summary>
    public class OffsiteCourse
        : Course
    {
        /// <summary>Holds the town name value for default constructor calls.</summary>
        public const string DefaultTownName = "DEFAULT_TOWN_NAME";

        /// <summary>Holds the name of the town where the offsite course takes place.</summary>
        private string town;

        /// <summary>Initializes a new instance of the <see cref="OffsiteCourse"/> class.</summary>
        /// <param name="courseName">the name of the offsite course</param>
        public OffsiteCourse(string courseName)
            : this(courseName, Course.DefaultTeacherName)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="OffsiteCourse"/> class.</summary>
        /// <param name="courseName">the name of the offsite course</param>
        /// <param name="teacherName">the name of the teacher of the offsite course</param>
        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        /// <summary>Initializes a new instance of the <see cref="OffsiteCourse"/> class.</summary>
        /// <param name="courseName">the name of the offsite course</param>
        /// <param name="teacherName">the name of the teacher of the offsite course</param>
        /// <param name="students">the list of student names in the offsite course</param>
        public OffsiteCourse(string courseName, string teacherName, List<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = OffsiteCourse.DefaultTownName;
        }

        /// <summary>Gets the name of the town where the offsite course takes place.</summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            internal set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot create offsite course! Null is an invalid town name!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot create offsite course! Empty string is an invalid town name!");
                }

                this.town = value;
            }
        }

        /// <summary>Converts the information about the offsite course to string format.</summary>
        /// <returns>a string value</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}

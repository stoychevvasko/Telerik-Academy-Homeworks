// <copyright file="Course.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    /// <summary>Represents a course of study.</summary>
    public class Course
    {
        /// <summary>Holds the course name value for default constructor calls.</summary>
        public const string DefaultCourseName = "DEFAULT_COURSE";

        /// <summary>Holds the teacher name value for default constructor calls.</summary>
        public const string DefaultTeacherName = "DEFAULT_TEACHER_NAME";
        
        /// <summary>Holds the name of the <see cref="Course"/>.</summary>
        private string name;

        /// <summary>Holds the name of the teacher of the <see cref="Course"/>.</summary>
        private string teacherName;
        
        /// <summary>Holds the list of students in the <see cref="Course"/>.</summary>
        private IList<string> students;

        /// <summary>Initializes a new instance of the <see cref="Course"/> class.</summary>
        public Course()
            : this(Course.DefaultCourseName, Course.DefaultTeacherName, new List<string>())
        {            
        }

        /// <summary>Initializes a new instance of the <see cref="Course"/> class./// </summary>
        /// <param name="courseName">the name of the <see cref="Course"/></param>
        /// <param name="teacherName">the name of the teacher of the <see cref="Course"/></param>
        public Course(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Course"/> class.</summary>
        /// <param name="courseName">the name of the <see cref="Course"/></param>
        /// <param name="teacherName">the name of the teacher of the <see cref="Course"/></param>
        /// <param name="students">the list of student names in the <see cref="Course"/></param>
        public Course(string courseName, string teacherName, List<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>Gets or sets the name of the <see cref="Course"/>.</summary>
        public string Name
        {
            get 
            { 
                return this.name; 
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot create course! Null is an invalid course name!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot create course! Empty string is an invalid course name!");
                }

                this.name = value;
            }
        }

        /// <summary>Gets the name of the teacher of the <see cref="Course"/>.</summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            internal set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot create course! Null is an invalid course teacher name!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot create course! Empty string is an invalid course teacher name!");
                }

                this.teacherName = value;
            }
        }

        /// <summary>Gets a copy of the list of student names in a <see cref="Course"/>.</summary>
        public List<string> Students
        {
            get 
            {                
                List<string> copyNewReferenceStudents = new List<string>();
                foreach (var item in this.students)
                {
                    copyNewReferenceStudents.Add(item);
                }

                return copyNewReferenceStudents;
            }

            internal set
            {
                this.students = new List<string>();
                foreach (var item in value)
                {
                    this.students.Add(item);
                }                
            }
        }

        /// <summary>Converts the list of students in a <see cref="Course"/> to a single string.</summary>
        /// <returns>string value of comma-separated names</returns>
        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }        
    }
}

// <copyright file="CourseClassTester.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace TestSchool
{
    using System;    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    /// <summary>Provides course testing functionality.</summary>
    [TestClass]
    public class CourseClassTester
    {
        /// <summary>Tests name setter for course objects.</summary>
        [TestMethod]
        public void TestCourseNameSetter()
        {
            var testCourse = new Course();

            testCourse.Name = "Course";

            Assert.AreEqual(testCourse.Name, "Course");
        }

        /// <summary>Tests exception handling upon entering null as course name.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestChangingCourseNameToNull()
        {
            var testCourse = new Course();

            testCourse.Name = null;

            Assert.AreNotEqual(null, testCourse.Name);
        }

        /// <summary>Tests exception handling upon entering empty string as course name.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangingCourseNameToEmptyString()
        {
            var testCourse = new Course();

            testCourse.Name = string.Empty;

            Assert.AreNotEqual(string.Empty, testCourse.Name);
        }

        /// <summary>Tests exception handling upon entering too many students to a single course.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddingTooManyStudentsToCourse()
        {
            var testCourse = new Course();

            for (int i = 0; i < 29; i++)
            {
                testCourse.AddStudent(new Student());
            }

            testCourse.AddStudent(new Student());
        }

        /// <summary>Tests exception handling upon attempting removal of non-existent student from course.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemovingNonExistentStudentFromCourse()
        {
            var testCourse = new Course();

            testCourse.RemoveStudent(new Student());
        }

        /// <summary>Tests removal of existent student from course.</summary>
        [TestMethod]
        public void TestRemovingExistingStudentFromCourse()
        {
            var testCourse = new Course();

            Student testStudent = new Student();
            testCourse.AddStudent(testStudent);
            testCourse.RemoveStudent(testStudent);
        }
    }
}
// <copyright file="SchoolClassTester.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace TestSchool
{
    using System;    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    /// <summary>Provides school testing functionality.</summary>
    [TestClass]
    public class SchoolClassTester
    {
        /// <summary>Tests name setter for school objects.</summary>
        [TestMethod]
        public void TestSchoolNameSetter()
        {
            var testSchool = new School();

            testSchool.Name = "TestSchool";

            Assert.AreEqual(testSchool.Name, "TestSchool");
        }

        /// <summary>Tests exception handling upon entering null as school name.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestChangingSchoolNameToNull()
        {
            var testSchool = new School();

            testSchool.Name = null;

            Assert.AreNotEqual(null, testSchool.Name);
        }

        /// <summary>Tests exception handling upon entering empty string as school name.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangingSchoolNameToEmptyString()
        {
            var testSchool = new School();

            testSchool.Name = string.Empty;

            Assert.AreNotEqual(string.Empty, testSchool.Name);
        }

        /// <summary>Tests exception handling upon attempting removal of non-existent course from school.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemovingNonExistentCourseFromSchool()
        {
            var testSchool = new School();

            testSchool.RemoveCourse(new Course());
        }

        /// <summary>Tests removal of existent course from school.</summary>
        [TestMethod]
        public void TestRemovingExistingCourseFromSchool()
        {
            var testSchool1 = new School();

            Course testCourse = new Course();
            testSchool1.AddCourse(testCourse);
            testSchool1.RemoveCourse(testCourse);            
        }
    }
}

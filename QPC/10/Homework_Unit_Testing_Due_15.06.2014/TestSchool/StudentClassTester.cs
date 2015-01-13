// <copyright file="StudentClassTester.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using School;
    
    /// <summary>Provides student testing functionality.</summary>
    [TestClass]
    public class StudentClassTester        
    {
        /// <summary>Tests name setter for student objects.</summary>
        [TestMethod]
        public void TestStudentNameSetter()
        {
            var testStudent = new Student();

            testStudent.Name = "Pesho";

            Assert.AreEqual(testStudent.Name, "Pesho");
        }

        /// <summary>Tests exception handling upon entering null as student name.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestChangingStudentNameToNull()
        {
            var testStudent = new Student();

            testStudent.Name = null;

            Assert.AreNotEqual(null, testStudent.Name);
        }

        /// <summary>Tests exception handling upon entering empty string as student name.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangingStudentNameToEmptyString()
        {
            var testStudent = new Student();

            testStudent.Name = string.Empty;

            Assert.AreNotEqual(string.Empty, testStudent.Name);
        }

        /// <summary>Tests if the correct default name value is assigned upon no-parameter constructor call.</summary>
        [TestMethod]
        public void TestDefaultParameterlessConstructor()
        {
            var testStudent = new Student();

            Assert.AreEqual("Default Student Name", testStudent.Name);
        }

        /// <summary>Tests if the correct name is assigned to new student upon constructor call with name parameter.</summary>
        [TestMethod]
        public void TestCreateNewStudentWithNameParameterConstructor()
        {
            var testStudent = new Student("Pesho");

            Assert.AreEqual("Pesho", testStudent.Name);
        }

        /// <summary>Tests if unique IDs are assigned properly to newly-created student objects.</summary>
        [TestMethod]
        public void TestUniqueIdAssignedToNewlyCreatedStudents()
        {
            var testStudent1 = new Student();
            var testStudent2 = new Student();

            Assert.AreNotEqual(testStudent1.UniqueID, testStudent2.UniqueID);
        }

        /// <summary>Tests the name getter of a student object.</summary>
        [TestMethod]
        public void TestStudentNameGetter()
        {
            var testStudent = new Student("Pesho");

            Assert.AreEqual(testStudent.Name, "Pesho");
        }
    }
}

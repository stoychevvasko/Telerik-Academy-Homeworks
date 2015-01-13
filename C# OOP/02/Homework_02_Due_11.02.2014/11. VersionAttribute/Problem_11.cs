/*

<Problem 11>

Create a [Version] attribute that can be applied to 
structures, classes, interfaces, enumerations and 
methods and holds a version in the format 
major.minor (e.g. 2.11). Apply the version 
attribute to a sample class and display its version at 
runtime.

 */

namespace _11.VersionAttribute
{
    using System;
    using System.Reflection;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]

    [VersionAttribute(1, 11)]
    public class VersionAttribute : System.Attribute
    {
        // fields

        private int minor;
        private int major;

        // properties       

        public int Major
        {
            get { return this.major; }
            private set { this.major = value; }
        }
        public int Minor
        {
            get { return this.minor; }
            private set { this.minor = value; }
        }

        // constructor

        public VersionAttribute(int maj, int min)
        {
            this.Major = maj;
            this.Minor = min;
        }
    }

    [VersionAttribute(2, 22)]
    public class TestClass
    {

    }
        
    class Problem_11
    {        
        static void Main()
        {
            var typesArray = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesArray)
            {
                Object[] attirbutes = type.GetCustomAttributes(false);

                foreach (var attr in attirbutes)
                {
                    if (attr is VersionAttribute)
                    {
                        Console.WriteLine("{0} v.{1}.{2}", type.Name, ((VersionAttribute)attr).Major, ((VersionAttribute)attr).Minor);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}


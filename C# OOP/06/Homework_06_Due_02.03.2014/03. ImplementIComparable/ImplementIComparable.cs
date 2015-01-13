/*

<Problem 03> 
 
 Implement the IComparable<Student> interface
 to compare students by name (first criterion, in
 lexicographic order) and by social security number
 (as second criterion, in increasing order).
 
*/
namespace _03.ImplementIComparable
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Globalization;

    class ImplementIComparable
    {
        private static void DoComparison(Student thisStudent, Student otherStudent)
        {
            Console.WriteLine();
            Console.WriteLine("thisStudent.CompareTo(OtherStudent) == {0,2}", thisStudent.CompareTo(otherStudent));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            // purge
            thisStudent = new Student();
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "ImplementIComparable";
            Console.SetWindowSize(50, 30);
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.BufferHeight = Console.WindowHeight = 30;

            // test on value-equal instances

            Student thisStudent = new Student();
            Student otherStudent = new Student();

            Console.WriteLine("test with value-equal instances");
            DoComparison(thisStudent, otherStudent);


            // test on instances with different first name only

            thisStudent.FirstName = "Aaron";

            Console.WriteLine("different first name only");
            DoComparison(thisStudent, otherStudent);// purge
            thisStudent = new Student();


            // test on instances with different middle name only

            thisStudent.MiddleName = "Zoltan";

            Console.WriteLine("different middle name only");
            DoComparison(thisStudent, otherStudent);


            // test on instances with differing last name only

            thisStudent.LastName = "Brown";

            Console.WriteLine("different last name only");
            DoComparison(thisStudent, otherStudent);


            // test on instances with differing SSN only

            thisStudent.SSN = "999999999";

            Console.WriteLine("different SSN name, same names");
            DoComparison(thisStudent, otherStudent);
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}

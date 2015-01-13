/*

<Problem 01> 
 
 Define a class Student, which contains data about a
 student - first, middle and last name, SSN, 
 permanent address, mobile phone, email, course, 
 specialty, university, faculty. Use an enumeration for
 the specialties, universities and faculties. Override
 the standard methods, inherited by
 System.Object: Equals(), ToString(), 
 GetHashCode() and operators == and !=.
   
*/

namespace _01.DefineClassStudent
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Globalization;    
    
    class DefineClassStudent
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "DefineClassStudent";
            Console.SetWindowSize(50, 49);
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.BufferHeight = Console.WindowHeight = 49;

            // test parameterless constructor

            Student testStudent1 = new Student();
            Student testStudent2 = new Student();

            Console.WriteLine("testStudent1 == testStudent2");
            Console.WriteLine();
            Console.WriteLine(testStudent1);

            // test constructor with parameters

            Student testStudent3 = new Student
                                       (
                                       "Ivan", 
                                       "Ivanov", 
                                       "Ivanov", 
                                       "123456789", 
                                       "Sofia 123 Margaritka street",
                                       "0888 888 888", 
                                       "ivan_ivanov@ivanov.com", 
                                       "first year", 
                                       Specialties.Medicine, 
                                       Universities.SofiaUniversity, 
                                       Faculties.MedicalFaculty
                                       );

            Console.WriteLine("testStudent3");
            Console.WriteLine();
            Console.WriteLine(testStudent3);

            // test Equals() override

            Console.WriteLine("Test for value equality:");
            Console.WriteLine();
            Console.WriteLine("testStudent1.Equals(testStudent2) == {0}", testStudent1.Equals(testStudent2));            
            Console.WriteLine("testStudent1.Equals(testStudent3) == {0}", testStudent1.Equals(testStudent3));
            Console.WriteLine();
            Console.WriteLine();

            // test GetHashCode() override

            Console.WriteLine("Hash codes:");
            Console.WriteLine();
            Console.WriteLine("testStudent1.GetHashCode() == {0}", testStudent1.GetHashCode());            
            Console.WriteLine("testStudent2.GetHashCode() == {0}", testStudent2.GetHashCode());
            Console.WriteLine("testStudent3.GetHashCode() == {0}", testStudent3.GetHashCode());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

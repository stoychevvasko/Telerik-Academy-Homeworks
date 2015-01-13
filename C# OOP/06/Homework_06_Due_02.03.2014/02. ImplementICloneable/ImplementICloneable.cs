/*

<Problem 02> 
 
 Add implementations of the ICloneable interface. 
 The Clone() method should deeply copy all object's
 fields into a new object of type Student.
   
*/

namespace _02.ImplementICloneable
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Globalization;    

    class ImplementICloneable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "ImplementICloneable";
            Console.SetWindowSize(50, 49);
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.BufferHeight = Console.WindowHeight = 49;


            Student original = new Student
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

            Console.WriteLine("Original student");
            Console.WriteLine();
            Console.WriteLine(original);

            Student clone = original.Clone() as Student;

            Console.WriteLine("Clone student");
            Console.WriteLine();
            Console.WriteLine(clone);

            // testing for reference equality

            Console.WriteLine();
            Console.WriteLine("Object.ReferenceEquals(original, clone) == {0}", Object.ReferenceEquals(original, clone));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

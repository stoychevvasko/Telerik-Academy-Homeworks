/*

<Problem 05>

Write a generic class GenericList<T> that keeps a 
list of elements of some parametric type T. Keep the 
elements of the list in an array with fixed capacity 
which is given as parameter in the class constructor. 
Implement methods for adding element, accessing 
element by index, removing element by index, 
inserting element at given position, clearing the list, 
finding element by its value and ToString(). 
Check all input parameters to avoid accessing 
elements at invalid positions.

*/

namespace _05.GenericClass
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Problem_05
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "05. GenericList";
            Console.SetWindowSize(60, 43);
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 43;
            
            // use parameterless constructor

            GenericList<int> testIntList1 = new GenericList<int>();
            Console.WriteLine();
            System.Console.WriteLine("testIntList1.Capacity: {0} (default value)", testIntList1.Capacity);
            System.Console.WriteLine();

            // use constructor with capacity passed as parameter

            GenericList<int> testIntList2 = new GenericList<int>(8);
            System.Console.WriteLine("testIntList2.Capacity: {0} (custom value)", testIntList2.Capacity);
            System.Console.WriteLine();

            string lineBr = new string('=', 60);
            
            // add elements

            for (int i = 0; i < 16; i++)
            {
                testIntList2.Add(i * i);
            }

            // show added elements with ToString()

            Console.WriteLine(lineBr);
            Console.WriteLine("testIntList2 after adding integers:\n\n" + testIntList2.ToString());
            Console.WriteLine();
            Console.WriteLine("testIntList2.Capacity: " + testIntList2.Capacity);
            Console.WriteLine();            

            // remove elements

            for (int i = 0; i < 8; i++)
            {
                testIntList2.Remove(i);                
            }

            Console.WriteLine(lineBr);
            Console.WriteLine("testIntList2 after removing entries:\n\n" + testIntList2.ToString());            
            Console.WriteLine();                        

            // insert elements

            Console.WriteLine(lineBr);
            testIntList2.Insert(2222, 5);
            Console.WriteLine("Inserted 2222 at position 5\n\n" + testIntList2.ToString());
            Console.WriteLine();

            // find element by value

            Console.WriteLine(lineBr);
            Console.WriteLine("find 2222's position in testIntList2\n");
            Console.WriteLine("2222's position is {0}", testIntList2.Find(2222));
            Console.WriteLine();

            // clear list

            Console.WriteLine(lineBr);
            testIntList2.Clear();
            Console.WriteLine("testIntList2 after Clear()\n\n" + testIntList2.ToString());
            Console.WriteLine();
            Console.WriteLine(lineBr);
            Console.WriteLine();

        }
    }
}

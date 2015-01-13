/*

<Problem 05> 
 
 Define a class BitArray64 to hold 64-bit values inside
 an ulong value. Implement IEnumerable<int> and
 Equals(), GetHashCode(), [], == and !=.
 
*/

namespace _05.DefineClassBitArray64
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Globalization;

    class DefineClassBitArray64
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "DefineClassBitArray64";
            Console.SetWindowSize(50, 32);
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.BufferHeight = Console.WindowHeight = 32;


            BitArray64 testBitArray1 = new BitArray64(123);
            BitArray64 testBitArray2 = new BitArray64(123);
            BitArray64 testBitArray3 = new BitArray64(12345);

            // test foreach (IEnumerable<int> implementation)

            Console.WriteLine("Test IEnumerable<int>:");

            foreach (var item in testBitArray1)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine();

            // test Equals()

            Console.WriteLine("Test Equals():");
            Console.WriteLine("testBitArray1.Equals(testBitArray2) == {0}", testBitArray1.Equals(testBitArray2));
            Console.WriteLine("testBitArray1.Equals(testBitArray3) == {0}", testBitArray1.Equals(testBitArray3));
            Console.WriteLine("testBitArray2.Equals(testBitArray3) == {0}", testBitArray2.Equals(testBitArray3));
            Console.WriteLine();

            // test == operator overload

            Console.WriteLine("Test == operator overload");
            Console.WriteLine("(testBitArray1 == testBitArray2) == {0}", testBitArray1 == testBitArray2);
            Console.WriteLine("(testBitArray1 == testBitArray3) == {0}", testBitArray1 == testBitArray3);
            Console.WriteLine("(testBitArray2 == testBitArray3) == {0}", testBitArray2 == testBitArray3);
            Console.WriteLine();

            // test != operator overload

            Console.WriteLine("Test != operator overload");
            Console.WriteLine("(testBitArray1 != testBitArray2) == {0}", testBitArray1 != testBitArray2);
            Console.WriteLine("(testBitArray1 != testBitArray3) == {0}", testBitArray1 != testBitArray3);
            Console.WriteLine("(testBitArray2 != testBitArray3) == {0}", testBitArray2 != testBitArray3);
            Console.WriteLine();

            // test GetHashCode()

            Console.WriteLine("Test GetHashCode()");
            Console.WriteLine("testBitArray1.GetHashCode() == {0}", testBitArray1.GetHashCode());
            Console.WriteLine("testBitArray2.GetHashCode() == {0}", testBitArray2.GetHashCode());
            Console.WriteLine("testBitArray3.GetHashCode() == {0}", testBitArray3.GetHashCode());
            Console.WriteLine();

            // test indexer []

            Console.WriteLine("Test indexer");            
            Console.WriteLine("testBitArray1[0]  == {0}", testBitArray1[0]);
            Console.WriteLine("testBitArray1[63] == {0}", testBitArray1[63]);
            Console.WriteLine("testBitArray1[62] == {0}", testBitArray1[62]);
            Console.WriteLine("testBitArray1[61] == {0}", testBitArray1[61]);
            
            // test index out of range exception throw
            // Console.WriteLine("testBitArray1[68] == {0}", testBitArray1[68]);

            Console.WriteLine();
            Console.WriteLine();            
        }
    }
}

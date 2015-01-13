/*

<Problem 07>

Using delegates write a class Timer that has can 
execute certain method at each t seconds.

*/

namespace _07.WriteClassTimer
{
    using System;
    
    class WriteClassTimer
    {
        static void TestMethod()
        {
            Console.WriteLine("I did something using a timer.");
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Title = "07.WriteClassTimer";
            Console.SetWindowSize(35, 20);
            Console.BufferWidth = Console.WindowWidth = 35;
            Console.BufferHeight = Console.WindowHeight = 20;

            
            Timer timer = new Timer();
            timer.method = TestMethod;
            timer.Play(250,2);

                        
            Console.WriteLine();
            Console.ReadKey();            
        }
    }
}

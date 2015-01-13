/*

<Problem 08>

* Read in MSDN about the keyword event in C# and 
how to publish events. Re-implement the above 
using .NET events and following the best practices.

*/

namespace _08.TimerWithEvents
{
    using System;

    class TimerWithEvents
    {
        static void Main()
        {
            Console.Title = "08.TimerWithEvents";
            Console.SetWindowSize(60, 20);
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 20;


            PublisherClass publisher = new PublisherClass();
            SubscriberClass subscriber = new SubscriberClass();
            subscriber.Subscribe(publisher);
            publisher.Execute(250,2);

                        
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

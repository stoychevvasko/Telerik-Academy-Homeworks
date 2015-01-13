using System;

namespace _08.TimerWithEvents
{
    public class SubscriberClass
    {
        public void Subscribe(PublisherClass publisher)
        {
            publisher.Tick += new PublisherClass.EventHandler(TakeAction);
        }

        private void TakeAction(PublisherClass publisher, EventArgs e)
        {
            System.Console.WriteLine("An event was raised. A subscriber method took action.");
            Console.WriteLine();
        }
    }
}


namespace _08.TimerWithEvents
{
    using System;
    using System.Threading;

    public class PublisherClass
    {
        public event EventHandler Tick;        

        public delegate void EventHandler(PublisherClass publisher, EventArgs e);

        public void Execute(int interval, int durationInSeconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(durationInSeconds);

            while (start <= end)
            {                
                Thread.Sleep(interval);
                start = DateTime.Now;

                if (Tick != null)
                {
                    Tick(this, EventArgs.Empty);
                }
            }            
        }
    }
}


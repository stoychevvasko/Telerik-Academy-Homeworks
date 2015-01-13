namespace _07.WriteClassTimer
{
    using System;
    using System.Threading;
    
    class Timer
    {
        public delegate void MethodFed();

        public MethodFed method;

        public void Play(int interval, int durationInSeconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(durationInSeconds);

            while (start <= end)
            {
                method();
                Thread.Sleep(interval);
                start = DateTime.Now;
            }
        }
    }
}

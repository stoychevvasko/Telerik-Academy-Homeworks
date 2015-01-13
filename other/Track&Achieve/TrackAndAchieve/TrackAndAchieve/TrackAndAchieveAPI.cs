// <copyright file="TrackAndAchieveAPI.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;
    using TrackAndAchieve.Classes;

    /// <summary>Contains the Main() method where execution begins.</summary>
    public class TrackAndAchieveAPI
    {
        /// <summary>Begins program execution.</summary>
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.SetWindowSize(70, 60);
            Console.Title = "Track & Achieve";
            DailyAgenda todaysAgenda = AgendaBuilder.GenerateCompleteAgenda();
            Console.WriteLine(todaysAgenda);
        }
    }
}

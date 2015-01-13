// <copyright file="AgendaBuilder.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes
{
    using System;
    using System.Text;
    using TrackAndAchieve.Interfaces;

    /// <summary>Contains ready-made functionality to supplement the DailyAgenda.cs class.</summary>
    public class AgendaBuilder
    {
        /// <summary>Generates a new DailyAgenda for the current day without any goals or tasks added.</summary>
        /// <returns>a DailyAgenda instance</returns>
        public static DailyAgenda GenerateBlankAgenda()
        {
            string agendaName = AgendaBuilder.GenerateAgendaName();
            DailyAgenda result = new DailyAgenda(agendaName);
            return result;
        }

        /// <summary>Generates a new DailyAgenda for the current day complete with pre-made goals and tasks.</summary>
        /// <returns>a DailyAgenda instance</returns>
        public static DailyAgenda GenerateCompleteAgenda()
        {
            DailyAgenda result = AgendaBuilder.GenerateBlankAgenda();
            result.PushGoal(new Goal("Study"));
            result.Goals[0].PushTask(new Task("Study for 3+ hours"));
            result.PushGoal(new Goal("Food & water"));
            result.Goals[1].PushTask(new Task("Track food intake"));
            result.Goals[1].PushTask(new Task("Track water intake"));
            result.PushGoal(new Goal("Exercise"));
            result.Goals[2].PushTask(new Task("Exercise for 1 hour"));
            result.PushGoal(new Goal("Go outdoors"));
            result.Goals[3].PushTask(new Task("Walk among trees for 30+ minutes"));
            result.Goals[3].PushTask(new Task("Exercise eyes"));
            result.PushGoal(new Goal("R&R"));
            result.Goals[4].PushTask(new Task("Track sleep patterns & dreams in journal"));
            result.Goals[4].PushTask(new Task("Practice reality checks"));
            result.PushGoal(new Goal("Read"));
            result.Goals[5].PushTask(new Task("Read a book for 22+ minutes"));
            result.Goals[5].PushTask(new Task("Track pages & books read"));
            result.PushGoal(new Goal("Reflect"));
            result.Goals[6].PushTask(new Task("Worship"));
            result.Goals[6].PushTask(new Task("Meditate"));
            result.Goals[6].PushTask(new Task("Do a journal entry"));
            result.PushGoal(new Goal("Communicate"));
            result.Goals[7].PushTask(new Task("Do 11 minutes of mirror practice"));
            result.Goals[7].PushTask(new Task("Connect socially"));            
            result.PushGoal(new Goal("Play"));
            result.Goals[8].PushTask(new Task("Play the piano for 13+ minutes"));
            result.PushGoal(new Goal("Purify"));
            result.Goals[9].PushTask(new Task("Clean house for 15 minutes"));
            result.Goals[9].PushTask(new Task("Track personal hygiene"));            
            result.PushGoal(new Goal("Transform"));
            result.Goals[10].PushTask(new Task("Establish control system"));
            result.Goals[10].PushTask(new Task("Subvert usurper"));            
            return result;
        }

        /// <summary>Generates an agenda name for today.</summary>
        /// <returns>a string value</returns>
        private static string GenerateAgendaName()
        {
            string agendaName = string.Format(
                "Daily Agenda for {0}, {1}/{2}/{3}",
                DateTime.Now.DayOfWeek,
                DateTime.Now.Day.ToString("D2"),
                DateTime.Now.Month.ToString("D2"),
                DateTime.Now.Year.ToString("D4"));
            return agendaName;
        }
    }
}

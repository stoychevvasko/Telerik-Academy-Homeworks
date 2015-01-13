// <copyright file="DailyAgenda.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TrackAndAchieve.Interfaces;

    /// <summary>Represents a set of goals for a single day.</summary>
    public class DailyAgenda
        : AnnotatedObject, ICommentable, ICloneable
    {
        /// <summary>Default DailyAgenda name value for constructor use.</summary>
        public new const string DefaultName = "DEFAULT_DAILY_AGENDA";

        /// <summary>Contains a value between 0 and 1 representing to what extent the daily agenda was completed.</summary>
        private decimal performance;

        /// <summary>Contains the goals that comprise this daily agenda.</summary>
        private IList<Goal> goals;

        /// <summary>Initializes a new instance of the DailyAgenda class.</summary>
        /// <param name="nameArg">the name of the daily agenda</param>
        public DailyAgenda(string nameArg)
            : this(nameArg, 0.0M)
        {
        }

        /// <summary>Initializes a new instance of the DailyAgenda class.</summary>
        public DailyAgenda()
            : this(DailyAgenda.DefaultName, 0)
        {
        }

        /// <summary>Initializes a new instance of the DailyAgenda class * privately * .</summary>
        /// <param name="nameArg">the name of the daily agenda</param>
        /// <param name="progressArg">a value from 0 to 1 for the percentage progress of the daily agenda</param>
        private DailyAgenda(string nameArg, decimal progressArg)
            : base(nameArg)
        {
            this.Performance = progressArg;
            this.Goals = new List<Goal>();
            this.AddComment("DailyAgenda instance initialized.");
        }

        /// <summary>Gets or sets the progress private field value.</summary>
        public decimal Performance
        {
            get
            {
                this.UpdatePerformance();
                return this.performance;
            }

            protected set
            {
                if (value < 0 || 1M < value)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Progress must be in the [0,1] range!");
                }

                this.performance = value;                
            }
        }

        /// <summary>Gets or sets the goals private field value.</summary>
        public IList<Goal> Goals
        {
            get
            {
                var copy = new List<Goal>();
                foreach (var item in this.goals)
                {
                    copy.Add(item);
                }

                return copy;
            }

            protected set
            {
                this.goals = new List<Goal>();
                foreach (var item in value)
                {
                    this.goals.Add(item);
                }
            }
        }

        /// <summary>Adds a goal to the end of the list of goals in this DailyAgenda instance.</summary>
        /// <param name="goalArg">an argument of Goal type</param>
        public void PushGoal(Goal goalArg)
        {
            Goal clone = (Goal)goalArg.Clone();
            this.goals.Add(clone);            
            this.AddComment(string.Format("Goal {0} added to DailyAgenda {1}.", clone.Name, this.Name));
            this.UpdatePerformance();
        }

        /// <summary>Removes and returns the last item from the list of goals in this DailyAgenda instance.</summary>
        /// <returns>a new Goal object</returns>
        public Goal PopGoal()
        {
            Goal result = null;
            int indexOfLastElement = this.Goals.Count - 1;
            if (this.Goals.Count > 0)
            {
                result = (Goal)this.Goals[indexOfLastElement].Clone();
            }

            this.goals.RemoveAt(indexOfLastElement);
            this.AddComment(string.Format("Goal {0} removed from DailyAgenda {1}.", result.Name, this.Name));
            this.UpdatePerformance();
            return result;
        }
        
        /// <summary>Converts a daily agenda to its string representation.</summary>
        /// <returns>a string value containing information about this daily agenda</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine();
            result.AppendLine();
            result.AppendLine("           " + this.Name);
            result.AppendLine();
            if (this.Goals.Count > 0)
            {
                result.AppendLine();
                for (int i = 0; i < this.Goals.Count; i++)
                {
                    string line = this.Goals[i].ToString();
                    result.Append(line);
                    if (i != this.Goals.Count - 1)
                    {
                        result.AppendLine();
                    }
                }
            }

            result.AppendLine();
            result.AppendLine();
            result.AppendLine(string.Format("                      Performance: {0} %", Math.Round(this.Performance * 100.0M, 2)));
            result.AppendLine();
            ////if (this.Comments.Length > 0)
            ////{
            ////    result.AppendLine("Daily Agenda comments:");
            ////    foreach (var item in this.Comments.Split('\n'))
            ////    {
            ////        result.AppendLine(" " + item);
            ////    }
            ////}

            return result.ToString();
        }

        /// <summary>Recalculates and reassigns the Daily Agenda Performance percentage value.</summary>
        private void UpdatePerformance()
        {
            if (this.Goals != null)
            {                
                decimal numberOfGoalsInAgenda = (decimal)this.Goals.Count;
                if (numberOfGoalsInAgenda <= 0)
                {
                    this.Performance = 0.0M;
                    return;
                }

                decimal result = 0.0M;
                for (int i = 0; i < this.Goals.Count; i++)
                {
                    result += this.Goals[i].Progress;
                }

                this.Performance = decimal.Divide(result, numberOfGoalsInAgenda);
            }
        }
    }
}

// <copyright file="Goal.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TrackAndAchieve.Interfaces;

    /// <summary>Represents a goal and the tools for tracking it.</summary>
    public class Goal
        : AnnotatedObject, ICommentable, ICloneable
    {
        /// <summary>Default goal name value for constructor use.</summary>
        public new const string DefaultName = "DEFAULT_GOAL";

        /// <summary>Contains a value between 0 and 1 representing the level of success in achieving a goal.</summary>
        private decimal progress;

        /// <summary>Contains the tasks that comprise this goal.</summary>
        private IList<Task> tasks;

        /// <summary>Initializes a new instance of the Goal class.</summary>
        /// <param name="nameArg">the name of the goal</param>
        public Goal(string nameArg)
            : this(nameArg, 0.0M)
        {
        }

        /// <summary>Initializes a new instance of the Goal class.</summary>
        public Goal()
            : this(Goal.DefaultName, 0.0M)
        {
        }

        /// <summary>Initializes a new instance of the Goal class * privately * .</summary>
        /// <param name="nameArg">the name of the goal</param>
        /// <param name="progressArg">a value from 0 to 1 for the percentage progress of the goal</param>
        private Goal(string nameArg, decimal progressArg)
            : base(nameArg)
        {
            this.Progress = progressArg;
            this.Tasks = new List<Task>();
            this.AddComment("Goal instance initialized.");
        }

        /// <summary>Gets or sets the progress private field value.</summary>
        public decimal Progress
        {
            get
            {
                this.UpdateProgress();
                return this.progress;
            }

            protected set
            {
                if (value < 0.0M || 1.0M < value)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Progress must be in the [0,1] range!");
                }

                this.progress = value;
            }
        }

        /// <summary>Gets or sets the tasks private field value.</summary>
        public IList<Task> Tasks
        {
            get
            {
                var copy = new List<Task>();
                foreach (var item in this.tasks)
                {
                    copy.Add(item);
                }

                return copy;
            }

            protected set
            {
                this.tasks = new List<Task>();
                foreach (var item in value)
                {
                    this.tasks.Add(item);
                }

                this.UpdateProgress();
            }
        }

        /// <summary>Create a clone of this Goal instance.</summary>
        /// <returns>a new instance with a new reference and identical values</returns>
        public new object Clone()
        {
            Goal clone = new Goal(this.Name, this.Progress);
            foreach (var item in this.Tasks)
            {
                clone.PushTask((Task)item.Clone());
            }

            clone.ClearComments();
            clone.AddComment(string.Format("Cloned from {0}.", this.Name));
            return clone;
        }

        /// <summary>Adds a task to the end of the list of tasks in this Goal instance.</summary>
        /// <param name="taskArg">an argument of Task type</param>
        public void PushTask(Task taskArg)
        {
            Task clone = (Task)taskArg.Clone();
            this.tasks.Add(clone);
            this.AddComment(string.Format("Task {0} added to Goal {1}.", clone.Name, this.Name));
            this.UpdateProgress();
        }

        /// <summary>Removes and returns the last item from the list of tasks in this Goal instance.</summary>
        /// <returns>a new Task object</returns>
        public Task PopTask()
        {
            Task result = new Task(this.tasks[this.tasks.Count - 1].Name);
            if (this.tasks[this.tasks.Count - 1].IsCompleted == true)
            {
                result.Complete();
            }

            this.tasks.RemoveAt(this.tasks.Count - 1);

            return result;
        }

        /// <summary>Converts a goal to its string representation.</summary>
        /// <returns>a string value containing information about this goal</returns>
        public override string ToString()
        {
            this.UpdateProgress();
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format(
                " {0,-45}{1} Goal     {2} %",
                this.Name,
                this.Progress >= 0.5M ? this.Progress >= 0.75M ? "Master" : "Expert" : this.Progress >= 0.25M ? "Apprentice" : "Novice",
                Math.Round(this.Progress * 100.0M, 2)));

            if (this.Tasks.Count > 0)
            {
                for (int i = 0; i < this.Tasks.Count; i++)
                {
                    string line = this.Tasks[i].ToString();
                    result.Append(line);
                }
            }

            ////if (this.Comments.Length > 0)
            ////{
            ////    result.AppendLine("  Goal comments:");
            ////    foreach (var item in this.Comments.Split('\n'))
            ////    {
            ////        result.AppendLine("   " + item);
            ////    }
            ////}

            return result.ToString();
        }

        /// <summary>Recalculates and reassigns the Goal Progress percentage value.</summary>
        private void UpdateProgress()
        {
            decimal numberOfTasksInGoal = (decimal)this.Tasks.Count;
            decimal singleTaskCompletionSummand;
            if (numberOfTasksInGoal == 0.0M)
            {
                singleTaskCompletionSummand = 0.0M;
            }
            else
            {
                singleTaskCompletionSummand = decimal.Divide(1.0M, numberOfTasksInGoal);
            }

            decimal result = 0.0M;
            foreach (var item in this.Tasks)
            {
                if (item.IsCompleted == true)
                {
                    result = result + singleTaskCompletionSummand;
                }
            }

            this.Progress = result;
        }
    }
}

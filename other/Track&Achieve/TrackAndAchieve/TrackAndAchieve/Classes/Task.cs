// <copyright file="Task.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes
{
    using System;
    using System.Text;
    using TrackAndAchieve.Interfaces;

    /// <summary>Represents a single task within a larger goal.</summary>
    public class Task
        : AnnotatedObject, ICommentable, ICloneable
    {
        /// <summary>Default task name value for constructor use.</summary>
        public new const string DefaultName = "DEFAULT_TASK";

        /// <summary>Contains a boolean value for the progress state of this task.</summary>
        private bool isCompleted;

        /// <summary>Initializes a new instance of the Task class.</summary>
        /// <param name="nameArg">the name of the task</param>
        public Task(string nameArg)
            : base(nameArg)
        {
            this.IsCompleted = false;
            this.AddComment("Task instance initialized.");
        }

        /// <summary>Initializes a new instance of the Task class.</summary>
        public Task()
            : this(Task.DefaultName)
        {
        }

        /// <summary>Gets or sets a value indicating whether this task is completed.</summary>
        public bool IsCompleted
        {
            get
            {
                return this.isCompleted;
            }

            protected set
            {
                this.isCompleted = value;
            }
        }

        /// <summary>Create a clone of this Task instance.</summary>
        /// <returns>a new instance with a new reference and identical values</returns>
        public new object Clone()
        {
            Task clone = new Task(this.Name);
            clone.IsCompleted = this.IsCompleted;
            clone.ClearComments();
            clone.AddComment(string.Format("Cloned from {0}.", this.Name));
            return clone;
        }

        /// <summary>Completes a task successfully.</summary>
        public void Complete()
        {
            this.IsCompleted = true;
            this.AddComment("Task completed successfully.");
        }

        /// <summary>Converts a task to its string representation.</summary>
        /// <returns>a string value containing information about this task</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();            
            result.AppendLine(string.Format(" * {0,-45}{1}", this.Name, this.IsCompleted ? "[V] Completed" : "[ ] Not Finished"));
            ////if (this.Comments.Length > 0)
            ////{
            ////    result.AppendLine("    Task comments:");
            ////    foreach (var item in this.Comments.Split('\n'))
            ////    {
            ////        string line = item.ToString();
            ////        if (line.Length > 0)
            ////        {
            ////            result.AppendLine("     " + line);
            ////        }
            ////    }
            ////}

            return result.ToString();
        }
    }
}

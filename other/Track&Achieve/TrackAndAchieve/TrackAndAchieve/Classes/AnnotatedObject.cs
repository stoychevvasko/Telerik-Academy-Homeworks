// <copyright file="AnnotatedObject.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes
{
    using System;
    using System.Text;
    using TrackAndAchieve.Interfaces;

    /// <summary>Represents an object that can be commented.</summary>
    public class AnnotatedObject
        : ICommentable, ICloneable
    {
        /// <summary>Default task name value for constructor use.</summary>
        public const string DefaultName = "DEFAULT_PROTO_OBJECT";

        /// <summary>Contains the character representation of the comments made so far.</summary>
        private StringBuilder commentsStringBuilder;

        /// <summary>Contains a string value for the name of this task.</summary>
        private string name;

        /// <summary>Initializes a new instance of the AnnotatedObject class.</summary>
        /// <param name="nameArg">name of the AnnotatedObject instance</param>
        /// <param name="commentsArg">comments of the AnnotatedObject</param>
        public AnnotatedObject(string nameArg, string commentsArg)
            : this(nameArg)
        {
            this.Comments = commentsArg;            
        }

        /// <summary>Initializes a new instance of the AnnotatedObject class.</summary>
        /// <param name="nameArg">name of the AnnotatedObject instance</param>
        public AnnotatedObject(string nameArg)
        {
            this.Name = nameArg;
            this.Comments = null;
            ////this.AddComment("AnnotatedObject instance initialized.");            
        }

        /// <summary>Initializes a new instance of the AnnotatedObject class.</summary>
        public AnnotatedObject()
            : this(AnnotatedObject.DefaultName)
        {            
        }

        /// <summary>Gets or sets the content of an object with comments.</summary>
        public string Comments
        {
            get
            {
                return this.commentsStringBuilder.ToString();
            }

            protected set
            {
                if (value == null || value.Length == 0)
                {
                    this.commentsStringBuilder = new StringBuilder();
                }
                else
                {
                    this.commentsStringBuilder = new StringBuilder(value);
                }
            }
        }

        /// <summary>Gets or sets the name private field value.</summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot assign null as object name!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot assign empty string as object name!");
                }

                this.name = value.Trim();
            }
        }

        /// <summary>Adds a comment to an object with comments as a new comment line.</summary>
        /// <param name="commentArg">comment as string value</param>
        public void AddComment(string commentArg)
        {
            StringBuilder result = new StringBuilder();
            if (this.Comments.Length > 0)
            {
                result.AppendLine(this.Comments);
            }

            result.Append(string.Format(
                "{0}/{1}/{2} {3}:{4}:{5,2}:{6,3} ms > {7}",
                DateTime.Now.Day.ToString("D2"),
                DateTime.Now.Month.ToString("D2"),
                DateTime.Now.Year.ToString("D4"),
                DateTime.Now.Hour.ToString("D2"),
                DateTime.Now.Minute.ToString("D2"),
                DateTime.Now.Second.ToString("D2"),
                DateTime.Now.Millisecond.ToString("D3"),
                commentArg));
            this.Comments = result.ToString();
        }

        /// <summary>Deletes all comments for this object with comments.</summary>
        public void ClearComments()
        {
            this.Comments = string.Empty;
        }
        
        /// <summary>Converts an object with comments to its string representation.</summary>
        /// <returns>a string value containing information about this object with comments</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("AnnotatedObject");
            result.AppendLine(string.Format(" Name: {0}", this.Name));
            ////if (this.Comments.Length > 0)
            ////{
            ////    result.AppendLine(" Comments:");
            ////    foreach (var item in this.Comments.Split('\n'))
            ////    {
            ////        result.AppendLine(" " + item);
            ////    }
            ////}

            return result.ToString();
        }

        /// <summary>Create a clone of this AnnotatedObject.</summary>
        /// <returns>a new instance with a new reference and identical values</returns>
        public object Clone()
        {
            AnnotatedObject clone = new AnnotatedObject(this.Name, this.Comments);
            return clone;
        }
    }
}

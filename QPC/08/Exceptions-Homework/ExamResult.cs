// <copyright file="ExamResult.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace ExceptionsHomeworkProject
{
    using System;

    /// <summary>Represents the results of taking an exam.</summary>
    public class ExamResult
    {
        /// <summary>Initializes a new instance of the <see cref="ExamResult"/> class.</summary>
        /// <param name="grade">Exam grade</param>
        /// <param name="minGrade">Exam minimum grade</param>
        /// <param name="maxGrade">Exam maximum grade</param>
        /// <param name="comments">Exam additional comments</param>
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentOutOfRangeException("Grade cannot be negative!");
            }

            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum grade cannot be negative!");
            }

            if (maxGrade < minGrade)
            {
                throw new ArgumentOutOfRangeException("Minimum grade cannot be breater than maximum grade!");
            }

            if (comments == null || comments == string.Empty)
            {
                throw new ArgumentNullException("Comments cannot be null or empty string!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        /// <summary>Gets the grade of an exam.</summary>
        public int Grade { get; private set; }

        /// <summary>Gets the minimal grade of an exam.</summary>
        public int MinGrade { get; private set; }

        /// <summary>Gets the maximum grade of an exam.</summary>
        public int MaxGrade { get; private set; }

        /// <summary>Gets additional comments about an exam.</summary>
        public string Comments { get; private set; }        
    }
}
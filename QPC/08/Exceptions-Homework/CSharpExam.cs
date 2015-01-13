// <copyright file="CSharpExam.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace ExceptionsHomeworkProject
{
    using System;

    /// <summary>Represents an exam.</summary>
    public class CSharpExam : Exam
    {
        /// <summary>Initializes a new instance of the <see cref="CSharpExam"/> class.</summary>
        /// <param name="score">score parameter</param>
        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException("Score cannot be negative!");
            }

            this.Score = score;
        }

        /// <summary>Gets the average score of the exam</summary>
        public int Score { get; private set; }

        /// <summary>Calculates exam results.</summary>
        /// <returns>ExamResults object</returns>
        public override ExamResult Check()
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new ArgumentOutOfRangeException("Score cannot be outside the [0, 100] range!");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
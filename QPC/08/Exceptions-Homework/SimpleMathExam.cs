// <copyright file="SimpleMathExam.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace ExceptionsHomeworkProject
{
    using System;

    /// <summary>Represents a Math exam.</summary>
    public class SimpleMathExam : Exam
    {
        /// <summary>Initializes a new instance of the <see cref="SimpleMathExam"/> class.</summary>
        /// <param name="problemsSolved">number of problems solved</param>
        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved <= 0)
            {
                throw new ArgumentOutOfRangeException("Number of problems cannot be non-positive!");
            }

            if (problemsSolved > 10)
            {
                throw new ArgumentOutOfRangeException("Cannot create an exam with more than 10 problems!");
            }

            this.ProblemsSolved = problemsSolved;
        }

        /// <summary>Gets the number of problems solved.</summary>
        public int ProblemsSolved { get; private set; }

        /// <summary>Calculates exam results.</summary>
        /// <returns>ExamResults object</returns>
        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            throw new ArgumentOutOfRangeException("Invalid number of problems solved!");            
        }
    }
}
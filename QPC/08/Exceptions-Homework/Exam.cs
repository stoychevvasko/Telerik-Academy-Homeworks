// <copyright file="Exam.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace ExceptionsHomeworkProject
{
    using System;

    /// <summary>Represents an exam./// </summary>
    public abstract class Exam
    {
        /// <summary>Calculates exam results.</summary>
        /// <returns>ExamResults object</returns>
        public abstract ExamResult Check();
    }
}
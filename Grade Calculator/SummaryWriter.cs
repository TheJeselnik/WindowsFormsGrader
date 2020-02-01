using System;
using System.Collections.Generic;

namespace Grade_Calculator
{
    /// <summary>
    /// Writes the Summary Output for the Grade Calculator Form
    /// </summary>
    public class SummaryWriter
    {
        /// <summary>
        /// Gets or sets the assignment grade entries.
        /// </summary>
        /// <value>
        /// The assignment grade entries.
        /// </value>
        public Dictionary<double, string> AssignmentGradeEntries { get; set; }

        /// <summary>
        /// Gets or sets the quiz grade entries.
        /// </summary>
        /// <value>
        /// The quiz grade entries.
        /// </value>
        public Dictionary<double, string> QuizGradeEntries { get; set; }

        /// <summary>
        /// Gets or sets the exam grade entries.
        /// </summary>
        /// <value>
        /// The exam grade entries.
        /// </value>
        public Dictionary<double, string> ExamGradeEntries { get; set; }

        /// <summary>
        /// Gets or sets the assignments weight.
        /// </summary>
        /// <value>
        /// The assignments weight.
        /// </value>
        public double AssignmentsWeight { get; set; }

        /// <summary>
        /// Gets or sets the quizzes weight.
        /// </summary>
        /// <value>
        /// The quizzes weight.
        /// </value>
        public double QuizzesWeight { get; set; }

        /// <summary>
        /// Gets or sets the exams weight.
        /// </summary>
        /// <value>
        /// The exams weight.
        /// </value>
        public double ExamsWeight { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryWriter"/> class.
        /// </summary>
        public SummaryWriter()
        {
            this.AssignmentGradeEntries = new Dictionary<double, string>();
            this.QuizGradeEntries = new Dictionary<double, string>();
            this.ExamGradeEntries = new Dictionary<double, string>();
        }

        /// <summary>
        /// Writes the summary output.
        /// </summary>
        /// <returns></returns>
        public string WriteSummaryOutput()
        {


            return string.Empty;
        }
    }
}

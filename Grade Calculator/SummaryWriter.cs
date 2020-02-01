using System;
using System.Collections.Generic;
using System.Text;

namespace Grade_Calculator
{
    /// <summary>
    ///     Writes the Summary Output for the Grade Calculator Form
    /// </summary>
    public class SummaryWriter
    {
        #region Data members

        private const double DefaultAverage = 100.0;
        private const int WeightTotal = 100;

        private static readonly string WeightPercentageWarning =
            $"The Category Weights do not equal 100 {Environment.NewLine}";

        private double assignmentsAverage;
        private double quizzesAverage;
        private double examsAverage;
        private double overallAverage;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the assignment grades.
        /// </summary>
        /// <value>
        ///     The assignment grades.
        /// </value>
        public IList<double> AssignmentGrades { get; set; }

        /// <summary>
        ///     Gets or sets the assignment descriptions.
        /// </summary>
        /// <value>
        ///     The assignment descriptions.
        /// </value>
        public IList<string> AssignmentDescriptions { get; set; }

        /// <summary>
        ///     Gets or sets the quiz grades.
        /// </summary>
        /// <value>
        ///     The quiz grades.
        /// </value>
        public IList<double> QuizGrades { get; set; }

        /// <summary>
        ///     Gets or sets the quiz descriptions.
        /// </summary>
        /// <value>
        ///     The quiz descriptions.
        /// </value>
        public IList<string> QuizDescriptions { get; set; }

        /// <summary>
        ///     Gets or sets the exam grades.
        /// </summary>
        /// <value>
        ///     The exam grades.
        /// </value>
        public IList<double> ExamGrades { get; set; }

        /// <summary>
        ///     Gets or sets the exam descriptions.
        /// </summary>
        /// <value>
        ///     The exam descriptions.
        /// </value>
        public IList<string> ExamDescriptions { get; set; }

        /// <summary>
        ///     Gets or sets the assignments weight.
        /// </summary>
        /// <value>
        ///     The assignments weight.
        /// </value>
        public double AssignmentsWeight { get; set; }

        /// <summary>
        ///     Gets or sets the quizzes weight.
        /// </summary>
        /// <value>
        ///     The quizzes weight.
        /// </value>
        public double QuizzesWeight { get; set; }

        /// <summary>
        ///     Gets or sets the exams weight.
        /// </summary>
        /// <value>
        ///     The exams weight.
        /// </value>
        public double ExamsWeight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SummaryWriter" /> class.
        /// </summary>
        public SummaryWriter()
        {
            this.AssignmentGrades = new List<double>();
            this.AssignmentDescriptions = new List<string>();

            this.QuizGrades = new List<double>();
            this.QuizDescriptions = new List<string>();

            this.ExamGrades = new List<double>();
            this.ExamDescriptions = new List<string>();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Writes the summary output.
        /// </summary>
        /// <returns>Formatted Output Summary of Grades</returns>
        public string WriteSummaryOutput()
        {
            this.resetAverages();
            
            var stringBuilder = new StringBuilder();
            if (this.underCategoryWeightTotal())
            {
                stringBuilder.Append(WeightPercentageWarning);
            }

            return stringBuilder.ToString();
        }

        private bool underCategoryWeightTotal()
        {
            var totalWeight = this.AssignmentsWeight + this.QuizzesWeight + this.ExamsWeight;
            return !totalWeight.Equals(100.0);
        }

        private void resetAverages()
        {
            this.assignmentsAverage = DefaultAverage;
            this.quizzesAverage = DefaultAverage;
            this.examsAverage = DefaultAverage;
            this.overallAverage = DefaultAverage;
        }

        #endregion
    }
}
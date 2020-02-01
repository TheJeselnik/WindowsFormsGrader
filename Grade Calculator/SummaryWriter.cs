using System;
using System.Collections.Generic;
using System.Linq;
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

        private static readonly string WeightTotalWarning =
            $"The category weights do not equal 100 {Environment.NewLine}";

        private double assignmentsAverage;
        private double quizzesAverage;
        private double examsAverage;
        private double overallGrade;

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
            this.setAverages();

            var stringBuilder = new StringBuilder();
            this.displayWeightTotalWarning(stringBuilder);

            stringBuilder.Append($"Overall grade: {this.overallGrade:F}{Environment.NewLine}{Environment.NewLine}");

            stringBuilder.Append($"Assignments average: {this.assignmentsAverage:F} Weight: {this.AssignmentsWeight}");
            for (var i = 0; i < this.AssignmentGrades.Count; i++)
            {
                stringBuilder.Append(
                    $"{Environment.NewLine}{this.AssignmentGrades[i]:F}: {this.AssignmentDescriptions[i]}");
            }

            stringBuilder.Append(Environment.NewLine + Environment.NewLine);

            stringBuilder.Append($"Quizzes average: {this.quizzesAverage:F} Weight: {this.QuizzesWeight}");
            for (var i = 0; i < this.QuizGrades.Count; i++)
            {
                stringBuilder.Append($"{Environment.NewLine}{this.QuizGrades[i]:F}: {this.QuizDescriptions[i]}");
            }

            stringBuilder.Append(Environment.NewLine + Environment.NewLine);

            stringBuilder.Append($"Exams average: {this.examsAverage:F} Weight: {this.ExamsWeight}");
            for (var i = 0; i < this.ExamGrades.Count; i++)
            {
                stringBuilder.Append($"{Environment.NewLine}{this.ExamGrades[i]:F}: {this.ExamDescriptions[i]}");
            }

            return stringBuilder.ToString();
        }

        private void displayWeightTotalWarning(StringBuilder stringBuilder)
        {
            if (this.underCategoryWeightTotal())
            {
                stringBuilder.Append(WeightTotalWarning);
            }
        }

        private bool underCategoryWeightTotal()
        {
            var totalWeight = this.AssignmentsWeight + this.QuizzesWeight + this.ExamsWeight;
            return !totalWeight.Equals(WeightTotal);
        }

        private void setAverages()
        {
            this.assignmentsAverage = DefaultAverage;
            if (this.AssignmentGrades.Count > 0)
            {
                this.assignmentsAverage = this.AssignmentGrades.Average();
            }

            var assignmentsWeightedAverage = this.assignmentsAverage * this.AssignmentsWeight / WeightTotal;

            this.quizzesAverage = DefaultAverage;
            if (this.QuizGrades.Count > 0)
            {
                this.quizzesAverage = this.QuizGrades.Average();
            }

            var quizzesWeightedAverage = this.quizzesAverage * this.QuizzesWeight / WeightTotal;

            this.examsAverage = DefaultAverage;
            if (this.ExamGrades.Count > 0)
            {
                this.examsAverage = this.ExamGrades.Average();
            }

            var examsWeightedAverage = this.examsAverage * this.ExamsWeight / WeightTotal;

            this.overallGrade = assignmentsWeightedAverage + quizzesWeightedAverage + examsWeightedAverage;
        }

        #endregion
    }
}
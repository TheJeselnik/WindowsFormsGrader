using System;
using System.Collections.Generic;
using System.Text;

namespace Grade_Calculator
{
    /// <summary>
    /// Writes the Summary Output for the Grade Calculator Form
    /// </summary>
    public class SummaryWriter
    {
        /// <summary>
        /// Gets or sets the assignment grades.
        /// </summary>
        /// <value>
        /// The assignment grades.
        /// </value>
        public IList<double> AssignmentGrades { get; set; }

        /// <summary>
        /// Gets or sets the assignment descriptions.
        /// </summary>
        /// <value>
        /// The assignment descriptions.
        /// </value>
        public IList<string> AssignmentDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the quiz grades.
        /// </summary>
        /// <value>
        /// The quiz grades.
        /// </value>
        public IList<double> QuizGrades { get; set; }

        /// <summary>
        /// Gets or sets the quiz descriptions.
        /// </summary>
        /// <value>
        /// The quiz descriptions.
        /// </value>
        public IList<string> QuizDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the exam grades.
        /// </summary>
        /// <value>
        /// The exam grades.
        /// </value>
        public IList<double> ExamGrades { get; set; }

        /// <summary>
        /// Gets or sets the exam descriptions.
        /// </summary>
        /// <value>
        /// The exam descriptions.
        /// </value>
        public IList<string> ExamDescriptions { get; set; }

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

        private const double DefaultAverage = 100.0;
        private const int PercentageTotal = 100;
        private static readonly string WeightPercentageWarning = $"The Category Weights do not equal 100 {Environment.NewLine}";

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryWriter"/> class.
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

        /// <summary>
        /// Writes the summary output.
        /// </summary>
        /// <returns></returns>
        public string WriteSummaryOutput()
        {
            var assignmentsAverage = DefaultAverage;
            var assignmentsWeightedAverage = DefaultAverage;

            var quizzesAverage = DefaultAverage;
            var quizzesWeightedAverage = DefaultAverage;

            var examsAverage = DefaultAverage;
            var examsWeightedAverage = DefaultAverage;

            if (this.AssignmentGradeEntries.Count != 0)
            {
                assignmentsAverage = this.AssignmentGradeEntries.Keys.Average();
                assignmentsWeightedAverage = assignmentsAverage * this.AssignmentsWeight / PercentageTotal;
            }

            if (this.QuizGradeEntries.Count != 0)
            {
                quizzesAverage = this.QuizGradeEntries.Keys.Average();
                quizzesWeightedAverage = quizzesAverage * this.QuizzesWeight / PercentageTotal;
            }

            if (this.ExamGradeEntries.Count != 0)
            {
                examsAverage = this.ExamGradeEntries.Keys.Average();
                examsWeightedAverage = examsAverage * this.ExamsWeight / PercentageTotal;
            }

            var categorySum = assignmentsWeightedAverage + quizzesWeightedAverage + examsWeightedAverage;
            var overallAverage = categorySum / 3;

            var stringBuilder = new StringBuilder();

            if (this.categoryWeightsNotFull())
            {
                stringBuilder.Append(WeightPercentageWarning);
            }

            stringBuilder.Append($"Overall grade: {overallAverage:F} {Environment.NewLine}{Environment.NewLine}");

            stringBuilder.Append($"{Environment.NewLine}Assignments average: {assignmentsAverage:F} Weight: {this.AssignmentsWeight}{Environment.NewLine}");
            foreach (var assignmentGradeEntry in this.AssignmentGradeEntries)
            {
                stringBuilder.Append($"{assignmentGradeEntry.Key}: {assignmentGradeEntry.Value}{Environment.NewLine}");
            }

            stringBuilder.Append($"{Environment.NewLine}Quizzes average: {quizzesAverage:F} Weight: {this.QuizzesWeight}{Environment.NewLine}");
            foreach (var quizGradeEntry in this.QuizGradeEntries)
            {
                stringBuilder.Append($"{quizGradeEntry.Key}: {quizGradeEntry.Value}{Environment.NewLine}");
            }

            stringBuilder.Append($"{Environment.NewLine}Exams average: {examsAverage:F} Weight: {this.ExamsWeight}{Environment.NewLine}");
            foreach (var examGradeEntry in this.ExamGradeEntries)
            {
                stringBuilder.Append($"{examGradeEntry.Key}: {examGradeEntry.Value}{Environment.NewLine}");
            }

            return stringBuilder.ToString();
        }

        private bool categoryWeightsNotFull()
        {
            var totalWeight = this.AssignmentsWeight + this.QuizzesWeight + this.ExamsWeight;
            return !totalWeight.Equals(100.0);
        }
    }
}

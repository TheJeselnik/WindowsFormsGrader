using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GradeControl;

namespace Grade_Calculator
{
    /// <summary>
    ///     Form containing a tab of Grade Controls, passes requests to classes and
    ///     applies to the form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class GradeCalculatorForm : Form
    {
        #region Data members

        private readonly FileSerializer fileSerializer;
        private readonly SummaryWriter summaryWriter;

        #endregion

        #region Constructors

        public GradeCalculatorForm()
        {
            this.InitializeComponent();

            this.fileSerializer = new FileSerializer();
            this.summaryWriter = new SummaryWriter();

            this.loadControls();

            this.assignmentsGradeControl.ControlUpdated += this.onControlUpdated;
            this.quizzesGradeControl.ControlUpdated += this.onControlUpdated;
            this.examsGradeControl.ControlUpdated += this.onControlUpdated;
        }

        #endregion

        #region Methods

        private void loadControls()
        {
            var gradeCategories = this.fileSerializer.LoadGradeEntries();
            this.assignmentsGradeControl.LoadDataIntoGradeGridView(gradeCategories[0]);
            this.quizzesGradeControl.LoadDataIntoGradeGridView(gradeCategories[1]);
            this.examsGradeControl.LoadDataIntoGradeGridView(gradeCategories[2]);
        }

        private void saveControls()
        {
            var assignmentsCategory = this.assignmentsGradeControl.GradeCategory;
            var quizzesCategory = this.quizzesGradeControl.GradeCategory;
            var examsCategory = this.examsGradeControl.GradeCategory;

            var gradeCategories = new List<GradeCategory> {
                assignmentsCategory, quizzesCategory, examsCategory
            };
            this.fileSerializer.SaveGradeEntries(gradeCategories);
        }

        private void onControlUpdated(object sender, EventArgs e)
        {
            this.setSummaryWriterProperties();
            this.updateSummaryOutput();
        }

        private void updateSummaryOutput()
        {
            this.outputSummaryTextBox.Clear();
            this.outputSummaryTextBox.Text = this.summaryWriter.WriteSummaryOutput();
        }

        private void setSummaryWriterProperties()
        {
            this.summaryWriter.AssignmentGrades = this.assignmentsGradeControl.GradeValues;
            this.summaryWriter.AssignmentDescriptions = this.assignmentsGradeControl.GradeDescriptions;
            this.summaryWriter.AssignmentsWeight = this.assignmentsGradeControl.Weight;

            this.summaryWriter.QuizGrades = this.quizzesGradeControl.GradeValues;
            this.summaryWriter.QuizDescriptions = this.quizzesGradeControl.GradeDescriptions;
            this.summaryWriter.QuizzesWeight = this.quizzesGradeControl.Weight;

            this.summaryWriter.ExamGrades = this.examsGradeControl.GradeValues;
            this.summaryWriter.ExamDescriptions = this.examsGradeControl.GradeDescriptions;
            this.summaryWriter.ExamsWeight = this.examsGradeControl.Weight;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveControls();
        }

        #endregion
    }
}
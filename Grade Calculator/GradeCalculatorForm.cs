using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
            var dataSets = this.fileSerializer.LoadGradeEntries();
            this.assignmentsGradeControl.LoadDataIntoGradeGridView(dataSets[0]);
            this.quizzesGradeControl.LoadDataIntoGradeGridView(dataSets[1]);
            this.examsGradeControl.LoadDataIntoGradeGridView(dataSets[2]);
        }

        private void saveControls()
        {
            var dataSets = new List<DataSet> {
                this.assignmentsGradeControl.GradeDataSet, this.quizzesGradeControl.GradeDataSet,
                this.examsGradeControl.GradeDataSet
            };
            this.fileSerializer.SaveGradeEntries(dataSets);
        }

        private void onControlUpdated(object sender, EventArgs e)
        {
            this.setSummaryWriterProperties();
            this.updateSummaryOutput();
        }

        private void updateSummaryOutput()
        {
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
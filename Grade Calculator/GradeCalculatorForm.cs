using System.Windows.Forms;

namespace Grade_Calculator
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class GradeCalculatorForm : Form
    {

        private FileSerializer fileSerializer;
        private readonly SummaryWriter summaryWriter;


        public GradeCalculatorForm()
        {
            this.InitializeComponent();

            this.fileSerializer = new FileSerializer();
            this.summaryWriter = new SummaryWriter();

            this.assignmentsGradeControl.ControlUpdated += this.onControlUpdated;
            this.quizzesGradeControl.ControlUpdated += this.onControlUpdated;
            this.examsGradeControl.ControlUpdated += this.onControlUpdated;
        }

        private void onControlUpdated(object sender, System.EventArgs e)
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
    }
}

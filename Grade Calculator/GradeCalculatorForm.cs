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
            this.outputSummaryTextBox.Clear();
            this.outputSummaryTextBox.Text = this.summaryWriter.WriteSummaryOutput();
        }

        private void setSummaryWriterProperties()
        {
            this.summaryWriter.AssignmentGradeEntries = this.assignmentsGradeControl.GradeValues;
            this.summaryWriter.AssignmentsWeight = this.assignmentsGradeControl.Weight;

            this.summaryWriter.QuizGradeEntries = this.quizzesGradeControl.GradeValues;
            this.summaryWriter.QuizzesWeight = this.quizzesGradeControl.Weight;

            this.summaryWriter.ExamGradeEntries = this.examsGradeControl.GradeValues;
            this.summaryWriter.ExamsWeight = this.examsGradeControl.Weight;
        }
    }
}

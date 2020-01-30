using System;
using System.Windows.Forms;

namespace GradeControl
{
    /// <summary>
    ///     Control for calculating grades of a category and selecting the weight
    ///     its included grades contribute to the overall grade.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class GradeControl : UserControl
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="GradeControl" /> class.
        /// </summary>
        public GradeControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Occurs when [control updated].
        /// </summary>
        public event EventHandler ControlUpdated;

        private void onControlUpdated()
        {
            this.ControlUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void gradeGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradeGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradeGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.onControlUpdated();
        }

        private void checkUncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.checkAllGrades();
            this.onControlUpdated();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.uncheckAllGrades();
            this.onControlUpdated();
        }

        private void checkAllGrades()
        {
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var cell = (DataGridViewCheckBoxCell)row.Cells[0];

                cell.Value = true;
            }
        }

        private void uncheckAllGrades()
        {
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var cell = (DataGridViewCheckBoxCell)row.Cells[0];

                cell.Value = false;
            }
        }

        #endregion
    }
}
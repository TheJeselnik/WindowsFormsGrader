using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GradeControl
{
    /// <summary>
    ///     Control for entering grades of a category and selecting the weight
    ///     its included grades contribute to the overall grade.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class GradeControl : UserControl
    {
        #region Properties

        /// <summary>
        ///     Gets the grade entries for the control's category.
        /// </summary>
        /// <value>
        ///     The grade entries for the control's category.
        /// </value>
        public Dictionary<double, string> GradeEntries => this.getGradeEntries();

        /// <summary>
        /// Gets the weight for the control's category.
        /// </summary>
        /// <value>
        /// The weight for the control's category.
        /// </value>
        public int Weight => (int) this.gradeWeightUpDown.Value;

        #endregion

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
        ///     Occurs when the control is updated.
        /// </summary>
        public event EventHandler ControlUpdated;

        private Dictionary<double, string> getGradeEntries()
        {
            var gradeDictionary = new Dictionary<double, string>();

            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[0];
                var gradeCell = Convert.ToDouble(row.Cells[1].Value);
                var descriptionCell = row.Cells[2].Value.ToString();

                if (Convert.ToBoolean(checkBoxCell.EditedFormattedValue))
                {
                    gradeDictionary.Add(gradeCell, descriptionCell);
                }
            }

            return gradeDictionary;
        }

        private void checkAllGrades()
        {
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];

                checkBoxCell.Value = true;
            }
        }

        private void uncheckAllGrades()
        {
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];

                checkBoxCell.Value = false;
            }
        }

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

        private void gradePercentUpDown_ValueChanged(object sender, EventArgs e)
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

        #endregion
    }
}
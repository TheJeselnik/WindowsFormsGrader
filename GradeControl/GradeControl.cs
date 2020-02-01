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
        ///     Gets the grade values.
        /// </summary>
        /// <value>
        ///     The grade values.
        /// </value>
        public IList<double> GradeValues => this.getGradeValues();

        /// <summary>
        ///     Gets the grade descriptions.
        /// </summary>
        /// <value>
        ///     The grade descriptions.
        /// </value>
        public IList<string> GradeDescriptions => this.getGradeDescriptions();

        /// <summary>
        ///     Gets the weight for the control's category.
        /// </summary>
        /// <value>
        ///     The weight for the control's category.
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

        private IList<double> getGradeValues()
        {
            var gradeValues = new List<double>();

            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[0];
                //TODO Check for only digits
                var gradeCell = (double?) Convert.ToDouble(row.Cells[1].Value ?? 0.0);

                if (Convert.ToBoolean(checkBoxCell.EditedFormattedValue))
                {
                    gradeValues.Add((double) gradeCell);
                }
            }

            return gradeValues;
        }

        private List<string> getGradeDescriptions()
        {
            var gradeDescriptions = new List<string>();

            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[0];
                var descriptionCell = row.Cells[2].Value as string;

                if (Convert.ToBoolean(checkBoxCell.EditedFormattedValue))
                {
                    gradeDescriptions.Add(descriptionCell);
                }
            }

            return gradeDescriptions;
        }

        private void checkAllGrades()
        {
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[0];

                checkBoxCell.Value = true;
            }
        }

        private void uncheckAllGrades()
        {
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell) row.Cells[0];

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
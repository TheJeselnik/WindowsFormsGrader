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

        /// <summary>
        ///     Gets the grade category.
        /// </summary>
        /// <value>
        ///     The grade category.
        /// </value>
        public GradeCategory GradeCategory => this.getGradeCategory();

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
        ///     Loads the data into grade grid view.
        /// </summary>
        /// <param name="gradeCategory">The grade category.</param>
        public void LoadDataIntoGradeGridView(GradeCategory gradeCategory)
        {
            this.gradeWeightUpDown.Value = gradeCategory.Weight;

            foreach (var gradeEntry in gradeCategory.GradeEntries)
            {
                this.gradeGridView.Rows.Add(gradeEntry.Included, gradeEntry.Grade, gradeEntry.Description);
            }
        }

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
                var gradeCell = row.Cells[1].Value as string;
                double.TryParse(gradeCell, out var parsedGradeCell);

                if (Convert.ToBoolean(checkBoxCell.EditedFormattedValue))
                {
                    gradeValues.Add(parsedGradeCell);
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

        private GradeCategory getGradeCategory()
        {
            var gradeEntries = new List<GradeEntry>();
            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var gradeEntry = new GradeEntry {
                    Included = Convert.ToBoolean(row.Cells[0].Value),
                    Grade = row.Cells[1].Value as string,
                    Description = row.Cells[2].Value as string
                };

                gradeEntries.Add(gradeEntry);
            }

            var gradeCategory = new GradeCategory {GradeEntries = gradeEntries, Weight = this.Weight};

            return gradeCategory;
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

        private void gradeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradeGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradePercentUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradeWeightUpDown_KeyUp(object sender, KeyEventArgs e)
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
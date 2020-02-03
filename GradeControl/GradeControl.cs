using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GradeControl
{
    /// <summary>
    ///     Control for entering grades of a category and selecting the weight
    ///     its included grades contribute to the overall grade.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [Serializable]
    public partial class GradeControl : UserControl
    {
        #region Properties

        /// <summary>
        ///     Gets the grade values.
        /// </summary>
        /// <value>
        ///     The grade values.
        /// </value>
        [XmlIgnore]
        public IList<double> GradeValues => this.getGradeValues();

        /// <summary>
        ///     Gets the grade descriptions.
        /// </summary>
        /// <value>
        ///     The grade descriptions.
        /// </value>
        [XmlIgnore]
        public IList<string> GradeDescriptions => this.getGradeDescriptions();

        /// <summary>
        ///     Gets the weight for the control's category.
        /// </summary>
        /// <value>
        ///     The weight for the control's category.
        /// </value>
        [XmlElement]
        public int Weight => (int) this.gradeWeightUpDown.Value;

        /// <summary>
        ///     Gets the grade data set.
        /// </summary>
        /// <value>
        ///     The grade data set.
        /// </value>
        [XmlElement]
        public DataSet GradeDataSet => this.getGradeDataSet();

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

        public void LoadDataIntoGradeGridView(DataSet dataSet)
        {
            this.gradeGridView.DataSource = dataSet.Tables[0];
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

        private DataSet getGradeDataSet()
        {
            var dataSet = new DataSet();
            var dataTable = new DataTable();

            foreach (DataGridViewColumn column in this.gradeGridView.Columns)
            {
                dataTable.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in this.gradeGridView.Rows)
            {
                var newRow = dataTable.NewRow();
                foreach (DataGridViewCell rowCell in row.Cells)
                {
                    newRow[rowCell.ColumnIndex] = rowCell.Value;
                }

                dataTable.Rows.Add(newRow);
            }

            dataSet.Tables.Add(dataTable);

            return dataSet;
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

        //potentially use this.gradeGridView.DataSource = ds to load data
    }
}
using System;
using System.Windows.Forms;

namespace GradeControl
{
    public partial class GradeControl: UserControl
    {
        public GradeControl()
        {
            this.InitializeComponent();
        }

        public event EventHandler ControlUpdated;

        private void onControlUpdated()
        {
            this.ControlUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void gradeDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradeDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.onControlUpdated();
        }

        private void gradeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.onControlUpdated();
        }
    }
}

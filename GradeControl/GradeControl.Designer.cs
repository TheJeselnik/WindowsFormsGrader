namespace GradeControl
{
    partial class GradeControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assessedItemsLabel = new System.Windows.Forms.Label();
            this.gradeDataGridView = new System.Windows.Forms.DataGridView();
            this.includedCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gradeTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradePercentLabel = new System.Windows.Forms.Label();
            this.gradePercentUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradePercentUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // assessedItemsLabel
            // 
            this.assessedItemsLabel.AutoSize = true;
            this.assessedItemsLabel.Location = new System.Drawing.Point(3, 3);
            this.assessedItemsLabel.Name = "assessedItemsLabel";
            this.assessedItemsLabel.Size = new System.Drawing.Size(80, 13);
            this.assessedItemsLabel.TabIndex = 0;
            this.assessedItemsLabel.Text = "Assessed Items";
            // 
            // gradeDataGridView
            // 
            this.gradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.includedCheckBoxColumn,
            this.gradeTextBoxColumn,
            this.descriptionTextBoxColumn});
            this.gradeDataGridView.Location = new System.Drawing.Point(3, 19);
            this.gradeDataGridView.Name = "gradeDataGridView";
            this.gradeDataGridView.Size = new System.Drawing.Size(355, 225);
            this.gradeDataGridView.TabIndex = 1;
            this.gradeDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeDataGridView_CellValueChanged);
            this.gradeDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gradeDataGridView_UserAddedRow);
            this.gradeDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gradeDataGridView_UserDeletedRow);
            // 
            // includedCheckBoxColumn
            // 
            this.includedCheckBoxColumn.HeaderText = "Included";
            this.includedCheckBoxColumn.Name = "includedCheckBoxColumn";
            this.includedCheckBoxColumn.Width = 55;
            // 
            // gradeTextBoxColumn
            // 
            this.gradeTextBoxColumn.HeaderText = "Grade";
            this.gradeTextBoxColumn.Name = "gradeTextBoxColumn";
            this.gradeTextBoxColumn.Width = 55;
            // 
            // descriptionTextBoxColumn
            // 
            this.descriptionTextBoxColumn.HeaderText = "Description";
            this.descriptionTextBoxColumn.Name = "descriptionTextBoxColumn";
            this.descriptionTextBoxColumn.Width = 200;
            // 
            // gradePercentLabel
            // 
            this.gradePercentLabel.AutoSize = true;
            this.gradePercentLabel.Location = new System.Drawing.Point(74, 250);
            this.gradePercentLabel.Name = "gradePercentLabel";
            this.gradePercentLabel.Size = new System.Drawing.Size(141, 13);
            this.gradePercentLabel.TabIndex = 2;
            this.gradePercentLabel.Text = "Percentage of overall grade:";
            // 
            // gradePercentUpDown
            // 
            this.gradePercentUpDown.Location = new System.Drawing.Point(221, 247);
            this.gradePercentUpDown.Name = "gradePercentUpDown";
            this.gradePercentUpDown.Size = new System.Drawing.Size(48, 20);
            this.gradePercentUpDown.TabIndex = 3;
            // 
            // GradeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradePercentUpDown);
            this.Controls.Add(this.gradePercentLabel);
            this.Controls.Add(this.gradeDataGridView);
            this.Controls.Add(this.assessedItemsLabel);
            this.Name = "GradeControl";
            this.Size = new System.Drawing.Size(361, 271);
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradePercentUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assessedItemsLabel;
        private System.Windows.Forms.DataGridView gradeDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includedCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionTextBoxColumn;
        private System.Windows.Forms.Label gradePercentLabel;
        private System.Windows.Forms.NumericUpDown gradePercentUpDown;
    }
}

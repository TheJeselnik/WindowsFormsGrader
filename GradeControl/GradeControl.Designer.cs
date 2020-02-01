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
            this.components = new System.ComponentModel.Container();
            this.assessedItemsLabel = new System.Windows.Forms.Label();
            this.gradeGridView = new System.Windows.Forms.DataGridView();
            this.includedCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gradeTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradePercentLabel = new System.Windows.Forms.Label();
            this.gradeWeightUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGridView)).BeginInit();
            this.gradeGridContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeWeightUpDown)).BeginInit();
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
            // gradeGridView
            // 
            this.gradeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.includedCheckBoxColumn,
            this.gradeTextBoxColumn,
            this.descriptionTextBoxColumn});
            this.gradeGridView.ContextMenuStrip = this.gradeGridContextMenu;
            this.gradeGridView.Location = new System.Drawing.Point(3, 19);
            this.gradeGridView.Name = "gradeGridView";
            this.gradeGridView.Size = new System.Drawing.Size(355, 225);
            this.gradeGridView.TabIndex = 1;
            this.gradeGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeGridView_CellValueChanged);
            this.gradeGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gradeGridView_UserAddedRow);
            this.gradeGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gradeGridView_UserDeletedRow);
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
            // gradeGridContextMenu
            // 
            this.gradeGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem});
            this.gradeGridContextMenu.Name = "contextMenuStrip1";
            this.gradeGridContextMenu.Size = new System.Drawing.Size(138, 48);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkUncheckAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck All";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
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
            // gradeWeightUpDown
            // 
            this.gradeWeightUpDown.Location = new System.Drawing.Point(215, 247);
            this.gradeWeightUpDown.Name = "gradeWeightUpDown";
            this.gradeWeightUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gradeWeightUpDown.Size = new System.Drawing.Size(56, 20);
            this.gradeWeightUpDown.TabIndex = 3;
            this.gradeWeightUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gradeWeightUpDown.ValueChanged += new System.EventHandler(this.gradePercentUpDown_ValueChanged);
            // 
            // GradeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradeWeightUpDown);
            this.Controls.Add(this.gradePercentLabel);
            this.Controls.Add(this.gradeGridView);
            this.Controls.Add(this.assessedItemsLabel);
            this.Name = "GradeControl";
            this.Size = new System.Drawing.Size(361, 271);
            ((System.ComponentModel.ISupportInitialize)(this.gradeGridView)).EndInit();
            this.gradeGridContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeWeightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assessedItemsLabel;
        private System.Windows.Forms.DataGridView gradeGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includedCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionTextBoxColumn;
        private System.Windows.Forms.Label gradePercentLabel;
        private System.Windows.Forms.NumericUpDown gradeWeightUpDown;
        private System.Windows.Forms.ContextMenuStrip gradeGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
    }
}

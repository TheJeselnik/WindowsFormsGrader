namespace Grade_Calculator
{
    partial class GradeCalculatorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryTabControl = new System.Windows.Forms.TabControl();
            this.assignmentsTabPage = new System.Windows.Forms.TabPage();
            this.assignmentsGradeControl = new GradeControl.GradeControl();
            this.quizTabPage = new System.Windows.Forms.TabPage();
            this.quizzesGradeControl = new GradeControl.GradeControl();
            this.examTabPage = new System.Windows.Forms.TabPage();
            this.examsGradeControl = new GradeControl.GradeControl();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.outputSummaryLabel = new System.Windows.Forms.Label();
            this.outputSummaryTextBox = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryTabControl.SuspendLayout();
            this.assignmentsTabPage.SuspendLayout();
            this.quizTabPage.SuspendLayout();
            this.examTabPage.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryTabControl
            // 
            this.categoryTabControl.Controls.Add(this.assignmentsTabPage);
            this.categoryTabControl.Controls.Add(this.quizTabPage);
            this.categoryTabControl.Controls.Add(this.examTabPage);
            this.categoryTabControl.Location = new System.Drawing.Point(12, 40);
            this.categoryTabControl.Name = "categoryTabControl";
            this.categoryTabControl.SelectedIndex = 0;
            this.categoryTabControl.Size = new System.Drawing.Size(368, 297);
            this.categoryTabControl.TabIndex = 0;
            // 
            // assignmentsTabPage
            // 
            this.assignmentsTabPage.Controls.Add(this.assignmentsGradeControl);
            this.assignmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.assignmentsTabPage.Name = "assignmentsTabPage";
            this.assignmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignmentsTabPage.Size = new System.Drawing.Size(360, 271);
            this.assignmentsTabPage.TabIndex = 0;
            this.assignmentsTabPage.Text = "Assignments";
            this.assignmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // assignmentsGradeControl
            // 
            this.assignmentsGradeControl.Location = new System.Drawing.Point(0, 0);
            this.assignmentsGradeControl.Name = "assignmentsGradeControl";
            this.assignmentsGradeControl.Size = new System.Drawing.Size(361, 271);
            this.assignmentsGradeControl.TabIndex = 0;
            // 
            // quizTabPage
            // 
            this.quizTabPage.Controls.Add(this.quizzesGradeControl);
            this.quizTabPage.Location = new System.Drawing.Point(4, 22);
            this.quizTabPage.Name = "quizTabPage";
            this.quizTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.quizTabPage.Size = new System.Drawing.Size(360, 271);
            this.quizTabPage.TabIndex = 1;
            this.quizTabPage.Text = "Quizzes";
            this.quizTabPage.UseVisualStyleBackColor = true;
            // 
            // quizzesGradeControl
            // 
            this.quizzesGradeControl.Location = new System.Drawing.Point(0, 0);
            this.quizzesGradeControl.Name = "quizzesGradeControl";
            this.quizzesGradeControl.Size = new System.Drawing.Size(361, 271);
            this.quizzesGradeControl.TabIndex = 0;
            // 
            // examTabPage
            // 
            this.examTabPage.Controls.Add(this.examsGradeControl);
            this.examTabPage.Location = new System.Drawing.Point(4, 22);
            this.examTabPage.Name = "examTabPage";
            this.examTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examTabPage.Size = new System.Drawing.Size(360, 271);
            this.examTabPage.TabIndex = 2;
            this.examTabPage.Text = "Exams";
            this.examTabPage.UseVisualStyleBackColor = true;
            // 
            // examsGradeControl
            // 
            this.examsGradeControl.Location = new System.Drawing.Point(0, 0);
            this.examsGradeControl.Name = "examsGradeControl";
            this.examsGradeControl.Size = new System.Drawing.Size(361, 271);
            this.examsGradeControl.TabIndex = 0;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(9, 24);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(57, 13);
            this.categoriesLabel.TabIndex = 1;
            this.categoriesLabel.Text = "Categories";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(391, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Menu";
            // 
            // outputSummaryLabel
            // 
            this.outputSummaryLabel.AutoSize = true;
            this.outputSummaryLabel.Location = new System.Drawing.Point(9, 353);
            this.outputSummaryLabel.Name = "outputSummaryLabel";
            this.outputSummaryLabel.Size = new System.Drawing.Size(82, 13);
            this.outputSummaryLabel.TabIndex = 3;
            this.outputSummaryLabel.Text = "Grade Summary";
            // 
            // outputSummaryTextBox
            // 
            this.outputSummaryTextBox.Location = new System.Drawing.Point(12, 369);
            this.outputSummaryTextBox.Multiline = true;
            this.outputSummaryTextBox.Name = "outputSummaryTextBox";
            this.outputSummaryTextBox.ReadOnly = true;
            this.outputSummaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputSummaryTextBox.Size = new System.Drawing.Size(365, 225);
            this.outputSummaryTextBox.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // GradeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 606);
            this.Controls.Add(this.outputSummaryTextBox);
            this.Controls.Add(this.outputSummaryLabel);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoryTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GradeCalculatorForm";
            this.Text = "Grade Calculator by Daniel Jeselnik";
            this.categoryTabControl.ResumeLayout(false);
            this.assignmentsTabPage.ResumeLayout(false);
            this.quizTabPage.ResumeLayout(false);
            this.examTabPage.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl categoryTabControl;
        private System.Windows.Forms.TabPage assignmentsTabPage;
        private System.Windows.Forms.TabPage quizTabPage;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.TabPage examTabPage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label outputSummaryLabel;
        private System.Windows.Forms.TextBox outputSummaryTextBox;
        private GradeControl.GradeControl assignmentsGradeControl;
        private GradeControl.GradeControl quizzesGradeControl;
        private GradeControl.GradeControl examsGradeControl;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}


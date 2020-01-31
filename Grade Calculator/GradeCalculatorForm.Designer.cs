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
            this.quizTabPage = new System.Windows.Forms.TabPage();
            this.examTabPage = new System.Windows.Forms.TabPage();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.outputSummaryLabel = new System.Windows.Forms.Label();
            this.outputSummaryTextBox = new System.Windows.Forms.TextBox();
            this.gradeControl1 = new GradeControl.GradeControl();
            this.gradeControl2 = new GradeControl.GradeControl();
            this.gradeControl3 = new GradeControl.GradeControl();
            this.categoryTabControl.SuspendLayout();
            this.assignmentsTabPage.SuspendLayout();
            this.quizTabPage.SuspendLayout();
            this.examTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryTabControl
            // 
            this.categoryTabControl.Controls.Add(this.assignmentsTabPage);
            this.categoryTabControl.Controls.Add(this.quizTabPage);
            this.categoryTabControl.Controls.Add(this.examTabPage);
            this.categoryTabControl.Location = new System.Drawing.Point(12, 25);
            this.categoryTabControl.Name = "categoryTabControl";
            this.categoryTabControl.SelectedIndex = 0;
            this.categoryTabControl.Size = new System.Drawing.Size(368, 299);
            this.categoryTabControl.TabIndex = 0;
            // 
            // assignmentsTabPage
            // 
            this.assignmentsTabPage.Controls.Add(this.gradeControl1);
            this.assignmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.assignmentsTabPage.Name = "assignmentsTabPage";
            this.assignmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignmentsTabPage.Size = new System.Drawing.Size(360, 273);
            this.assignmentsTabPage.TabIndex = 0;
            this.assignmentsTabPage.Text = "Assignments";
            this.assignmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // quizTabPage
            // 
            this.quizTabPage.Controls.Add(this.gradeControl2);
            this.quizTabPage.Location = new System.Drawing.Point(4, 22);
            this.quizTabPage.Name = "quizTabPage";
            this.quizTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.quizTabPage.Size = new System.Drawing.Size(360, 273);
            this.quizTabPage.TabIndex = 1;
            this.quizTabPage.Text = "Quizzes";
            this.quizTabPage.UseVisualStyleBackColor = true;
            // 
            // examTabPage
            // 
            this.examTabPage.Controls.Add(this.gradeControl3);
            this.examTabPage.Location = new System.Drawing.Point(4, 22);
            this.examTabPage.Name = "examTabPage";
            this.examTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examTabPage.Size = new System.Drawing.Size(360, 273);
            this.examTabPage.TabIndex = 2;
            this.examTabPage.Text = "Exams";
            this.examTabPage.UseVisualStyleBackColor = true;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(12, 9);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(57, 13);
            this.categoriesLabel.TabIndex = 1;
            this.categoriesLabel.Text = "Categories";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(391, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Menu";
            // 
            // outputSummaryLabel
            // 
            this.outputSummaryLabel.AutoSize = true;
            this.outputSummaryLabel.Location = new System.Drawing.Point(12, 327);
            this.outputSummaryLabel.Name = "outputSummaryLabel";
            this.outputSummaryLabel.Size = new System.Drawing.Size(82, 13);
            this.outputSummaryLabel.TabIndex = 3;
            this.outputSummaryLabel.Text = "Grade Summary";
            // 
            // outputSummaryTextBox
            // 
            this.outputSummaryTextBox.Location = new System.Drawing.Point(12, 343);
            this.outputSummaryTextBox.Multiline = true;
            this.outputSummaryTextBox.Name = "outputSummaryTextBox";
            this.outputSummaryTextBox.ReadOnly = true;
            this.outputSummaryTextBox.Size = new System.Drawing.Size(365, 251);
            this.outputSummaryTextBox.TabIndex = 4;
            // 
            // gradeControl1
            // 
            this.gradeControl1.Location = new System.Drawing.Point(0, 0);
            this.gradeControl1.Name = "gradeControl1";
            this.gradeControl1.Size = new System.Drawing.Size(361, 271);
            this.gradeControl1.TabIndex = 0;
            // 
            // gradeControl2
            // 
            this.gradeControl2.Location = new System.Drawing.Point(0, 0);
            this.gradeControl2.Name = "gradeControl2";
            this.gradeControl2.Size = new System.Drawing.Size(361, 271);
            this.gradeControl2.TabIndex = 0;
            // 
            // gradeControl3
            // 
            this.gradeControl3.Location = new System.Drawing.Point(0, 0);
            this.gradeControl3.Name = "gradeControl3";
            this.gradeControl3.Size = new System.Drawing.Size(361, 271);
            this.gradeControl3.TabIndex = 0;
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
        private GradeControl.GradeControl assignmentGradeControl;
        private GradeControl.GradeControl quizGradeControl;
        private GradeControl.GradeControl examGradeControl;
        private System.Windows.Forms.Label outputSummaryLabel;
        private System.Windows.Forms.TextBox outputSummaryTextBox;
        private GradeControl.GradeControl gradeControl1;
        private GradeControl.GradeControl gradeControl2;
        private GradeControl.GradeControl gradeControl3;
    }
}


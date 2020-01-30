namespace Grade_Calculator
{
    partial class Form1
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
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.examTabPage = new System.Windows.Forms.TabPage();
            this.categoryTabControl.SuspendLayout();
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
            this.categoryTabControl.Size = new System.Drawing.Size(357, 405);
            this.categoryTabControl.TabIndex = 0;
            // 
            // assignmentsTabPage
            // 
            this.assignmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.assignmentsTabPage.Name = "assignmentsTabPage";
            this.assignmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignmentsTabPage.Size = new System.Drawing.Size(349, 379);
            this.assignmentsTabPage.TabIndex = 0;
            this.assignmentsTabPage.Text = "Assignments";
            this.assignmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // quizTabPage
            // 
            this.quizTabPage.Location = new System.Drawing.Point(4, 22);
            this.quizTabPage.Name = "quizTabPage";
            this.quizTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.quizTabPage.Size = new System.Drawing.Size(349, 379);
            this.quizTabPage.TabIndex = 1;
            this.quizTabPage.Text = "Quizzes";
            this.quizTabPage.UseVisualStyleBackColor = true;
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
            // examTabPage
            // 
            this.examTabPage.Location = new System.Drawing.Point(4, 22);
            this.examTabPage.Name = "examTabPage";
            this.examTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examTabPage.Size = new System.Drawing.Size(349, 379);
            this.examTabPage.TabIndex = 2;
            this.examTabPage.Text = "Exams";
            this.examTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 545);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoryTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.categoryTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl categoryTabControl;
        private System.Windows.Forms.TabPage assignmentsTabPage;
        private System.Windows.Forms.TabPage quizTabPage;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.TabPage examTabPage;
    }
}


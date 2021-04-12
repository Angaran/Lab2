
namespace Lab2
{
    partial class formSemesterGrades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCourse1Prompt = new System.Windows.Forms.Label();
            this.textBoxCourse1Input = new System.Windows.Forms.TextBox();
            this.textBoxCourse2Input = new System.Windows.Forms.TextBox();
            this.labelCourse2Prompt = new System.Windows.Forms.Label();
            this.textBoxCourse4Input = new System.Windows.Forms.TextBox();
            this.labelCourse4Prompt = new System.Windows.Forms.Label();
            this.textBoxCourse3Input = new System.Windows.Forms.TextBox();
            this.labelCourse3Prompt = new System.Windows.Forms.Label();
            this.textBoxCourse5Input = new System.Windows.Forms.TextBox();
            this.labelCourse5Prompt = new System.Windows.Forms.Label();
            this.textBoxCourse6Input = new System.Windows.Forms.TextBox();
            this.labelCourse6Prompt = new System.Windows.Forms.Label();
            this.textBoxCourse7Input = new System.Windows.Forms.TextBox();
            this.labelCourse7Prompt = new System.Windows.Forms.Label();
            this.labelSemesterPrompt = new System.Windows.Forms.Label();
            this.textBoxErrorMessage = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxCourse1LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxCourse2LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxCourse3LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxCourse4LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxCourse5LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxCourse6LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxCourse7LetterGrade = new System.Windows.Forms.TextBox();
            this.textBoxSemesterGradeLetter = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCourse1Prompt
            // 
            this.labelCourse1Prompt.Location = new System.Drawing.Point(2, 19);
            this.labelCourse1Prompt.Name = "labelCourse1Prompt";
            this.labelCourse1Prompt.Size = new System.Drawing.Size(100, 28);
            this.labelCourse1Prompt.TabIndex = 1;
            this.labelCourse1Prompt.Text = "Course &1:";
            this.labelCourse1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCourse1Prompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCourse1Input
            // 
            this.textBoxCourse1Input.Location = new System.Drawing.Point(116, 23);
            this.textBoxCourse1Input.Name = "textBoxCourse1Input";
            this.textBoxCourse1Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse1Input.TabIndex = 2;
            this.textBoxCourse1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse1Input, "Enter the grade for course 1");
            this.textBoxCourse1Input.TextChanged += new System.EventHandler(this.textBoxCourse1Input_TextChanged_1);
            this.textBoxCourse1Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBoxCourse2Input
            // 
            this.textBoxCourse2Input.Location = new System.Drawing.Point(116, 67);
            this.textBoxCourse2Input.Name = "textBoxCourse2Input";
            this.textBoxCourse2Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse2Input.TabIndex = 5;
            this.textBoxCourse2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse2Input, "Enter the grade for course 2");
            this.textBoxCourse2Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelCourse2Prompt
            // 
            this.labelCourse2Prompt.Location = new System.Drawing.Point(2, 63);
            this.labelCourse2Prompt.Name = "labelCourse2Prompt";
            this.labelCourse2Prompt.Size = new System.Drawing.Size(100, 28);
            this.labelCourse2Prompt.TabIndex = 4;
            this.labelCourse2Prompt.Text = "Course &2:";
            this.labelCourse2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCourse4Input
            // 
            this.textBoxCourse4Input.Location = new System.Drawing.Point(116, 149);
            this.textBoxCourse4Input.Name = "textBoxCourse4Input";
            this.textBoxCourse4Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse4Input.TabIndex = 11;
            this.textBoxCourse4Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse4Input, "Enter the grade for course 4");
            this.textBoxCourse4Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelCourse4Prompt
            // 
            this.labelCourse4Prompt.Location = new System.Drawing.Point(2, 145);
            this.labelCourse4Prompt.Name = "labelCourse4Prompt";
            this.labelCourse4Prompt.Size = new System.Drawing.Size(100, 29);
            this.labelCourse4Prompt.TabIndex = 10;
            this.labelCourse4Prompt.Text = "Course &4:";
            this.labelCourse4Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCourse3Input
            // 
            this.textBoxCourse3Input.Location = new System.Drawing.Point(116, 110);
            this.textBoxCourse3Input.Name = "textBoxCourse3Input";
            this.textBoxCourse3Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse3Input.TabIndex = 8;
            this.textBoxCourse3Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse3Input, "Enter the grade for course 3");
            this.textBoxCourse3Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelCourse3Prompt
            // 
            this.labelCourse3Prompt.Location = new System.Drawing.Point(2, 106);
            this.labelCourse3Prompt.Name = "labelCourse3Prompt";
            this.labelCourse3Prompt.Size = new System.Drawing.Size(100, 28);
            this.labelCourse3Prompt.TabIndex = 7;
            this.labelCourse3Prompt.Text = "Course &3:";
            this.labelCourse3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCourse5Input
            // 
            this.textBoxCourse5Input.Location = new System.Drawing.Point(116, 196);
            this.textBoxCourse5Input.Name = "textBoxCourse5Input";
            this.textBoxCourse5Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse5Input.TabIndex = 14;
            this.textBoxCourse5Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse5Input, "Enter the grade for course 5");
            this.textBoxCourse5Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelCourse5Prompt
            // 
            this.labelCourse5Prompt.Location = new System.Drawing.Point(2, 192);
            this.labelCourse5Prompt.Name = "labelCourse5Prompt";
            this.labelCourse5Prompt.Size = new System.Drawing.Size(100, 28);
            this.labelCourse5Prompt.TabIndex = 13;
            this.labelCourse5Prompt.Text = "Course &5:";
            this.labelCourse5Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCourse6Input
            // 
            this.textBoxCourse6Input.Location = new System.Drawing.Point(116, 242);
            this.textBoxCourse6Input.Name = "textBoxCourse6Input";
            this.textBoxCourse6Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse6Input.TabIndex = 17;
            this.textBoxCourse6Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse6Input, "Enter the grade for course 6");
            this.textBoxCourse6Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelCourse6Prompt
            // 
            this.labelCourse6Prompt.Location = new System.Drawing.Point(2, 238);
            this.labelCourse6Prompt.Name = "labelCourse6Prompt";
            this.labelCourse6Prompt.Size = new System.Drawing.Size(100, 28);
            this.labelCourse6Prompt.TabIndex = 16;
            this.labelCourse6Prompt.Text = "Course &6:";
            this.labelCourse6Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCourse7Input
            // 
            this.textBoxCourse7Input.Location = new System.Drawing.Point(116, 291);
            this.textBoxCourse7Input.Name = "textBoxCourse7Input";
            this.textBoxCourse7Input.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse7Input.TabIndex = 20;
            this.textBoxCourse7Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse7Input, "Enter the grade for course 7");
            this.textBoxCourse7Input.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // labelCourse7Prompt
            // 
            this.labelCourse7Prompt.Location = new System.Drawing.Point(2, 287);
            this.labelCourse7Prompt.Name = "labelCourse7Prompt";
            this.labelCourse7Prompt.Size = new System.Drawing.Size(100, 28);
            this.labelCourse7Prompt.TabIndex = 19;
            this.labelCourse7Prompt.Text = "Course &7:";
            this.labelCourse7Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSemesterPrompt
            // 
            this.labelSemesterPrompt.Location = new System.Drawing.Point(2, 328);
            this.labelSemesterPrompt.Name = "labelSemesterPrompt";
            this.labelSemesterPrompt.Size = new System.Drawing.Size(100, 28);
            this.labelSemesterPrompt.TabIndex = 22;
            this.labelSemesterPrompt.Text = "&Semester:";
            this.labelSemesterPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSemesterPrompt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxErrorMessage
            // 
            this.textBoxErrorMessage.Location = new System.Drawing.Point(13, 373);
            this.textBoxErrorMessage.Multiline = true;
            this.textBoxErrorMessage.Name = "textBoxErrorMessage";
            this.textBoxErrorMessage.ReadOnly = true;
            this.textBoxErrorMessage.Size = new System.Drawing.Size(319, 162);
            this.textBoxErrorMessage.TabIndex = 25;
            this.toolTip1.SetToolTip(this.textBoxErrorMessage, "Displaus error messages");
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(34, 552);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 26;
            this.buttonCalculate.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.buttonCalculate, "Click to attempt to calculate the semester\'s average");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(136, 552);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 27;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset all form fields");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(235, 552);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Click to end the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxCourse1LetterGrade
            // 
            this.textBoxCourse1LetterGrade.Location = new System.Drawing.Point(230, 24);
            this.textBoxCourse1LetterGrade.Name = "textBoxCourse1LetterGrade";
            this.textBoxCourse1LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse1LetterGrade.TabIndex = 29;
            // 
            // textBoxCourse2LetterGrade
            // 
            this.textBoxCourse2LetterGrade.Location = new System.Drawing.Point(230, 67);
            this.textBoxCourse2LetterGrade.Name = "textBoxCourse2LetterGrade";
            this.textBoxCourse2LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse2LetterGrade.TabIndex = 30;
            // 
            // textBoxCourse3LetterGrade
            // 
            this.textBoxCourse3LetterGrade.Location = new System.Drawing.Point(230, 110);
            this.textBoxCourse3LetterGrade.Name = "textBoxCourse3LetterGrade";
            this.textBoxCourse3LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse3LetterGrade.TabIndex = 31;
            // 
            // textBoxCourse4LetterGrade
            // 
            this.textBoxCourse4LetterGrade.Location = new System.Drawing.Point(230, 149);
            this.textBoxCourse4LetterGrade.Name = "textBoxCourse4LetterGrade";
            this.textBoxCourse4LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse4LetterGrade.TabIndex = 32;
            // 
            // textBoxCourse5LetterGrade
            // 
            this.textBoxCourse5LetterGrade.Location = new System.Drawing.Point(230, 197);
            this.textBoxCourse5LetterGrade.Name = "textBoxCourse5LetterGrade";
            this.textBoxCourse5LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse5LetterGrade.TabIndex = 33;
            // 
            // textBoxCourse6LetterGrade
            // 
            this.textBoxCourse6LetterGrade.Location = new System.Drawing.Point(230, 238);
            this.textBoxCourse6LetterGrade.Name = "textBoxCourse6LetterGrade";
            this.textBoxCourse6LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse6LetterGrade.TabIndex = 34;
            // 
            // textBoxCourse7LetterGrade
            // 
            this.textBoxCourse7LetterGrade.Location = new System.Drawing.Point(230, 292);
            this.textBoxCourse7LetterGrade.Name = "textBoxCourse7LetterGrade";
            this.textBoxCourse7LetterGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourse7LetterGrade.TabIndex = 35;
            // 
            // textBoxSemesterGradeLetter
            // 
            this.textBoxSemesterGradeLetter.Location = new System.Drawing.Point(230, 328);
            this.textBoxSemesterGradeLetter.Name = "textBoxSemesterGradeLetter";
            this.textBoxSemesterGradeLetter.Size = new System.Drawing.Size(100, 23);
            this.textBoxSemesterGradeLetter.TabIndex = 36;
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(116, 328);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(100, 23);
            this.textBoxSemester.TabIndex = 37;
            // 
            // formSemesterGrades
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(344, 579);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.textBoxSemesterGradeLetter);
            this.Controls.Add(this.textBoxCourse7LetterGrade);
            this.Controls.Add(this.textBoxCourse6LetterGrade);
            this.Controls.Add(this.textBoxCourse5LetterGrade);
            this.Controls.Add(this.textBoxCourse4LetterGrade);
            this.Controls.Add(this.textBoxCourse3LetterGrade);
            this.Controls.Add(this.textBoxCourse2LetterGrade);
            this.Controls.Add(this.textBoxCourse1LetterGrade);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxErrorMessage);
            this.Controls.Add(this.labelSemesterPrompt);
            this.Controls.Add(this.textBoxCourse7Input);
            this.Controls.Add(this.labelCourse7Prompt);
            this.Controls.Add(this.textBoxCourse6Input);
            this.Controls.Add(this.labelCourse6Prompt);
            this.Controls.Add(this.textBoxCourse5Input);
            this.Controls.Add(this.labelCourse5Prompt);
            this.Controls.Add(this.textBoxCourse3Input);
            this.Controls.Add(this.labelCourse3Prompt);
            this.Controls.Add(this.textBoxCourse4Input);
            this.Controls.Add(this.labelCourse4Prompt);
            this.Controls.Add(this.textBoxCourse2Input);
            this.Controls.Add(this.labelCourse2Prompt);
            this.Controls.Add(this.textBoxCourse1Input);
            this.Controls.Add(this.labelCourse1Prompt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formSemesterGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semester Grades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourse1Prompt;
        private System.Windows.Forms.TextBox textBoxCourse1Input;
        private System.Windows.Forms.TextBox textBoxCourse2Input;
        private System.Windows.Forms.Label labelCourse2Prompt;
        private System.Windows.Forms.TextBox textBoxCourse4Input;
        private System.Windows.Forms.Label labelCourse4Prompt;
        private System.Windows.Forms.TextBox textBoxCourse3Input;
        private System.Windows.Forms.Label labelCourse3Prompt;
        private System.Windows.Forms.TextBox textBoxCourse5Input;
        private System.Windows.Forms.Label labelCourse5Prompt;
        private System.Windows.Forms.TextBox textBoxCourse6Input;
        private System.Windows.Forms.Label labelCourse6Prompt;
        private System.Windows.Forms.TextBox textBoxCourse7Input;
        private System.Windows.Forms.Label labelCourse7Prompt;
        private System.Windows.Forms.Label labelSemesterPrompt;
        private System.Windows.Forms.TextBox textBoxErrorMessage;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxCourse1LetterGrade;
        private System.Windows.Forms.TextBox textBoxCourse2LetterGrade;
        private System.Windows.Forms.TextBox textBoxCourse3LetterGrade;
        private System.Windows.Forms.TextBox textBoxCourse4LetterGrade;
        private System.Windows.Forms.TextBox textBoxCourse5LetterGrade;
        private System.Windows.Forms.TextBox textBoxCourse6LetterGrade;
        private System.Windows.Forms.TextBox textBoxCourse7LetterGrade;
        private System.Windows.Forms.TextBox textBoxSemesterGradeLetter;
        private System.Windows.Forms.TextBox textBoxSemester;
    }
}


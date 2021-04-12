//Author: Angaran Yogeswaran
//Last Modified: Feb 5th 2021
//Description: This Program Accepts up to 7 course grades from a user and
//calculates letter grades for all valid grades entered, and  can determine
//overall average for the semester. Functionality for clear and exit application
//is also given.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class formSemesterGrades : Form
    {
        //Declare arrays for the input and output textboxes
        TextBox[] inputTextBoxArray;
        TextBox[] outputTextBoxArray;
        public formSemesterGrades()
        {
            InitializeComponent();

            //Initalize the arrays of controls now that the form has been populated
            inputTextBoxArray = new TextBox[] { textBoxCourse1Input,textBoxCourse2Input,textBoxCourse3Input,
                textBoxCourse4Input,textBoxCourse5Input,textBoxCourse6Input,textBoxCourse7Input};

            outputTextBoxArray = new TextBox[] { textBoxCourse1LetterGrade, textBoxCourse2LetterGrade, textBoxCourse3LetterGrade, textBoxCourse4LetterGrade, textBoxCourse5LetterGrade,
            textBoxCourse6LetterGrade,textBoxCourse7LetterGrade};
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCourse1LetterGrade_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCourse1Input_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        #region "Event Handlers"
        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
        private void LeaveTextBox(object sender, EventArgs e)
        {

        }

        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            GetLetterGrade(letterGrade);
        }

        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }
        #endregion



        #region "Functions"

        /// <summary>
        /// Reset the form to its default state with clear input and output fields and set focus
        /// </summary>

        private void SetDefaults()
        {
            ClearControls(inputTextBoxArray);
            ClearControls(outputTextBoxArray);
            textBoxErrorMessage.Clear();
            textBoxSemester.Clear();
            textBoxSemesterGradeLetter.Clear();


            SetControlsEnabled(inputTextBoxArray, true);
            buttonCalculate.Enabled = true;

            textBoxCourse1Input.Focus();

        }



        /// <summary>
        /// Checks whether a textbox is valid or not.
        /// </summary>
        /// <param name="textBoxToValidate">A textbox that we want to check if it contains a valid number in a specified range.</param> 
        /// <returns> true if the textbox is vlaid; false if not</returns>



        private bool ValidateGradeTextbox(TextBox textBoxToValidate) 
        {
            validateText
            return false;
        }


        
        /// <summary>
        /// given a numeric grade, determines a string letter grade.
        /// </summary>
        /// <param name="numericGrade"> a numeric grade</param>
        /// <returns> A letter grade as a string</returns>
        private string GetLetterGrade(double numericGrade) 
        {
            double[] numericGradeArray = {0, 50, 55, 60, 65, 70, 75, 80, 85, 90 };
            string[] letterGradeArray = { "F", "D", "D+", "C", "B-", "B", "B+", "A-", "A", "A+" };
            string letterGrade ="";

            for (int counter = 0; counter < numericGradeArray.Length; counter++) 
            {
                if (numericGrade >= numericGradeArray[counter]) 
                {
                    letterGrade = letterGradeArray[counter];
                }
            }
            return letterGrade;
        }
        /// <summary>
        /// This clears the text property of all controls in the array of controls that is passed in
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// This enables or disables all controls in an array of controls that is passed in
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;

            }
        }
        #endregion

        

        
    }
}

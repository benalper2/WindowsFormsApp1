using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Think these are not needed
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = String.Empty;

            FocusInputText();

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(this.UserInputText.SelectionStart);
            DeleteTextValue();
            FocusInputText();
        }


        #endregion

        #region Operator Methods
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            calculateEquation();
            FocusInputText();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        #endregion

        #region Number Methods

        private void DecimalPointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void No0Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }


        private void No1Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void No2Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void No3Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void No4Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void No5Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void No6Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void No7Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void No8Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void No9Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        #endregion

        private void calculateEquation()
        {
            OperationType myEnum =  OperationType.Multiply;


            this.CalculationResultText.Text = ParseOperation();

            FocusInputText();
        }

        /// <summary>
        /// Parses the user's equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //Get the user's equation input
                var userInput = this.UserInputText.Text; 

                //Remove all spaces
                userInput = userInput.Replace(" ","");

                var operation = new Operation();
                var leftSide = true;
                //var numberString = "0123456789.";
                
                for (int i = 0; i < userInput.Length; i++)
                {
                    //Check if character is a number
                    if ("0123456789.".Contains(userInput[i]))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, userInput[i]);
                    }
                }

                return string.Empty;
                //throw new ArgumentNullException("Something is null");
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="currentCharacter"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another can't be added");

            }
            return currentNumber + newCharacter;
        }



        #region Private Helpers
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        
        /// <summary>
        ///Inserts the given text into the user input text box
        /// </summary>
        /// <param name="v"></param>
        private void InsertTextValue(string v)
        {
            //Remember original selection start position - seems to get reset otherwise
            var selectionStart = this.UserInputText.SelectionStart;

            //set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, v);

            //restore the selections start
            this.UserInputText.SelectionStart = selectionStart + v.Length;

            //set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the left of the selection start
        /// </summary>
        /// <param name="v"></param>
        private void DeleteTextValue()
        {
            //Remember original selection start position
            var selectionStart = this.UserInputText.SelectionStart;

            if (this.UserInputText.SelectionStart > 0) 
            {
                //Delete the character to the left of the selection 
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart -1, 1);
                //Restore the selections start
                this.UserInputText.SelectionStart = selectionStart - 1;
            }

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Calculate the given equation and output the answer to the user label
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>

        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringExtension;

/**
* 10/27/21
* CSC 253
* Nicholas Baxley
* Showing the capabilities of string extensions
*/

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {       
            InitializeComponent();
        }

        // Closes the program
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Grabs the text from the input box
        private string Input()
        {
            return textBoxInput.Text;
        }

        // Clears the output box.
        private void Clear()
        {
            listBoxOutput.Items.Clear();
        }

        // Prints the string to the outputbox
        private void Output(string output)
        {
            listBoxOutput.Items.Add(output);
        }

        // Prints the string array to the outputbox
        private void Output(string[] output)
        {
            listBoxOutput.Items.Add(output[0] + "/" + output[1] + "/" + output[2]);
        }

        // Turns string into an array of chars then prints it
        private void buttonChar_Click(object sender, EventArgs e)
        {
            char[] charArray = StrConvert.ToChars(Input());
            Clear();

            //Printing all characters except whitespaces
            foreach (char symbol in charArray)
            {
                if (symbol != ' ')
                {
                    listBoxOutput.Items.Add(symbol + ", ");
                }             
            }            
        }

        // Validates the input is a date and then prints it as a three element string array
        private void buttonDate_Click(object sender, EventArgs e)
        {
            bool realDate = DateTime.TryParseExact(Input(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
            Clear();

            if (realDate)
            {
                Output(StrConvert.ToDate(Input()));
            }
            else
            {
                Output("Not the correct format or date is not a real date!");
            }
        }

        // Validates the input is a telephone number then prints it
        private void buttonTelephone_Click(object sender, EventArgs e)
        {           
            Clear();

            // Checks to see if the input is 10 numbers
            if (Input().Length == 10 && int.TryParse(Input(), out int d))
            {
                Output(StrConvert.ToPhoneNumber(Input()));
            }
            else
            {
                Output("Input must be 10 numbers!");
            }
        }

        // Prints the input backwards
        private void buttonBackwards_Click(object sender, EventArgs e)
        {

        }
    }
}

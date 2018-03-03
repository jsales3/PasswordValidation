using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The NumberUpperCase method accpts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int upperCase = 0;

            //Counts the uppercase characters in str.
            foreach(char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }

            //Return number of uppercase characters.
            return upperCase;
        }

        //The NumberLowerCase method accpte a string argument 
        //and returns the number of lowercase letters it contains
        private int NumberLowerCase(string str)
        {
            int lowerCase = 0;

            //count the lowercase characters in str.
            foreach(char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }

            //Returns number of lowercase characters
            return lowerCase;
        }

        //The NumberDigits method accepts a string argument 
        //and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digits = 0;

            //Counts the digits in str.
            foreach(char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }

            //Returns number of digits
            return digits;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;

            //Get password from the TextBox
            string password = passwordTextBox.Text;

            //Validate password
            if(password.Length >= MIN_LENGTH && NumberUpperCase(password) >= 1 
                && NumberLowerCase(password) >= 1 && NumberDigits(password) >= 1)
            {
                MessageBox.Show("The password is invalid.");
            }
            else
            {
                MessageBox.Show("The password does not meet " + "the requirements.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

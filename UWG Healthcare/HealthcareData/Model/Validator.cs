﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareData.Model
{   // Class that is used to validate information.
    public class Validator
    {
        private static string title = "Entry Error";

        // Returns title of the message box
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        // Checks that the information is present
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        // Checks that the SSN contains 9 digits
        public static bool IsValidSSN(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (!Regex.IsMatch(textBox.Text, @"^\d{9}$"))
                {
                    MessageBox.Show(textBox.Tag.ToString() + " must contain 9 digits", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        // Checks that the SSN contains 9 digits
        public static bool IsValidPhonNum(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (!Regex.IsMatch(textBox.Text, @"^\d{10}$"))
                {
                    MessageBox.Show(textBox.Tag.ToString() + " must contain 10 digits", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }


        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                if (textBox.Text.All(char.IsDigit))
                {
                    Convert.ToInt32(textBox.Text);
                    return true;
                }
                else
                {
                    MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}

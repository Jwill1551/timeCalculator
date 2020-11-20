//Joshua
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeCalc
{
    public partial class timeCalc : Form
    {
        public timeCalc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert the string into a interger
                int seconds = Convert.ToInt32(secondsTextBox.Text);
                int num = seconds / 60;

                if (seconds >= 86000)
                {
                    outputTextBox.Text = num.ToString() + " days";
                } else if (seconds >= 3600)
                {

                    outputTextBox.Text = num.ToString() + "hr";
                } else if (seconds >= 60)
                {
                    outputTextBox.Text = num.ToString() + "m";
                } else
                {
                    MessageBox.Show("Value is less than a minute");
                }
            }
            catch
            {
                //If an error is found the program will give an error message
                MessageBox.Show("Error with program!");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Resets the values in the calculator
            secondsTextBox.Text = " ";
            outputTextBox.Text = " ";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/*
 * Created by: Allison Cook
 * Created on: 14 May 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program allows the users to enter marks into a list then calculates the average of the list
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsAllisonC
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables
            int userMark = -1;

            //if the user entered a number that is an int
            try
            {
                //try to set the number to the variable
                userMark = int.Parse(txtMark.Text);
            }
            catch
            {
                //display the message box
                MessageBox.Show("Please enter a number between 0 and 100", "List Average");
            }

            //check if the number entered is between 0 and 100
            if (userMark >= 0 && userMark<= 100)
            {
                //add the mark to the listbox
                this.lstMarks.Items.Add(userMark);

                //add it to the list
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

        }
    }
}

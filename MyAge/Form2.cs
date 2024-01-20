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
using static System.Net.Mime.MediaTypeNames;

namespace MyAge
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ageTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // get the enter key press event
            if (e.KeyChar == (char)Keys.Enter)
            {
                // check if the ageTextBox is empty or not
                if (ageTextbox.Text == "")
                {
                    // impulse the ageTextbox
                    ageTextbox.Focus();
                    errorInfoLabel.Text = "Age (Enter a number)";
                    return;
                }

                // check the yearTextBox is empty or not
                if (yearTextbox.Text == "")
                {
                    // set focus to yearTextBox
                    yearTextbox.Focus();

                    // set the errorInfoLabel text to blank
                    errorInfoLabel.Text = "";
                }
                else
                {
                    // if yearTextBox is not empty, call button1_Click event
                    caculateBtn_Click(sender, e);
                }
            }


            // accept only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void yearTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // get the enter key press event
            if (e.KeyChar == (char)Keys.Enter)
            {
                // check if the ageTextBox is empty or not
                if (yearTextbox.Text == "")
                {
                    yearTextbox.Focus();
                    errorInfoLabel.Text = "Year (Enter a number)";
                    return;
                }

                // check the yearTextBox is empty or not
                if (yearTextbox.Text == "")
                {
                    // set focus to yearTextBox
                    ageTextbox.Focus();

                    // set the errorInfoLabel text to blank
                    errorInfoLabel.Text = "";
                }
                else
                {
                    // if yearTextBox is not empty, call button1_Click event
                    caculateBtn_Click(sender, e);
                }
            }


            // accept only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void caculateBtn_Click(object sender, EventArgs e)
        {
            string age = ageTextbox.Text;
            string year = yearTextbox.Text;

            // check if age or year is empty or not a number
            if (age == "" || year == "")
            {
                errorInfoLabel.Text = "Please enter a valid number";
                return;
            }

            // convert age and year to integer
            int ageInt = Convert.ToInt32(age);
            int yearInt = Convert.ToInt32(year);

            // check if age is negative or year is negative or not a number or age is greater then year
            if (ageInt < 0 || yearInt < 0 || ageInt >= yearInt)
            {
                errorInfoLabel.Text = "Please enter a valid number";
                return;
            }

            int yearBorn = yearInt - ageInt;

            int yearBornGregorian = yearBorn + 621;

            // create a new instance of PersianCalendar and initialize it with the yearBorn
            PersianCalendar pc = new PersianCalendar();

            DateTime firstOfBornDate = pc.ToDateTime(yearBorn, 1, 1, 0, 0, 0, 0);
            DateTime lastOfBornDate = pc.ToDateTime(yearBorn, 12, 29, 0, 0, 0, 0);

            // set the resultTableLayout visible
            resultTableLayout.Visible = true;

            // set bornYearShamsiLabel
            bornYearShamsiLabel.Text = yearBorn.ToString();

            // set bornYearGregorianLabel
            bornYearMiladiLabel.Text = yearBornGregorian.ToString() + " - " + (yearBornGregorian + 1).ToString();

            // set firstDateLabel
            firstDayOfBornYearLabel.Text = firstOfBornDate.ToString("dd.MM.yyyy");

            // set lastDateLabel
            lastDayOfBornYearLabel.Text = lastOfBornDate.ToString("dd.MM.yyyy");

            // set ageFromNowLabel and caculate the age from now with sufix of years
            ageFromNowLabel.Text = (DateTime.Now.Year - yearBornGregorian).ToString() + " Years old";

        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            // check if the compareMaskedTextbox is validated or not
            if (!compareMaskedTextbox.MaskCompleted)
            {
                // set focus to compareMaskedTextbox
                compareMaskedTextbox.Focus();

                // set the errorInfoLabel text to blank
                errorInfoLabel.Text = "Please enter a valid date";
                return;
            }

            // set the errorInfoLabel text to blank
            errorInfoLabel.Text = "";
            
            string compareDateStr = compareMaskedTextbox.Text;

            // the compareMaskedTextbox is a date time, so we can convert it to DateTime
            DateTime compareDate;

            if (!DateTime.TryParseExact(compareDateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out compareDate))
            {
                // set errorInfoLabel text 
                errorInfoLabel.Text = "Error in converting firstDayOfBornYearDate to DateTime";
            }

            // set the errorInfoLabel text to blank
            errorInfoLabel.Text = "";

            // get the first day of the year value from its label
            string firstDayOfBornYear = firstDayOfBornYearLabel.Text;

            // convert the firstDayOfBornYear to DateTime form format dd.MM.yyyy
            DateTime firstDayOfBornYearDate;

            // Using DateTime.TryParseExact
            if (!DateTime.TryParseExact(firstDayOfBornYear, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out firstDayOfBornYearDate))
            {
                // set errorInfoLabel text 
                errorInfoLabel.Text = "Error in converting firstDayOfBornYearDate to DateTime";
            }

            // get the last day of the year value from its label
            string lastDayOfBornYear = lastDayOfBornYearLabel.Text;

            // convert the lastDayOfBornYear to DateTime
            DateTime lastDayOfBornYearDate;

            // Using DateTime.TryParseExact
            if (!DateTime.TryParseExact(lastDayOfBornYear, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out lastDayOfBornYearDate))
            {
                // set errorInfoLabel text 
                errorInfoLabel.Text = "Error in converting lastDayOfBornYearDate to DateTime";
            }

            // set the compareResultLabel text to "Compare with " comcatenate with formatted dd.MM.yyyy 
            compareInfoLabel.Text = "Compare with " + compareDate.ToString("dd.MM.yyyy") + ":";

            // compare the compareDate with firstDayOfBornYearDate and lastDayOfBornYearDate
            if (compareDate >= firstDayOfBornYearDate && compareDate <= lastDayOfBornYearDate)
            {
                // set the compareResultLabel text to Compare with date is in the year you were born
                compareResultLabel.Text = "Valid range";

                // set the compareResultLabel text color to green
                compareResultLabel.ForeColor = Color.Green;
            }
            else
            {
                string diffResultForHuman = compareDate > lastDayOfBornYearDate ? DateDiffForHuman(compareDate, lastDayOfBornYearDate) : DateDiffForHuman(firstDayOfBornYearDate, compareDate);
                // set the compareResultLabel text to Compare with date is not in the year you were born
                compareResultLabel.Text = diffResultForHuman;

                // set the compareInfoLabel text color to red
                compareResultLabel.ForeColor = Color.Red;
            }

        }

        // create a method to return the date comparision result to human readable format like 1 year or less than it show 5 months or less than a month show 19 days
        private string DateDiffForHuman(DateTime date1, DateTime date2)
        {
            // get the difference between two dates
            TimeSpan diff = date1 - date2;

            // get the total days of difference
            int totalDays = (int)diff.TotalDays;

            // get the total months of difference
            int totalMonths = (int)diff.TotalDays / 30;

            // get the total years of difference
            int totalYears = (int)diff.TotalDays / 365;

            // check if the totalYears is greater than 0
            if (totalYears > 0)
            {
                // return the totalYears
                return totalYears.ToString() + " Years";
            }

            // check if the totalMonths is greater than 0
            if (totalMonths > 0)
            {
                // return the totalMonths
                return totalMonths.ToString() + " Months";
            }

            // check if the totalDays is greater than 0
            if (totalDays > 0)
            {
                // return the totalDays
                return totalDays.ToString() + " Days";
            }

            // return the totalDays
            return totalDays.ToString() + " Days";
        }

        private void compareMaskedTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // get the enter key press event
            if (e.KeyChar == (char)Keys.Enter)
            {
                // check if the compareMaskedTextbox is validated or not
                if (!compareMaskedTextbox.MaskCompleted)
                {
                    // set focus to compareMaskedTextbox
                    compareMaskedTextbox.Focus();

                    // set the errorInfoLabel text to blank
                    errorInfoLabel.Text = "Please enter a valid date";
                    return;
                }

                // set the errorInfoLabel text to blank
                errorInfoLabel.Text = "";

                // call the compareBtn_Click event
                compareBtn_Click(sender, e);
            }
        }
    }
}

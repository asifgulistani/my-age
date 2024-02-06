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

namespace MyAge
{
    public partial class TabSelectorForm : Form
    {
        public TabSelectorForm()
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

            // set bornYearShamsiLabel like this 01/01 - 29/12 (1399)
            bornYearShamsiLabel.Text = "01/01 - 29/12 (" + yearBorn.ToString() + ")";

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

            // change the saparator from , to .
            compareDateStr = compareDateStr.Replace(",", ".");

            // the compareMaskedTextbox is a date time, so we can convert it to DateTime
            DateTime compareDate;

            if (!DateTime.TryParseExact(compareDateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out compareDate))
            {
                // set errorInfoLabel text 
                errorInfoLabel.Text = "Error in converting firstDayOfBornYearDate to DateTime";
            }

            // set the errorInfoLabel text to blank
            errorInfoLabel.Text = "";

            // simulate the data culculated again by disabling and enabling the resultTableLayout
            resultTableLayout.Visible = false;
            resultTableLayout.Visible = true;

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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // set the ageTextbox, yearTextbox, compareMaskedTextbox text to blank
            ageTextbox.Text = "";
            yearTextbox.Text = "";
            compareMaskedTextbox.Text = "";

            // unvisible the resultTableLayout
            resultTableLayout.Visible = false;
        }

        private void convertShamsiBtn_Click(object sender, EventArgs e)
        {
            // unvisible the resultShamsiLbl
            resultShamsiLbl.Visible = false;

            // check if the shamsiMaskedTextbox is validated or not
            if (!shamsiMaskedText.MaskCompleted)
            {
                // set focus to shamsiMaskedTextbox
                shamsiMaskedText.Focus();

                // enable the resultShamsiLbl
                resultShamsiLbl.Enabled = true;

                // set the resultShamsiLbl text to persian please enter a valid date
                resultShamsiLbl.Text = "لطفا تاریخ صحیح وارد کنید";

                // visible the resultShamsiLbl
                resultShamsiLbl.Visible = true;
                return;
            }

            // set the ResultShamsiLbl text to blank
            resultShamsiLbl.Text = "";

            // get the shamsiMaskedText value
            string shamsiDateStr = shamsiMaskedText.Text;
            shamsiDateStr = shamsiDateStr.Replace(",", ".");

            // create a new instance of PersianCalendar and initialize it with the yearBorn
            PersianCalendar pc = new PersianCalendar();

            // split the shamsiDateStr by . and convert it to integer
            int year = Convert.ToInt32(shamsiDateStr.Split('.')[2]);
            int month = Convert.ToInt32(shamsiDateStr.Split('.')[1]);
            int day = Convert.ToInt32(shamsiDateStr.Split('.')[0]);

            // now we can convert the shamsiDateStr to DateTime
            DateTime shamsiDateTime = pc.ToDateTime(year, month, day, 0, 0, 0, 0);

            // set the resultShamsiLbl text to the shamsiDateTime

            resultShamsiLbl.Text = "نتیجه: " + shamsiDateTime.ToString("dd.MM.yyyy") + " (dd.mm.YYYY)";

            // Enable the resultShamsiLbl
            resultShamsiLbl.Enabled = true;

            // visible the resultShamsiLbl
            resultShamsiLbl.Visible = true;
        }

        private void shamsiMaskedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // call the convertShamsiBtn_Click event
            if (e.KeyChar == (char)Keys.Enter)
            {
                convertShamsiBtn_Click(sender, e);
            }
        }

        private void convertMiladiBtn_Click(object sender, EventArgs e)
        {
            // this method is similar to convertShamsiBtn_Click but it converts the miladi date to shamsi date
            resultMiladiLbl.Visible = false;

            if (!miladiMaskedText.MaskCompleted)
            {
                miladiMaskedText.Focus();
                resultMiladiLbl.Enabled = true;
                resultMiladiLbl.Text = "Please enter a valid date";
                resultMiladiLbl.Visible = true;
                return;
            }

            resultMiladiLbl.Text = "";
            resultMiladiLbl.Enabled = false;
            resultMiladiLbl.Visible = false;

            string miladiDateStr = miladiMaskedText.Text;
            miladiDateStr = miladiDateStr.Replace(",", ".");

            PersianCalendar pc = new PersianCalendar();

            int year = Convert.ToInt32(miladiDateStr.Split('.')[2]);
            int month = Convert.ToInt32(miladiDateStr.Split('.')[1]);
            int day = Convert.ToInt32(miladiDateStr.Split('.')[0]);

            DateTime miladiDateTime = new DateTime(year, month, day);

            // convert the miladiDateTime to shamsiDateTime
            int yearShamsi = pc.GetYear(miladiDateTime);
            int monthShamsi = pc.GetMonth(miladiDateTime);
            int dayShamsi = pc.GetDayOfMonth(miladiDateTime);

            // set resultMiladiLbl result: dayShamsi/monthShamsi/yearShamsi (dd.mm.YYYY)
            resultMiladiLbl.Text = "Result: " + dayShamsi.ToString() + "/" + monthShamsi.ToString() + "/" + yearShamsi.ToString() + " (dd.mm.YYYY)";
            resultMiladiLbl.Enabled = true;
            resultMiladiLbl.Visible = true;

        }

        private void miladiMaskedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // call the convertMiladiBtn_Click event
            if (e.KeyChar == (char)Keys.Enter)
            {
                convertMiladiBtn_Click(sender, e);
            }
        }
    }
}

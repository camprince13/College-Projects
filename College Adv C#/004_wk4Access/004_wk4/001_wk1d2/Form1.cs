//Cameron Prince
//Original 10/9/2014    001_wk1d2
//Modified 12/4/2014
//004_wk4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; //access database
//using System.Data; //database


namespace _001_wk1d2
{
    public partial class Form1 : Form
    {

        //person Class

        //validation class


        public Form1()
        {
            InitializeComponent();
        }

        //Button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Create an instance of a person
            person temp = new person("02886");

            //Assign the instance of a person a name
            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.Feedback = "";
            temp.Addr1 = txtAddr1.Text;
            temp.Addr2 = txtAddr2.Text;
            temp.Area_Code = txtAreaCode.Text;
            temp.City = txtCity.Text;
            temp.Email = txtEmail.Text;
            temp.Phone = txtPhone.Text;
            temp.Prefix = txtPrefix.Text;
            temp.State = txtState.Text;
            temp.Suffix = txtSuffix.Text;
            temp.Country = txtCountry.Text;




            //new validation testing *********************************
            if (validation.IsValidEmail(temp.Email) == false)
            { temp.Feedback += "\nError: Invalid Email."; }

            if (validation.IsFilledIn(temp.FName) == false)
            { temp.Feedback += "\nError: Blank first name."; }

            if (validation.IsFilledIn(temp.LName) == false)
            { temp.Feedback += "\nError: Blank last name."; }

            if (validation.IsFilledIn(txtMoney.Text) == false)
            { temp.Feedback += "\nError: Blank money field."; }
            else
            {
                try
                { temp.Money = Convert.ToDouble(txtMoney.Text); }

                catch { temp.Feedback += "\nError: Invalid number in money field."; }
            }

            if (validation.IsValidLength(temp.State) == false)
            { temp.Feedback += "\nError: Invalid state initials."; }

            if (validation.IsWithinRange(temp.Country) == false)
            { temp.Feedback += "\nError: Invalid country length."; }

            if (validation.IsWithinRange(temp.Money) == false)
            { temp.Feedback += "\nError: Invalid currency amount."; }
            //*********************************************************





            temp.Feedback += temp.AddContact();

            if (temp.Feedback.Contains("Error"))
            { lblFeedback.Text += temp.Feedback; }
            

            else
            {
                
                //Give feedback from the class instance (object)
                temp.Feedback += temp.Prefix;
                temp.Feedback += " " + temp.FName;
                temp.Feedback += " " + temp.MName;
                temp.Feedback += " " + temp.LName;
                temp.Feedback += " " + temp.Suffix;
                temp.Feedback += " $" + temp.Money.ToString();
                temp.Feedback += "\n" + temp.Addr1;
                temp.Feedback += " " + temp.Addr2;
                temp.Feedback += " " + temp.City;
                temp.Feedback += " " + temp.State;
                temp.Feedback += " " + temp.Zip;
                temp.Feedback += "\n" + temp.Area_Code;
                temp.Feedback += " " + temp.Phone;
                temp.Feedback += "\n" + temp.Email;

                lblFeedback.Text += temp.Feedback;

            }
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Clear
        private void btnCls_Click(object sender, EventArgs e)
        {
            lblFeedback.Text = "";
        }
        //Quick Fill
        private void label1_Click(object sender, EventArgs e)
        {
            txtFName.Text = "Carl";
            txtMName.Text = "I";
            txtLName.Text = "Prince";
            txtMoney.Text = "80";
            txtSuffix.Text = "III";
            txtPrefix.Text = "Dr.";
            txtAddr1.Text = "3595 Post rd";
            txtAddr2.Text = "Apt # 21-302";
            txtCity.Text = "Warwick";
            txtState.Text = "RI";
            txtZip.Text = "02886";
            txtCountry.Text = "USA";
            txtAreaCode.Text = "401";
            txtPhone.Text = "921-4386";
            txtEmail.Text = "ciprince@email.neit.edu";
        }
       
      
    }
}


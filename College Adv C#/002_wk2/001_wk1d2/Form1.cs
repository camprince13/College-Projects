//Cameron Prince
//Original 10/9/2014    001_wk1d2
//Modified 10/14/2014
//002_wk2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _001_wk1d2
{
    public partial class Form1 : Form
    {
        //Struct
        /*public struct person
        {
            public string FName;
            public string MName;
            public string LName;
        }*/

        //Class
        public class person
        {
            private string fName = "";
            private string mName = "";
            private string lName = "";
            private double money = 0;
            private string feedback = "";
            /*prefix, suffix, address1, address2, city, state, zip, area code, phone#, email*/
            private string suffix = "";
            private string prefix = "";
            private string addr1 = "";
            private string addr2 = "";
            private string city = "";
            private string state = "";
            private string zip = "";
            private string area_code = "";
            private string phone = "";
            private string email = "";

            public double Money
            {
                get
                { return money; }
                set
                { if (value >= 0 && value <= 100.00)
                    money = value;
                 else
                Feedback += "\nError: Invalid value";
                }
            }


            //passing a clone instead of original
            public string FName
            {
                get
                { return fName; }
                set
                {
                    if (!value.Contains("Nacho"))
                        fName = value;
                    else
                        Feedback += "\nError: Name contains food";
                }
            }

            public string LName
            {
                get
                { return lName; }
                set
                { lName = value; }
            }

            public string Feedback
            {
                get
                { return feedback; }
                set
                { feedback = value; }
            }

            public string MName
            {
                get
                { return mName; }
                set
                {
                    if (!value.Contains("Nacho"))
                        mName = value;
                    else
                        Feedback += "\nError: Name contains food";
                }
            }

            public string Suffix
            {
                get
                { return suffix; }
                set
                { suffix = value; }
            }

            public string Prefix
            {
                get
                { return prefix; }
                set
                { prefix = value; }
            }

            public string Addr1
            {
                get
                { return addr1; }
                set
                { addr1 = value; }
            }

            public string Addr2
            {
                get
                { return addr2; }
                set
                { addr2 = value; }
            }

            public string City
            {
                get
                { return city; }
                set
                { city = value; }
            }

            public string State
            {
                get
                { return state; }
                set
                { state = value; }
            }

            public string Zip
            {
                get
                { return zip; }
                set
                { zip = value; }
            }

            public string Area_Code
            {
                get
                { return area_code; }
                set
                { area_code = value; }
            }

            public string Phone
            {
                get
                { return phone; }
                set
                { phone = value; }
            }

            public string Email
            {
                get
                { return email; }
                set
                { email = value; }
            }

        };

        public Form1()
        {
            InitializeComponent();
        }

        //Button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Create an instance of a person
            person temp = new person();

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
            temp.Zip = txtZip.Text;

            temp.Money = Convert.ToDouble(txtMoney.Text);
            /*if (temp.LName == "Prince")
            {
                temp.FName += "Nachos";
                temp.Money *= 2; }*/

            if (temp.Feedback.Contains("Error:"))
            { lblFeedback.Text += temp.Feedback; }

            else
            {
            //Give feedback from the class instance (object)
            lblFeedback.Text += temp.Prefix;
            lblFeedback.Text += " " + temp.FName;
            lblFeedback.Text += " " + temp.MName;
            lblFeedback.Text += " " + temp.LName;
            lblFeedback.Text += " " + temp.Suffix;
            lblFeedback.Text += " $" + temp.Money.ToString();}
            lblFeedback.Text += "\n" + temp.Addr1;
            lblFeedback.Text += " " + temp.Addr2;
            lblFeedback.Text += " " + temp.City;
            lblFeedback.Text += " " + temp.State;
            lblFeedback.Text += " " + temp.Zip;
            lblFeedback.Text += "\n" + temp.Area_Code;
            lblFeedback.Text += " " + temp.Phone;
            lblFeedback.Text += "\n" + temp.Email;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            lblFeedback.Text = "";
        }

        
    }
}










/*
if(


 public static bool 
*/
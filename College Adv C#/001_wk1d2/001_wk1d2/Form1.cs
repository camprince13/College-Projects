//Cameron Prince
//Original 10/9/2014
//Modified 10/9/2014
//001_wk1d2  using structures

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

            temp.Money = Convert.ToDouble(txtMoney.Text);
            if (temp.LName == "Prince")
            {
                temp.FName += "Nachos";
                temp.Money *= 2; }


            if (temp.Feedback.Contains("Error:"))
            { lblFeedback.Text += temp.Feedback; }

            else
            {
            //Give feedback from the class instance (object)
            lblFeedback.Text = temp.FName;
            lblFeedback.Text += " " + temp.MName;
            lblFeedback.Text += " " + temp.LName;
            lblFeedback.Text += " " + temp.Money.ToString();}

        }

        
    }
}

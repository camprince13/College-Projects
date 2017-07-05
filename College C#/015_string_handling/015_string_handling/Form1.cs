//Cameron Prince
//Original 9/2/2014
//Modified 9/2/2014
//015_string_handling

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _015_string_handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string full = txtName.Text;
            string[] names = full.Trim().Split();

            string first = "";
            string middle = "";
            string last = "";

            if (names.Length == 1)
            { first = names[0]; }
            else if (names.Length == 2)
            { first = names[0];
            last = names[1];}
            else if (names.Length > 2)
            {
                first = names[0];
                middle = names[1];
                last = names[2];
            }


            MessageBox.Show("First Name:\t" + this.ToInitialCap(first) + "\n\n" + "Middle Name:\t" + this.ToInitialCap(middle) + "\n\n" + "Last Name:\t" + this.ToInitialCap(last), "Parse Name");

        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string digits = "";

            foreach (char c in phone)
            {
                if (!(c == '(' || c == ')' || c == ' ' || c == '-' || c == '.'))
                { digits += c; }}

            string standard = digits.Insert(3, "-");
            standard = standard.Insert(7, "-");

            MessageBox.Show("Entered:\t\t" + phone + "\n\n" + "Digits Only:\t" + digits + "\n\n" + "Standard Format:\t" + standard, "Edit Phone Number");
        }

        private string ToInitialCap(string s)
        {
            if (s.Length > 0)
            { string initialCap = s.Substring(0, 1).ToUpper();
            string lowerCaseLetters = s.Substring(1).ToLower();
            s = initialCap + lowerCaseLetters;
            }
            return s;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtName.Text = "Carl Prince";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string ss = txtSS.Text.Trim();
            string temp = "";

            if (ss.Length == 9)
            { temp = ss.Insert(3, "-");
            temp = temp.Insert(6, "-");
            }

            txtSS.Text = temp;
        }

    }
}

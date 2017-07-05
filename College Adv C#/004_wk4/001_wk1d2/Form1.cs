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

        //Student class
        /*public class ImpvPerson : person //con thing
        {

            //Initialize
            private string prefSocMed = "";


            //Clones
            public string PrefSocMed
            {
                get
                { return prefSocMed; }
                set
                { prefSocMed = value; }
            }
        
        
        
        
        }*/











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
        //Enable Student
        private void ckbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStudent.Checked == false)
            { txtPrefSocMed.ReadOnly = false; }
        }

        private void ckbStudent_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}








/*
//connectionstrings.com
public string AddContact(){

string strFeedback = "";

STRING strSQL = "INSERT INTO Persons (FName, Mname, LName, Salary)values (@FNAME, @MNANE, @LNAME, @SALARY)";

OleDbConnection conn = new OleDbConnection();

string strConn = @"Proviver=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Scott.accdb;Persist Security Info=False";
conn.ConnectionString = strConn;




OleDbCommand comm = new OleDbCommand();
comm.CommandText = strSQL;
comm.Connection = conn;



comm.Parameters.AddWithValue("@FName", fName);
comm.Parameters.AddWithValue("@MName", mName);
comm.Parameters.AddWithValue("@LName", lName);
comm.Parameters.AddWithValue("@Salary", salary);


try
    {conn.Open;
strFeedback = comm.ExecuteNonQuery().ToString() + "Record(s) Added";
conn.Close;
    }


catch (Exception err)
    {strFeedback = "ERROR: " + err.Message;
    }
return strFeedback;

}*/





//validation class
/*
public class validation
        {
            //Tests if string contains Poop
            public static bool GotPoop(string temp)
            {
                bool result = false;
                if (temp.Contains("Poop"))
                { result = true; }
                return result;
            }


            //Tests a string to see if it is blank
            public static bool IsFilledIn(string temp)
            {
                bool result = false;
                if (temp.Length > 0)
                { result = true; }
                return result;
            }


            //Tests a double to see if it is blank
            /*public static bool IsFilledIn(double temp)
            {
                bool result = true;
                if (temp == null)
                { result = false; }
                return result;
            }


            //Tests for a valid length for state
            public static bool IsValidLength(string temp)
            {
                bool result = true;
                if (temp.Length != 2)
                { result = false; }
                return result;
            }


            //Tests for the country's length
            public static bool IsWithinRange(string temp)
            {
                bool result = false;
                if (temp.Length > 2 && temp.Length < 20)
                { result = true; }
                return result;
            }

            //Tests money amounts
            public static bool IsWithinRange(double temp)
            { bool result = false;
            if (temp >= 0 && temp <= 100)
            { result = true; }
                return result;
            }


            //Checks for valid email
            public static bool IsValidEmail(string temp)
            {
                bool result = true;
                int AtLocation = temp.IndexOf("@");
                int NextAtLocation = temp.IndexOf("@", AtLocation + 1);
                int PeriodLocation = temp.LastIndexOf(".");
                if (temp.Length < 8)
                { result = false; }
                else if (AtLocation < 2)
                { result = false; }
                else if (PeriodLocation + 2 > (temp.Length))
                { result = false; }
                return result;
            }


        }

  
 
*/









//person class
/*public class person
        {
            private string fName = "";
            private string mName = "";
            private string lName = "";
            private double money = 0;
            private string feedback = "";
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
            private string country = "";

            public double Money
            {
                get
                { return money; }
                set
                { //if (value >= 0 && value <= 100.00)
                    money = value;
                 //else
                //Feedback += "\nError: Invalid value";
                }
            }


            //passing a clone instead of original
            public string FName
            {
                get
                { return fName; }
                set
                {
                    if (!value.Contains("Poop"))
                        fName = value;
                    else
                        Feedback += "\nError: Name contains excrement.";
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
                    if (!value.Contains("Poop"))
                        mName = value;
                    else
                        Feedback += "\nError: Name contains excrement.";
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

            public string Country
            {
                get
                { return country; }
                set
                { country = value; }
            }


            //Constructor
            public person(string zipcode)
            {
                this.Zip = zipcode;
            }


        };*/
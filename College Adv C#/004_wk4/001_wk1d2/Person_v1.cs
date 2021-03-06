﻿//Cameron Prince
//Original 10/30/2014
//Modified 12/4/2014
//Person Library Class (Person_v1.cs)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace _001_wk1d2
{
    public class person
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
            { money = value;}
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











        public string AddContact()
        {

            string strFeedback = "";

            string strSQL = "INSERT INTO Persons VALUES (@FName, @MName, @LName, @Money, @Addr1, @Addr2, @City, @State, @Zip, @Email, @Area_Code, @Phone, @Suffix, @Prefix, @Country)";
            
            OleDbConnection conn = new OleDbConnection();

            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Data.accdb;Persist Security Info=False;";
            conn.ConnectionString = strConn;




            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;



            comm.Parameters.AddWithValue("@FName", fName);
            comm.Parameters.AddWithValue("@MName", mName);
            comm.Parameters.AddWithValue("@LName", lName);
            comm.Parameters.AddWithValue("@Money", money);
            comm.Parameters.AddWithValue("@Addr1", addr1);
            comm.Parameters.AddWithValue("@Addr2", addr2);
            comm.Parameters.AddWithValue("@City", city);
            comm.Parameters.AddWithValue("@State", state);
            comm.Parameters.AddWithValue("@Zip", zip);
            comm.Parameters.AddWithValue("@Email", email);
            comm.Parameters.AddWithValue("@Area_Code", area_code);
            comm.Parameters.AddWithValue("@Phone", phone);
            comm.Parameters.AddWithValue("@Suffix", suffix);
            comm.Parameters.AddWithValue("@Prefix", prefix);
            comm.Parameters.AddWithValue("@Country", country);
            


            try
            {
                conn.Open();
                strFeedback = comm.ExecuteNonQuery().ToString() + "Record(s) Added";
                conn.Close();
            }


            catch (Exception err)
            {
                strFeedback = "Error: " + err.Message;
            }
            return strFeedback;

        }





    };


}

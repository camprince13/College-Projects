//Cameron Prince
//Original 11/13/2014
//Modified 11/13/2014
//Game Library Class (Game.cs)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb; //access database
using System.Data; //database


namespace _005_MidTerm
{
    //Game Class
    public class game
    {
        //Initialize
        private string title = "";
        private double price = 0;
        private DateTime dteRel; // = DateTime.Today;
        private string esrb = "";
        private int meta = 0;

        private string feedback = "";



        //Clones
        public double Price
        {
            get
            { return price; }
            set
            { price = value; }
        }

        public string Title
        {
            get
            { return title; }
            set
            { title = value; }
        }

        public DateTime DteRel
        {
            get
            { return dteRel; }
            set
            { dteRel = value; }
        }

        public string ESRB
        {
            get
            { return esrb; }
            set
            { esrb = value; }
        }

        public int Meta
        {
            get
            { return meta; }
            set
            { meta = value; }
        }

        public string Feedback
        {
            get
            { return feedback; }
            set
            { feedback = value; }
        }





        public string AddContact()
        {

            string strFeedback = "";

            string strSQL = "INSERT INTO Game (Title, Price, DteRel, ESRB, Meta) VALUES (@Title, @Price, @DteRel, @ESRB, @Meta)";

            OleDbConnection conn = new OleDbConnection();

            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Midterm.accdb;Persist Security Info=False;";
            conn.ConnectionString = strConn;




            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;



            comm.Parameters.AddWithValue("@Title", title);
            comm.Parameters.AddWithValue("@Price", price);
            comm.Parameters.AddWithValue("@DteRel", dteRel);
            comm.Parameters.AddWithValue("@ESRB", esrb);
            comm.Parameters.AddWithValue("@Meta", meta);


            try
            {
                conn.Open();
                strFeedback = comm.ExecuteNonQuery().ToString() + "Record(s) Added";
                conn.Close();
            }


            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
            }
            return strFeedback;
        }



    };
}

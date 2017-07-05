//Cameron Prince
//Original 11/13/2014
//Modified 12/17/2014
//Game Library Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb; //access database
using System.Data; //database
using System.Data.SqlClient; //SQL database


namespace _005_MidTerm
{
    //Game Class
    public class game
    {
        //Initialize
        private string title = "";
        private double price = 0;
        private DateTime dteRel;
        private string esrb = "";
        private int meta = 0;

        private string feedback = "";

        public int G_ID = 0;

        //Clones

        public string Feedback
        {
            get
            { return feedback; }
            set
            { feedback = value; }
        }

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
            {
                if (validation.IsFilledIn(value) == false)
                { Feedback += "\nError: Blank game title."; }
                else
                {title = value;}
            }
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
            {


                if (validation.IsFilledIn(value) == false)
                { Feedback += "\nError: Blank ESRB field."; }

                if (value != "EC")
                {
                    if (value != "E")
                    {
                        if (value != "E 10+")
                        {
                            if (value != "E - T")
                            {
                                if (value != "T")
                                {
                                    if (value != "T - M")
                                    {
                                        if (value != "M")
                                        {
                                            if (value != "AO")
                                            { Feedback += "\nError: Invalid ESRB."; }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                esrb = value;
            }
        }

        public int Meta
        {
            get
            { return meta; }
            set
            { meta = value; }
        }

        





        public string AddContact()
        {

            string strFeedback = "";

            string strSQL = "INSERT INTO Game (Title, Price, DteRel, ESRB, Meta) VALUES (@Title, @Price, @DteRel, @ESRB, @Meta)";

            SqlConnection conn = new SqlConnection();

            string strConn = @SqlDb_Game.GetConnected();
            conn.ConnectionString = strConn;




            SqlCommand comm = new SqlCommand();
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
        }//End Add Contact






        //DataSet

        public DataSet SearchGame(String Title)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();


            //Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();


            //SQL Statement
            String strSQL = "Select G_ID, Title, Price, DteRel, ESRB, Meta FROM Game WHERE 0=0";

            //If the First/Last Name is filled in include it as search criteria
            if (Title.Length > 0)
            {
                strSQL += " AND Title LIKE @Title";
                comm.Parameters.AddWithValue("@Title", "%" + Title + "%");
            }
            


            //Create DB tools and Configure
            //************************************************
            SqlConnection conn = new SqlConnection();

            string strConn = @SqlDb_Game.GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            //Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    

            //************************************************

            //Get Data
            conn.Open();
            da.Fill(ds, "Game");
            conn.Close();


            return ds;
        }//End Search Game






        public SqlDataReader FindOneGame(int intG_ID)
        {
            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //Connection String
            string strConn = @SqlDb_Game.GetConnected();

            //SQL command string to pull up one person's data
            string sqlString =
           "Select G_ID, Title, Price, DteRel, ESRB, Meta FROM Game WHERE G_ID = @G_ID;";


            conn.ConnectionString = strConn;

            //Give info
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@G_ID", intG_ID);

            //Open the DataBase
            conn.Open();

            //Return feedback
            return comm.ExecuteReader();

        }//End Find One Game






        public Int32 DeleteOneGame(int intG_ID)
        {
            Int32 intRecords = 0;

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = @SqlDb_Game.GetConnected();

            string sqlString =
           "DELETE FROM Game WHERE G_ID = @G_ID;";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@G_ID", intG_ID);

            conn.Open();

            intRecords = comm.ExecuteNonQuery();

            conn.Close();

            return intRecords;

        }//EndDeleteOnePerson







        public string UpdateGame()
        {
            //Int32 intRecords = 0;

            //SQL command
            string strSQL = "UPDATE Game SET Title = @Title, Price = @Price, DteRel = @DteRel, ESRB = @ESRB, Meta = @Meta WHERE G_ID = @G_ID;";

            //connection to DB
            SqlConnection conn = new SqlConnection();

            string strConn = @SqlDb_Game.GetConnected();

            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@Title", title);
            comm.Parameters.AddWithValue("@Price", price);
            comm.Parameters.AddWithValue("@DteRel", dteRel);
            comm.Parameters.AddWithValue("@ESRB", esrb);
            comm.Parameters.AddWithValue("@Meta", meta);
            comm.Parameters.AddWithValue("@G_ID", G_ID);

            string strFeedback = "";
            try
            {
                conn.Open();
                strFeedback = comm.ExecuteNonQuery().ToString();
                //comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception err)
            {
                strFeedback = "Error: " + err.Message;
            }
            return strFeedback;
        }//EndUpdateGame






    };
}

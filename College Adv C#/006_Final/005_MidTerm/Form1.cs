//Cameron Prince
//Original 11/4/2014
//Modified 12/17/2014
//005_MidTerm


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
using System.Globalization;//regex
using System.Text.RegularExpressions;//regex
using System.Data.SqlClient; //SQL database

namespace _005_MidTerm
{
    public partial class Form1 : Form
    {


        //Game Class


        public Form1()
        {
            InitializeComponent();
        }






        //OVERLOADED CONSTRUCTOR - Meant to pull up existing data
        public Form1(Int32 intG_ID)
        {
            InitializeComponent();

            //Gather info about this one person and store it in a datareader
            game temp = new game();
            SqlDataReader dr = temp.FindOneGame(intG_ID);

            //Use that info to fill out the form
            //Loop through the records
            while (dr.Read())
            {
                //Take the Name(s) from the datareader and copy them
                // into the appropriate text fields
                txtTitle.Text = dr["Title"].ToString();
                txtPri.Text = dr["Price"].ToString();
                txtDteRel.Text = dr["DteRel"].ToString();
                txtESRB.Text = dr["ESRB"].ToString();
                txtMeta.Text = dr["Meta"].ToString();

                //added to store the ID in a label
                lblG_ID.Text = dr["G_ID"].ToString();
            }

        }







        //Button
        private void btnSub_Click(object sender, EventArgs e)
        {   
            //creation
            game temp = new game();

            temp.Title = txtTitle.Text;

            //Price to be introduced in validation

            try { temp.DteRel = DateTime.Parse(txtDteRel.Text); }
            catch { temp.Feedback += "\nError: Invalid date."; }

            temp.ESRB = comboBox1.Text;

            try { temp.Meta = Convert.ToInt32(txtMeta.Text); }
            catch { temp.Feedback += "\nError: Invalid Metascore."; }

            temp.Feedback = "";

            //Validation Testing-------------------------------
            if (validation.IsNumber(txtPri.Text) == true)
            { temp.Price = Convert.ToDouble(txtPri.Text); }
            else
            { temp.Feedback += "\nError: Invalid price."; }

            /*if (validation.IsFilledIn(temp.Title) == false)
            { temp.Feedback += "\nError: Blank game title."; }*/

            /*if (validation.IsFilledIn(temp.ESRB) == false)
            { temp.Feedback += "\nError: Blank ESRB field."; }

            if (temp.ESRB != "EC")
            {
                if (temp.ESRB != "E")
                {
                    if (temp.ESRB != "E 10+")
                    {
                        if (temp.ESRB != "E - T")
                        {
                            if (temp.ESRB != "T")
                            {
                                if (temp.ESRB != "T - M")
                                {
                                    if (temp.ESRB != "M")
                                    {
                                        if (temp.ESRB != "AO")
                                        { temp.Feedback += "\nError: Invalid ESRB."; }
                                    }
                                }
                            }
                        }
                    }
                }
            }*/

            if (validation.IsNumber(txtMeta.Text) == false)
            { temp.Feedback += "\nError: Invalid Metascore."; }

            if (validation.IsWithinRange(temp.Meta) == false)
            { temp.Feedback += "\nError: Metascore cannot be less than 0 or greater than 100."; }

            if (validation.IsFilledIn(txtDteRel.Text) == false)
            { temp.Feedback += "\nError: Blank Release Date."; }

            if (validation.IsFilledIn(txtPri.Text) == false)
            { temp.Feedback += "\nError: Blank Price."; }

            if (temp.Price < 0 || temp.Price > 500)
            { temp.Feedback += "\nError: Invalid Price."; }
            //-------------------------------------------------



            string tempDate = temp.DteRel.ToShortDateString();
            if (tempDate == "1/1/0001")
            { temp.Feedback += "\nError: Invalid Release Date."; }


            if (temp.Feedback.Contains("Error"))
            { MessageBox.Show(temp.Feedback); }

            else
            {
                //Screen Feedback
                temp.Feedback += temp.AddContact();

                temp.Feedback += "\n\nTitle:\t\t" + temp.Title;
                temp.Feedback += "\nPrice:\t\t$" + temp.Price;
                temp.Feedback += "\nRelease Date:\t" + tempDate;
                temp.Feedback += "\nESRB Rating:\t" + temp.ESRB;
                temp.Feedback += "\nMetascore:\t" + temp.Meta;

                MessageBox.Show(temp.Feedback);

                
            }
        }//End button

        private void label1_Click(object sender, EventArgs e)//shortcut
        {
            txtTitle.Text = "Skyrim";
            txtPri.Text = "60.00";
            txtMeta.Text = "100";
            txtESRB.Text = "M";
            txtDteRel.Text = "11/11/11";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            game temp = new game();
            Int32 intG_ID = Convert.ToInt32(lblG_ID.Text);
            Int32 intRecords = temp.DeleteOneGame(intG_ID);
            MessageBox.Show(intRecords.ToString() + " Records Deleted.");
        }//End Delete Button

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayInfo(game temp)
        {
            string feed = "";
            feed += "\n\nTitle:\t\t" + temp.Title;
            feed += "\nPrice:\t\t$" + temp.Price;
            feed += "\nRelease Date:\t" + temp.DteRel;
            feed += "\nESRB Rating:\t" + temp.ESRB;
            feed += "\nMetascore:\t" + temp.Meta;
            MessageBox.Show(feed);
        }
        private void DisplayInfo()
        {
            MessageBox.Show("Unknown Person....Lack of Data");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            game temp = new game();

            temp.Title = txtTitle.Text;
            temp.DteRel = DateTime.Parse(txtDteRel.Text);
            temp.Price = Convert.ToDouble(txtPri.Text);
            temp.ESRB = comboBox1.Text;
            temp.Meta = Convert.ToInt32(txtMeta.Text);

            temp.G_ID = Convert.ToInt32(lblG_ID.Text);



            if (validation.IsNumber(txtPri.Text) == true)
            { temp.Price = Convert.ToDouble(txtPri.Text); }
            else
            { temp.Feedback += "\nError: Invalid price."; }

            if (validation.IsNumber(txtMeta.Text) == false)
            { temp.Feedback += "\nError: Invalid Metascore."; }

            if (validation.IsWithinRange(temp.Meta) == false)
            { temp.Feedback += "\nError: Metascore cannot be less than 0 or greater than 100."; }

            if (validation.IsFilledIn(txtDteRel.Text) == false)
            { temp.Feedback += "\nError: Blank Release Date."; }

            if (validation.IsFilledIn(txtPri.Text) == false)
            { temp.Feedback += "\nError: Blank Price."; }

            if (temp.Price < 0 || temp.Price > 500)
            { temp.Feedback += "\nError: Invalid Price."; }


            if (temp.Feedback.Contains("Error"))
            { MessageBox.Show(temp.Feedback); }
            else if (temp.Title.Length > 0)
            {
                //DisplayInfo(temp);
                //Perform the update
                string intRecords = temp.UpdateGame();
                //Display feedback
                MessageBox.Show(intRecords.ToString() + " Record(s) Updated.\n");
            }
            else
            {
                DisplayInfo();
            }


        }//End Update




    }//End form
}//End namespace
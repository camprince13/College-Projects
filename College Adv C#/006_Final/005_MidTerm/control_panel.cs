using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //SQL database

namespace _005_MidTerm
{
    public partial class control_panel : Form
    {
        public control_panel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }//end add

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search temp = new Search();
            temp.ShowDialog();
        }//end search

        private void btnLogIN_Click(object sender, EventArgs e)
        {
            
            lblFeedback.Text = "";


            string intLevel = GamerLogin(txtLogName.Text, txtLogPass.Text);
            if (intLevel == "True")
            {
                lblFeedback.Text = "Valid login";
                txtLogName.Text = "";
                txtLogPass.Text = "";

                panel2.Enabled = false;
                panel2.Visible = false;
                panel1.Enabled = true;
                panel1.Visible = true;
            }

            else
            {
                lblFeedback.Text = "Invalid login";
            }

        }//End Log in


        private String GamerLogin(string Name, string Pass)
        {

            string Active = "";
            SqlDataReader dr;
            SqlCommand comm = new SqlCommand();
            String strSQL = "SELECT Active FROM Logins WHERE (Name = @Name AND Pass = @Pass)";

            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Pass", Pass);


            //Create DB tools and Configure
            //***************************************
            SqlConnection conn = new SqlConnection();

            string strConn = @SqlDb_Game.GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            conn.Open();
            dr = comm.ExecuteReader();

            while (dr.Read())
            {

                Active = dr["Active"].ToString();
            }

            conn.Close();
            return Active;

        }//End Log in

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
            panel2.Enabled = true;
            panel2.Visible = true;
        }//end log out





    }
}

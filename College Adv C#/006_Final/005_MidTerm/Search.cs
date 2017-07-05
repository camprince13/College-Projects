using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _005_MidTerm
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get data
            game temp = new game();
            //preform search
            DataSet ds = temp.SearchGame(txtTitle.Text);

            //display data
            gvResults.DataSource = ds;
            gvResults.DataMember = ds.Tables["Game"].ToString();//.DataSource
        }//End Search




        private void gvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strTitle = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            int intTitle = Convert.ToInt32(strTitle);

            Form1 Editor = new Form1(intTitle);//intTitle
            Editor.ShowDialog();
        }




    }
}

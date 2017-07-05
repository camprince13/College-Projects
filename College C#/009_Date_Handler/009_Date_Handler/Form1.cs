//Cameron Prince
//Original 8/12/2014
//Modified 8/18/2014
//009_Date_Handler

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _009_Date_Handler
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

        private void btnCalDue_Click(object sender, EventArgs e)
        {
            DateTime future = Convert.ToDateTime(txtFuture.Text);
            DateTime now = DateTime.Today;
            //string temp;
            //Int32 temp2;
            TimeSpan temp2 = future.Subtract(now);
            int cheese = temp2.Days;

            //temp = Convert.ToString(future - now);
            //temp2 = Convert.ToInt32(temp);

            MessageBox.Show("Current date:\t" + now.ToShortDateString() + "\n\n" + "Future date:\t" +
                future.ToShortDateString() + "\n\n" + "It will be due in\t" + cheese + " days");
        }

        private void btnCalAge_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            DateTime birth = Convert.ToDateTime(txtBirth.Text);
            //string temp;
            Int64 temp;
            TimeSpan temp2 = now.Subtract(birth);
            int temp3 = temp2.Days;

            //temp = Convert.ToString(now - birth);
            //temp2 = Convert.ToInt64(temp);
            temp = temp3 / 364;

            MessageBox.Show("Current date:\t" + now.ToShortDateString() + "\n\n" + "Birth date:\t\t" +
                birth.ToShortDateString() + "\n\n" + "You are " + temp + " Years old.");
            //MessageBox.Show("You are " + temp2 + " years old");
        }
    }
}

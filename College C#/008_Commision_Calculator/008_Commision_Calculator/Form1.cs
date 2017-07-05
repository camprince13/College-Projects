//Cameron Prince
//Original 8/11/2014
//Modified 8/12/2014
//008_Commission_Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _008_Commision_Calculator
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

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal SlsAmnt = Convert.ToDecimal(txtSlsAmnt.Text);
                int YOS = Convert.ToInt32(txtYOS.Text);
                txtBaseRTE.Text = "0.02";
                decimal BaseRTE = Convert.ToDecimal(txtBaseRTE.Text);
                txtLogRTE.Text = "0";
                decimal LogRTE = Convert.ToDecimal(txtLogRTE.Text);
                txtLogAMT.Text = "0";
                decimal LogAMT = Convert.ToDecimal(txtLogAMT.Text);
                string Title = txtTitle.Text.ToUpper();
                txtTitIncRTE.Text = "0";
                decimal TitIncRTE = Convert.ToDecimal(txtTitIncRTE.Text);
                txtTotCommRTE.Text = "0";
                decimal TotCommRTE = Convert.ToDecimal(txtTotCommRTE.Text);
                txtTotCommAMT.Text = "0";
                decimal TotCommAMT = Convert.ToDecimal(txtTotCommAMT.Text);
                txtBaseAMT.Text = "0";
                decimal BaseAMT = Convert.ToDecimal(txtBaseAMT.Text);
                txtTitIncAMT.Text = "0";
                decimal TitIncAMT = Convert.ToDecimal(txtTitIncAMT.Text);


                if (YOS < 5)//years calc
                { LogRTE = 0.01m; }
                else if (YOS > 5 && YOS < 9)
                { LogRTE = 0.02m; }
                else if (YOS >= 10)
                { LogRTE = 0.03m; }
                else
                { LogRTE = 0.01m; }

                if (Title == "APPRENTICE")//title calc
                { TitIncRTE = 0.00m; }
                else if (Title == "1")
                { TitIncRTE = 0.00m; }
                else if (Title == "ASSOCIATE")
                { TitIncRTE = 0.01m; }
                else if (Title == "2")
                { TitIncRTE = 0.01m; }
                else if (Title == "SENIOR")
                { TitIncRTE = 0.02m; }
                else if (Title == "3")
                { TitIncRTE = 0.02m; }
                else
                { TitIncRTE = 0.00m;
                MessageBox.Show("Please Enter a valid Title. Usable titles are 'APPRENTICE', '1', 'ASSOCIATE', '2', 'SENIOR', and '3'.", "Invalid Title!");}

                TotCommRTE = LogRTE + TitIncRTE + 0.02m;//total rate calc

                BaseAMT = SlsAmnt * BaseRTE;//amounts calc
                LogAMT = SlsAmnt * LogRTE;
                TitIncAMT = SlsAmnt * TitIncRTE;
                TotCommAMT = SlsAmnt * TotCommRTE;

                txtBaseRTE.Text = BaseRTE.ToString("p2");//end
                txtLogRTE.Text = LogRTE.ToString("p2");
                txtTitIncRTE.Text = TitIncRTE.ToString("p2");
                txtTotCommRTE.Text = TotCommRTE.ToString("p2");
                txtBaseAMT.Text = BaseAMT.ToString("c");
                txtLogAMT.Text = LogAMT.ToString("c");
                txtTitIncAMT.Text = TitIncAMT.ToString("c");
                txtTotCommAMT.Text = TotCommAMT.ToString("c");
            }
            catch
            { MessageBox.Show("Please enter valid numbers for the Sales and Years fields.", "Entry Error!"); }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            string cheese = "";
            txtSlsPrsn.Text = cheese;
            txtSlsAmnt.Text = cheese;
            txtYOS.Text = cheese;
            txtTitle.Text = cheese;
            txtBaseRTE.Text = cheese;
            txtLogRTE.Text = cheese;
            txtTitIncRTE.Text = cheese;
            txtTotCommRTE.Text = cheese;
            txtBaseAMT.Text = cheese;
            txtLogAMT.Text = cheese;
            txtTitIncAMT.Text = cheese;
            txtTotCommAMT.Text = cheese;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string nm1 = "Carl";
            string nm2 = "George";
            string nm3 = "Lester";
            string nm4 = "Moe";

            if (txtSlsPrsn.Text == "")
            { txtSlsPrsn.Text = nm1; }
            else if (txtSlsPrsn.Text == "Carl")
            { txtSlsPrsn.Text = nm2; }
            else if (txtSlsPrsn.Text == "George")
            { txtSlsPrsn.Text = nm3; }
            else if (txtSlsPrsn.Text == "Lester")
            { txtSlsPrsn.Text = nm4; }
            else if (txtSlsPrsn.Text == "Moe")
            { txtSlsPrsn.Text = nm1; }
        }
    }
}

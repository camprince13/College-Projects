//Cameron Prince
//000_Test
//original 7/21/2014
//modified 7/22/2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _000_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text); //string to decimal
            decimal discountPercent = 0m;

            if (invoiceSubtotal >= 500)
                { discountPercent = .2m; }
            else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
                {discountPercent = .15m;}
            else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
                {discountPercent = .1m;}

            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1"); //decimal to string as percent w/ 1 dec place
            txtDiscountAmount.Text = discountAmount.ToString("c");   //decimal to string as currency
            txtTotal.Text = invoiceTotal.ToString("c");  //decimal to string as currency

            txtSubtotal.Focus();

            //if (invoiceTotal >= 9000)
                //label04
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
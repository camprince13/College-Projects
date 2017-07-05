//Cameron Prince
//001_Enhanced
//original 7/22/2014
//modified 7/22/2014


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _001_Enhanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int ProgNumInv = 0;
        decimal ProgTotInv = 0m, ProgAvg = 0m;
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal invoiceSubtotal = Convert.ToDecimal(txtEntSub.Text); //string to decimal
            decimal discountPercent = 0m;

            if (invoiceSubtotal >= 500)
            { discountPercent = .2m; }
            else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
            { discountPercent = .15m; }
            else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
            { discountPercent = .1m; }

            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;

            ProgNumInv++;
            txtNumInv.Text = ProgNumInv.ToString();

            ProgTotInv += invoiceTotal;
            txtTotInv.Text = ProgTotInv.ToString("c");

            ProgAvg = ProgTotInv / ProgNumInv;
            txtInvAvg.Text = ProgAvg.ToString("c");

            txtDisPer.Text = discountPercent.ToString("p1"); //decimal to string as percent w/ 1 dec place
            txtDisAmo.Text = discountAmount.ToString("c");   //decimal to string as currency
            txtTotal.Text = invoiceTotal.ToString("c");  //decimal to string as currency
            txtSub.Text = invoiceSubtotal.ToString("C");

            txtEntSub.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTotals_Click(object sender, EventArgs e)
        {
            ProgNumInv = 0;
            ProgTotInv = 0;
            ProgAvg = 0;
            txtNumInv.Text = ProgNumInv.ToString();
            txtTotInv.Text = ProgTotInv.ToString("c");
            txtInvAvg.Text = ProgAvg.ToString("c");
        }
    }
}

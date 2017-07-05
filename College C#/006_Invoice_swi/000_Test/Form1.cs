//Cameron Prince
//006_invoice_swi
//original 7/21/2014 (000_Test), 003_Enhanced_invoice
//modified 8/4/2014

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
            try
            {
                decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text); //string to decimal
                decimal discountPercent = 0m;
                string Custy = txtCust.Text.ToUpper();
            }

            catch { MessageBox.Show("Please enter a valid number for the Subtotal field.", "Entry Error!"); }

           // if (invoiceSubtotal >= 500)
           //     { discountPercent = .2m; }
           // else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
             //   {discountPercent = .15m;}
            //else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
              //  {discountPercent = .1m;}

          /*  if (Custy == "R")
            {
                if (invoiceSubtotal < 100)
                    discountPercent = .0m;
                else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
                    discountPercent = .1m;
                else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
                    discountPercent = .25m;
                else if (invoiceSubtotal >= 500)
                    discountPercent = .30m;
            }
            else if (Custy == "C")
            {
                //if (invoiceSubtotal < 250)
                  //  discountPercent = .2m;
                //else
                    discountPercent = .2m;
            }
            else if (Custy == "T")
            { 
            if (invoiceSubtotal < 500)
                discountPercent = .40m;
            if (invoiceSubtotal >= 500)
                discountPercent = .50m;
            }
            else
            { discountPercent = .1m; } */

            switch (Custy) {
            case "R":
                    if (invoiceSubtotal < 100)
                        discountPercent = .0m;
                    else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
                        discountPercent = .1m;
                    else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
                        discountPercent = .25m;
                    else if (invoiceSubtotal >= 500)
                        discountPercent = .30m;
                    break;
            case "C":
                    discountPercent = .2m;
                    break;
            case "T":
                if (invoiceSubtotal < 500)
                     discountPercent = .40m;
                if (invoiceSubtotal >= 500)
                    discountPercent = .50m;
                break;

            default:
                    discountPercent = .1m; 
            break;
            }

            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1"); //decimal to string as percent w/ 1 dec place
            txtDiscountAmount.Text = discountAmount.ToString("c");   //decimal to string as currency
            txtTotal.Text = invoiceTotal.ToString("c");  //decimal to string as currency
            txtCust.Text = Custy;
            txtCust.Focus();
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
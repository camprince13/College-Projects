//Cameron Prince
//Original 7/28/2014 002_Simple_Calculater
//Modified 8/11/2014
//007

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _002_Simple_Calculater
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
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                decimal res = 0; //Convert.ToDecimal(txtRes.Text);
                //String op = Convert.ToString(txtOp);
                string op = txtOp.Text;


                if (op == "+")
                { res = num1 + num2; }
                else if (op == "-")
                { res = num1 - num2; }
                else if (op == "*")
                { res = num1 * num2; }
                else if (op == "/")
                { res = num1 / num2; }
                else
                {
                    MessageBox.Show("Please enter a valid operator.", "Entry Error!");
                    //op = "Invalid operator!";
                    txtOp.Focus();
                }

                txtNum1.Text = num1.ToString();
                txtNum2.Text = num2.ToString();
                txtRes.Text = res.ToString();
                txtOp.Text = op.ToString();
            }
            catch { MessageBox.Show("Please enter a valid number.", "Entry Error!"); }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            //decimal num1 = Convert.ToDecimal(txtNum1.Text);
            //decimal num2 = Convert.ToDecimal(txtNum2.Text);
            //decimal res = Convert.ToDecimal(txtRes.Text);

            string num1 = "";
            //num2 = 0;
            //res = 0;

            txtNum1.Text = num1;
            txtNum2.Text = num1;
            txtRes.Text = num1;
            txtOp.Text = num1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string op = txtOp.Text;
            op = "+";
            txtOp.Text = op.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            string op = txtOp.Text;
            op = "-";
            txtOp.Text = op.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string op = txtOp.Text;
            op = "*";
            txtOp.Text = op.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string op = txtOp.Text;
            op = "/";
            txtOp.Text = op.ToString();
        }
    }
}

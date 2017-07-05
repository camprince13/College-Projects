//Cameron Prince
//Original 8/3/2014
//Modified 8/3/2014
//005_Factorial

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _005_Factorial
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

        Int64 temp = 1;
        int i = 1;

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(txtNum.Text);
            //Int64 res = Convert.ToInt64(txtRes.Text);
            Int64 res = 0;

            if (num >= 21)
            {
                string error = "OVERLOAD!!!";
                txtRes.Text = error;
                txtNum.Focus();
            }
            else
            {
                for (i = 1; i <= num; i++)
                { temp = temp * i; }

                res = temp;
                i = 1;
                temp = 1;

                txtRes.Text = res.ToString();
                txtNum.Focus();
            }
        }
    }
}

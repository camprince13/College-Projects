//Cameron Prince
//Original 8/26/2014
//Modified 9/2/2014
//014_Lunch_Order

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _014_Lunch_Order
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

        private void radioHam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHam.Checked == true)
            {checkBox1.Text = "Lettuce, tomato, and onions";
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox3.Text = "French fries";
            groupBox2.Text = "Add-on Items (75¢ Each)";}
        }

        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPizza.Checked == true)
            {checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";
            groupBox2.Text = "Add-on Items (50¢ Each)";}
        }

        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSalad.Checked == true)
            {
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon Bits";
                checkBox3.Text = "Bread Sticks";
                groupBox2.Text = "Add-on Items (25¢ Each)";}
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            decimal sub = 0;
            decimal tax = 0;
            decimal tot = 0;

            if (radioHam.Checked == true)
                { sub = 6.95m;
                    if (checkBox1.Checked == true)
                    { sub += 0.75m; }
                    if (checkBox2.Checked == true)
                    { sub += 0.75m; }
                    if (checkBox3.Checked == true)
                    { sub += 0.75m; }
                }

            else if (radioPizza.Checked == true)
            {
                sub = 5.95m;
                if (checkBox1.Checked == true)
                { sub += 0.50m; }
                if (checkBox2.Checked == true)
                { sub += 0.50m; }
                if (checkBox3.Checked == true)
                { sub += 0.50m; }
            }

            else if (radioSalad.Checked == true)
            {
                sub = 4.95m;
                if (checkBox1.Checked == true)
                { sub += 0.25m; }
                if (checkBox2.Checked == true)
                { sub += 0.25m; }
                if (checkBox3.Checked == true)
                { sub += 0.25m; }
            }


            tax = sub * 0.0775m;
            tot = sub + tax;



            txtSub.Text = sub.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTot.Text = tot.ToString("c");
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtSub.Text = "";
            txtTax.Text = "";
            txtTot.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}

//Cameron Prince
//Original 8/25/2014
//Modified 8/25/2014
//011_Buttons_Boxes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _011_Buttons_Boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { checkBox1.Text = "Bob";
            checkBox2.Text = "Pat";}

            if (radioButton2.Checked == true)
            {checkBox1.Text = "Pat";
                checkBox2.Text = "Bob";}}}}

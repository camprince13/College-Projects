//Cameron Prince
//Original 8/25/2014
//Modified 8/25/2014
//011_MadLib

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _011_MadLib
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtADG.Text == "")
            {MessageBox.Show("At least try to input something.", "Input Error");}
            if (txtPB.Text == "")
            { MessageBox.Show("At least try to input something.", "Input Error"); }
            if (txtPN1.Text == "")
            { MessageBox.Show("At least try to input something.", "Input Error"); }
            if (txtPN2.Text == "")
            { MessageBox.Show("At least try to input something.", "Input Error"); }
            if (txtPol.Text == "")
            { MessageBox.Show("At least try to input something.", "Input Error"); }
            if (txtVB.Text == "")
            { MessageBox.Show("At least try to input something.", "Input Error"); }

            MessageBox.Show("Friends, Romans, " + txtPN1.Text + " lend me your " + txtPB.Text + " I come to " + txtVB.Text + " Caesar,\nnot to praise him. The evil that men do lives after them. The good is\noften interred with their " + txtPN2.Text + ". So let it be with " + txtPol.Text + " The noble Brutus; Hath told you Caesar was " + txtADG.Text + "; If it were so, it was a grievous fault, And grievously hath Caesar answer'd it.\n", "Madlib");
        }
    }
}

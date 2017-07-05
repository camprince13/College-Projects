//Cameron Prince
//Original 7/29/2014
//Modified 8/5/2014 still working
//004_Future_value

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _004_Futture_Value
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
                decimal mon = Convert.ToDecimal(txtMonInv.Text);
                decimal yrrte = Convert.ToDecimal(txtYrsRte.Text);
                int yrs = Convert.ToInt32(txtNumYrs.Text);
                decimal fut = 0m;
                int months = yrs * 12;

                decimal MonthlyRate = yrrte / 12 / 100;

                if (yrs <= 5)
                {

                    for (int i = 0; i < months; i++)
                    { fut = (fut + mon) * (1 + MonthlyRate); }
                    txtFutVal.Text = fut.ToString("c");
                    txtMonInv.Focus();
                }
                else { }
            }
            catch (FormatException) { MessageBox.Show("Invalid Numeric Format"); }
            catch (OverflowException) { MessageBox.Show("Overflow Error"); }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }

            
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            int f = 0;

            txtFutVal.Text = f.ToString("c");
            txtMonInv.Text = f.ToString();
            txtNumYrs.Text = f.ToString();
            txtYrsRte.Text = f.ToString();
        }
    }
}

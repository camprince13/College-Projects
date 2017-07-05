//Cameron Prince
//Original 9/8/2014
//Modified 9/9/2014
//018_Customer_Billing

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _018_Customer_Billing
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

       /* private void Payment_Load(object sender, EventArgs e)
        { lstCreditCardType.Items.Add("Visa");
        lstCreditCardType.Items.Add("MasterCard");
        lstCreditCardType.Items.Add("American Express");
        lstCreditCardType.SelectedIndex = 0;

        string[] months = { "Select a month...", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                foreach (string month in months)
                    cboExpMo.Items.Add(month);
            cboExpMo.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboExpYr.Items.Add("Select a year...");
            while (year < endYear)
            {cboExpYr.Items.Add(year);
            year++;}
            cboExpYr.SelectedIndex = 0;
        }*/

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            { this.SaveData(); }
        }

        private bool IsValidData()
        {
            if (rdoCredit.Checked)
            {
                if (lstCreditCardType.SelectedIndex == -1)
                { MessageBox.Show("You must select a credit card type.", "Entry Error");
                lstCreditCardType.Focus();
                return false;
                }
                if (txtCardNum.Text == "")
                { MessageBox.Show("You must enter a credit card number.", "Entry Error");
                txtCardNum.Focus();
                return false;
                }
                if (cboExpMo.SelectedIndex == 0)
                { MessageBox.Show("You must select a month.", "Entry Error");
                cboExpMo.Focus();
                return false;
                }
                if (cboExpYr.SelectedIndex == 0)
                { MessageBox.Show("You must select a year.", "Entry Error");
                cboExpYr.Focus();
                return false;
                }
            }
            return true;
        }

        private void SaveData()
        { string msg = null;
        if (rdoCredit.Checked == true)
        {
            msg += "Charge to credit card." + "\n";
            msg += "\n";
            msg += "Card type: " + lstCreditCardType.Text + "\n";
            msg += "Card number: " + txtCardNum.Text + "\n";
            msg += "Expiration date: " + cboExpMo.Text + "/" + cboExpYr.Text + "\n";
        }
        else
        { msg += "Send bill to customer." + "\n";
        msg += "\n";
        }
        bool isDefaultBilling = chkDefault.Checked;
        msg += "Default billing: " + isDefaultBilling;
        this.Tag = msg;//dialog tag
        this.DialogResult = DialogResult.OK;
        }

        private void Billing_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdoCredit.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void EnableControls()
        { lstCreditCardType.Enabled = true;
        txtCardNum.Enabled = true;
        cboExpMo.Enabled = true;
        cboExpYr.Enabled = true;
        }

        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNum.Enabled = false;
            cboExpMo.Enabled = false;
            cboExpYr.Enabled = false;
        }

        private void payment_Load_1(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("MasterCard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months = { "Select a month...", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
                cboExpMo.Items.Add(month);
            cboExpMo.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboExpYr.Items.Add("Select a year...");
            while (year < endYear)
            {
                cboExpYr.Items.Add(year);
                year++;
            }
            cboExpYr.SelectedIndex = 0;
        }

        private void rdoBill_CheckedChanged(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void rdoCredit_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls();
        }


    }
}

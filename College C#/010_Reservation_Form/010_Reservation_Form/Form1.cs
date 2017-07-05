//Cameron Prince
//Original 8/18/2014
//Modified 8/25/2014
//010_Reservation_Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _010_Reservation_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}

        private void btnExit_Click(object sender, EventArgs e)
        {this.Close();}

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Arrival = DateTime.Today;//Parse(txtArrive.Text);
                DateTime Departure = DateTime.Today;//Parse(txtDeparture.Text);
                Decimal Price = 115.00m;
                DateTime Now = DateTime.Today;
                int error = 0;

                if (txtArrive.Text == "")
                { Arrival = DateTime.Today; }
                else
                { Arrival = DateTime.Parse(txtArrive.Text); }

                if (Arrival < Now)
                {
                    MessageBox.Show("You cannot make a reservation for the past.");
                    error = 1;
                }

                if (txtDeparture.Text == "")
                { Departure = Arrival.AddDays(3); }
                else
                { Departure = DateTime.Parse(txtDeparture.Text); }

                if (Departure < Arrival)
                {
                    MessageBox.Show("You cannot depart before you arrive.");
                    error = 1;
                }

                TimeSpan ts = Departure.Subtract(Arrival);
                int nights = ts.Days;

                decimal tot = Price * nights;

                if (error == 0)
                {
                    txtDeparture.Text = Departure.ToShortDateString();
                    txtArrive.Text = Arrival.ToShortDateString();
                    txtNights.Text = nights.ToString();
                    txtPrice.Text = Price.ToString("c");
                    txtTotPrice.Text = tot.ToString("c");
                }
                else
                {
                    txtPrice.Text = "";
                    txtNights.Text = "";
                    txtTotPrice.Text = "";
                }
            }
            catch
            { MessageBox.Show("Invalid date input.", "Input Error"); }
        }
    }
}

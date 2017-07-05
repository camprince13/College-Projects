//Cameron Prince
//Original 9/15/2014
//Modified 9/22/2014
//019_Student_Scores

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _019_Student_Scores
{
    public partial class frm_Student_Scores : Form
    {
        public static string pass = null;
        public frm_Student_Scores()
        {
            InitializeComponent();
            listBox1.Items.Add("Carl|99|98|97");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        string grabber = "";
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form Add_Student_Form = new frm_Add_Student();
            DialogResult selectedButton = Add_Student_Form.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
            listBox1.Items.Add(Add_Student_Form.Tag);//Tag grabbing
            }
        }


        /*private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)//string handling
        {
            if (listBox1.SelectedIndexChanged)
            {
            grabber = Convert.ToString(listBox1.SelectedItem);
            grabber = grabber.Trim();
            String[] pieces = grabber.Split(' ');
            string name = pieces[0];
            string numbers = pieces[1];
            txtAvg.Text = numbers;}

        }*/


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)//string manipulation
        {

            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            grabber = Convert.ToString(listBox1.SelectedItem);
            grabber = grabber.Trim();
            var current = listBox1.SelectedItem.ToString();
            var pieces = current.Split('|');
            int i;
            if (pieces.Length == 1 || pieces[1] == "")
            {
                txtAvg.Text = "0";
                txtScoreCount.Text = "0";
                txtScoreTotal.Text = "0";
                return;
            }

            int count = pieces.Length - 1;
            decimal total = 0;
            decimal avg = 0;


            for (i = 1; i < pieces.Length; i++)
            {
                if (pieces[i] == "")
                    continue;

                total += decimal.Parse(pieces[i]);
            }
                avg = total / count;
                txtScoreCount.Text = Convert.ToString(count);
                txtScoreTotal.Text = Convert.ToString(total);
                txtAvg.Text = Convert.ToString(avg);
            
        }
        


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form frm_Update_Student_Scores = new frm_Update_Student_Scores();
            this.SendData();
            DialogResult btnUpdate = frm_Update_Student_Scores.ShowDialog();
            
                
                if (btnUpdate == DialogResult.OK)
                {
                    if (frm_Update_Student_Scores.Tag != null)
                    {
                        var cheese = frm_Update_Student_Scores.Tag;//pass;//(frm_Update_Student_Scores.win);//grabbing
                        listBox1.Items.Add(cheese);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        //listBox1.SelectedItem = cheese;
                    }
                    else
                        MessageBox.Show("Null Error");
                }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedIndex);
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }



        private void SendData()
        {
            pass = null;
            pass += listBox1.SelectedItem;
            this.Tag = pass;//dialog tag
            this.DialogResult = DialogResult.OK;
        }



        
    }
}

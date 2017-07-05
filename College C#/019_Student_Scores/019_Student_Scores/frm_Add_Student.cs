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
    public partial class frm_Add_Student : Form
    {
        public frm_Add_Student()
        {
            InitializeComponent();
        }


        int error = 0;
        //decimal score = Convert.ToDecimal(txtScore_AddStudent.Text);

        private void btnOK_frm_add_student_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            { this.SaveData(); }
        }


        private bool IsValidData()
        {
            if (txtName_Add_Student.Text == "")
            { MessageBox.Show("You must enter a name.", "Entry Error");
            error++;}

           /* if (txtScore_AddStudent.Text == "")
            {
                MessageBox.Show("You must enter a number.", "Entry Error");
                error++;
            }*/

            if (error != 0)
            { return false; }
            else
            { return true; }
                error = 0;
        }

        private void btnAddScore_frm_add_student_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (txtScores_AddStudent.Text == "")
                {
                    txtScores_AddStudent.Text += txtScore_AddStudent.Text;
                    txtScore_AddStudent.Text = "";
                }
                else
                {
                    txtScores_AddStudent.Text += "|";
                    txtScores_AddStudent.Text += txtScore_AddStudent.Text;
                    txtScore_AddStudent.Text = "";
                }
            }
        }






        private void SaveData()
        {
            string msg = null;
            msg += txtName_Add_Student.Text + "|" + txtScores_AddStudent.Text;
            this.Tag = msg;//dialog tag
            this.DialogResult = DialogResult.OK;//STRING DEATH
        }













        private void btnClsScores_frm_add_student_Click(object sender, EventArgs e)
        {
            txtScores_AddStudent.Text = "";
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}

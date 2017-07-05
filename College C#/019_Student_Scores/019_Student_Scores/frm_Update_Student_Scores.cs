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
    public partial class frm_Update_Student_Scores : Form
    {
        public static string win = null;
        public frm_Update_Student_Scores()
        {
            InitializeComponent();
        }

        string info = "";
        string name = "";

        public void frm_Update_Student_Scores_Load(object sender, EventArgs e)
        {

            info = (frm_Student_Scores.pass);

            var pieces = info.Split('|');
            int i;

            name = pieces[0];
            txtName.Text = name;

            for (i = 1; i < pieces.Length; i++)
            {
                if (pieces[i] == "")
                    continue;

                listBox1.Items.Add(pieces[i]);
            }
            update();
        }





        private void btnRemove_frm_Update_Student_Score_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }




        private void update()
        {
            /*frm_Student_Scores.pass = null;
            name = txtName.Text;
            frm_Student_Scores.pass += name;

            for (int i = listBox1.Items.Count; i > 0; i--)
            {
                frm_Student_Scores.pass += '|';
                frm_Student_Scores.pass += listBox1.Items[i];
            }*/

            win = null;
            frm_Student_Scores.pass = null;
            name = txtName.Text;
            win += name;
            frm_Student_Scores.pass += name;

            //for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i++)
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i] != "")
                {
                    frm_Student_Scores.pass += '|';
                    win += '|';
                    win += listBox1.Items[i];
                    frm_Student_Scores.pass += listBox1.Items[i];
                    this.Tag = win;
                }

            }


        }


        private void btnUpdate_frm_Update_Student_Score_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnClsScores_frm_Update_Student_Score_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnAdd_frm_Update_Student_Scores_Click(object sender, EventArgs e)
        {
            string test = txtNewScore.Text;
            int num = 0;
            bool canConvert = int.TryParse(test, out num);
            if (canConvert == true)
                listBox1.Items.Add(num);
            else
                MessageBox.Show("Not a valid number!");
        }

        private void btnOK_frm_Update_Student_Score_Click(object sender, EventArgs e)
        {
            
            /*win = null;
            frm_Student_Scores.pass = null;
            name = txtName.Text;
            win += name;
            frm_Student_Scores.pass += name;

            //for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i++)
                for (int i = 1; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i] != "")
                {
                    frm_Student_Scores.pass += '|';
                    win += '|';
                    win += listBox1.Items[i];
                    frm_Student_Scores.pass += listBox1.Items[i];
                    this.Tag = win;
                }
                
            }*/
            update();
            this.DialogResult = DialogResult.OK;

        }




    }
}

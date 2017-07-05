namespace _019_Student_Scores
{
    partial class frm_Add_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Student));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName_Add_Student = new System.Windows.Forms.TextBox();
            this.txtScore_AddStudent = new System.Windows.Forms.TextBox();
            this.txtScores_AddStudent = new System.Windows.Forms.TextBox();
            this.btnAddScore_frm_add_student = new System.Windows.Forms.Button();
            this.btnClsScores_frm_add_student = new System.Windows.Forms.Button();
            this.btnOK_frm_add_student = new System.Windows.Forms.Button();
            this.btnCancel_frm_add_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scores:";
            // 
            // txtName_Add_Student
            // 
            this.txtName_Add_Student.Location = new System.Drawing.Point(71, 18);
            this.txtName_Add_Student.Name = "txtName_Add_Student";
            this.txtName_Add_Student.Size = new System.Drawing.Size(201, 20);
            this.txtName_Add_Student.TabIndex = 3;
            // 
            // txtScore_AddStudent
            // 
            this.txtScore_AddStudent.Location = new System.Drawing.Point(71, 52);
            this.txtScore_AddStudent.Name = "txtScore_AddStudent";
            this.txtScore_AddStudent.Size = new System.Drawing.Size(120, 20);
            this.txtScore_AddStudent.TabIndex = 4;
            // 
            // txtScores_AddStudent
            // 
            this.txtScores_AddStudent.Location = new System.Drawing.Point(71, 85);
            this.txtScores_AddStudent.Name = "txtScores_AddStudent";
            this.txtScores_AddStudent.ReadOnly = true;
            this.txtScores_AddStudent.Size = new System.Drawing.Size(201, 20);
            this.txtScores_AddStudent.TabIndex = 5;
            this.txtScores_AddStudent.TabStop = false;
            // 
            // btnAddScore_frm_add_student
            // 
            this.btnAddScore_frm_add_student.Location = new System.Drawing.Point(197, 52);
            this.btnAddScore_frm_add_student.Name = "btnAddScore_frm_add_student";
            this.btnAddScore_frm_add_student.Size = new System.Drawing.Size(75, 23);
            this.btnAddScore_frm_add_student.TabIndex = 6;
            this.btnAddScore_frm_add_student.Text = "Add Score";
            this.btnAddScore_frm_add_student.UseVisualStyleBackColor = true;
            this.btnAddScore_frm_add_student.Click += new System.EventHandler(this.btnAddScore_frm_add_student_Click);
            // 
            // btnClsScores_frm_add_student
            // 
            this.btnClsScores_frm_add_student.Location = new System.Drawing.Point(197, 127);
            this.btnClsScores_frm_add_student.Name = "btnClsScores_frm_add_student";
            this.btnClsScores_frm_add_student.Size = new System.Drawing.Size(75, 23);
            this.btnClsScores_frm_add_student.TabIndex = 7;
            this.btnClsScores_frm_add_student.Text = "Clear Scores";
            this.btnClsScores_frm_add_student.UseVisualStyleBackColor = true;
            this.btnClsScores_frm_add_student.Click += new System.EventHandler(this.btnClsScores_frm_add_student_Click);
            // 
            // btnOK_frm_add_student
            // 
            this.btnOK_frm_add_student.Location = new System.Drawing.Point(101, 173);
            this.btnOK_frm_add_student.Name = "btnOK_frm_add_student";
            this.btnOK_frm_add_student.Size = new System.Drawing.Size(75, 23);
            this.btnOK_frm_add_student.TabIndex = 8;
            this.btnOK_frm_add_student.Text = "OK";
            this.btnOK_frm_add_student.UseVisualStyleBackColor = true;
            this.btnOK_frm_add_student.Click += new System.EventHandler(this.btnOK_frm_add_student_Click);
            // 
            // btnCancel_frm_add_student
            // 
            this.btnCancel_frm_add_student.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel_frm_add_student.Location = new System.Drawing.Point(197, 173);
            this.btnCancel_frm_add_student.Name = "btnCancel_frm_add_student";
            this.btnCancel_frm_add_student.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_frm_add_student.TabIndex = 9;
            this.btnCancel_frm_add_student.Text = "Cancel";
            this.btnCancel_frm_add_student.UseVisualStyleBackColor = true;
            // 
            // frm_Add_Student
            // 
            this.AcceptButton = this.btnOK_frm_add_student;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel_frm_add_student;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.btnCancel_frm_add_student);
            this.Controls.Add(this.btnOK_frm_add_student);
            this.Controls.Add(this.btnClsScores_frm_add_student);
            this.Controls.Add(this.btnAddScore_frm_add_student);
            this.Controls.Add(this.txtScores_AddStudent);
            this.Controls.Add(this.txtScore_AddStudent);
            this.Controls.Add(this.txtName_Add_Student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_Student";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName_Add_Student;
        private System.Windows.Forms.TextBox txtScore_AddStudent;
        private System.Windows.Forms.TextBox txtScores_AddStudent;
        private System.Windows.Forms.Button btnAddScore_frm_add_student;
        private System.Windows.Forms.Button btnClsScores_frm_add_student;
        private System.Windows.Forms.Button btnOK_frm_add_student;
        private System.Windows.Forms.Button btnCancel_frm_add_student;
    }
}
﻿namespace _008_Commision_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSlsPrsn = new System.Windows.Forms.TextBox();
            this.txtSlsAmnt = new System.Windows.Forms.TextBox();
            this.txtYOS = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBaseRTE = new System.Windows.Forms.TextBox();
            this.txtLogAMT = new System.Windows.Forms.TextBox();
            this.txtTotCommAMT = new System.Windows.Forms.TextBox();
            this.txtTitIncAMT = new System.Windows.Forms.TextBox();
            this.txtTotCommRTE = new System.Windows.Forms.TextBox();
            this.txtTitIncRTE = new System.Windows.Forms.TextBox();
            this.txtLogRTE = new System.Windows.Forms.TextBox();
            this.txtBaseAMT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Person";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Years of Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Base Commission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Longevity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Title Incentive";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Commission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Amount";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(281, 24);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 10;
            this.btnCal.Text = "&Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(281, 72);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(75, 23);
            this.btnCls.TabIndex = 11;
            this.btnCls.Text = "Clear";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(281, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSlsPrsn
            // 
            this.txtSlsPrsn.Location = new System.Drawing.Point(104, 7);
            this.txtSlsPrsn.Name = "txtSlsPrsn";
            this.txtSlsPrsn.Size = new System.Drawing.Size(133, 20);
            this.txtSlsPrsn.TabIndex = 13;
            // 
            // txtSlsAmnt
            // 
            this.txtSlsAmnt.Location = new System.Drawing.Point(104, 36);
            this.txtSlsAmnt.Name = "txtSlsAmnt";
            this.txtSlsAmnt.Size = new System.Drawing.Size(133, 20);
            this.txtSlsAmnt.TabIndex = 14;
            // 
            // txtYOS
            // 
            this.txtYOS.Location = new System.Drawing.Point(104, 66);
            this.txtYOS.Name = "txtYOS";
            this.txtYOS.Size = new System.Drawing.Size(133, 20);
            this.txtYOS.TabIndex = 15;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(104, 96);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(133, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // txtBaseRTE
            // 
            this.txtBaseRTE.Location = new System.Drawing.Point(104, 157);
            this.txtBaseRTE.Name = "txtBaseRTE";
            this.txtBaseRTE.ReadOnly = true;
            this.txtBaseRTE.Size = new System.Drawing.Size(59, 20);
            this.txtBaseRTE.TabIndex = 17;
            this.txtBaseRTE.TabStop = false;
            // 
            // txtLogAMT
            // 
            this.txtLogAMT.Location = new System.Drawing.Point(178, 189);
            this.txtLogAMT.Name = "txtLogAMT";
            this.txtLogAMT.ReadOnly = true;
            this.txtLogAMT.Size = new System.Drawing.Size(59, 20);
            this.txtLogAMT.TabIndex = 18;
            this.txtLogAMT.TabStop = false;
            // 
            // txtTotCommAMT
            // 
            this.txtTotCommAMT.Location = new System.Drawing.Point(178, 250);
            this.txtTotCommAMT.Name = "txtTotCommAMT";
            this.txtTotCommAMT.ReadOnly = true;
            this.txtTotCommAMT.Size = new System.Drawing.Size(59, 20);
            this.txtTotCommAMT.TabIndex = 19;
            this.txtTotCommAMT.TabStop = false;
            // 
            // txtTitIncAMT
            // 
            this.txtTitIncAMT.Location = new System.Drawing.Point(178, 219);
            this.txtTitIncAMT.Name = "txtTitIncAMT";
            this.txtTitIncAMT.ReadOnly = true;
            this.txtTitIncAMT.Size = new System.Drawing.Size(59, 20);
            this.txtTitIncAMT.TabIndex = 20;
            this.txtTitIncAMT.TabStop = false;
            // 
            // txtTotCommRTE
            // 
            this.txtTotCommRTE.Location = new System.Drawing.Point(104, 250);
            this.txtTotCommRTE.Name = "txtTotCommRTE";
            this.txtTotCommRTE.ReadOnly = true;
            this.txtTotCommRTE.Size = new System.Drawing.Size(59, 20);
            this.txtTotCommRTE.TabIndex = 21;
            this.txtTotCommRTE.TabStop = false;
            // 
            // txtTitIncRTE
            // 
            this.txtTitIncRTE.Location = new System.Drawing.Point(104, 219);
            this.txtTitIncRTE.Name = "txtTitIncRTE";
            this.txtTitIncRTE.ReadOnly = true;
            this.txtTitIncRTE.Size = new System.Drawing.Size(59, 20);
            this.txtTitIncRTE.TabIndex = 22;
            this.txtTitIncRTE.TabStop = false;
            // 
            // txtLogRTE
            // 
            this.txtLogRTE.Location = new System.Drawing.Point(104, 189);
            this.txtLogRTE.Name = "txtLogRTE";
            this.txtLogRTE.ReadOnly = true;
            this.txtLogRTE.Size = new System.Drawing.Size(59, 20);
            this.txtLogRTE.TabIndex = 23;
            this.txtLogRTE.TabStop = false;
            // 
            // txtBaseAMT
            // 
            this.txtBaseAMT.Location = new System.Drawing.Point(178, 157);
            this.txtBaseAMT.Name = "txtBaseAMT";
            this.txtBaseAMT.ReadOnly = true;
            this.txtBaseAMT.Size = new System.Drawing.Size(59, 20);
            this.txtBaseAMT.TabIndex = 24;
            this.txtBaseAMT.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(368, 289);
            this.Controls.Add(this.txtBaseAMT);
            this.Controls.Add(this.txtLogRTE);
            this.Controls.Add(this.txtTitIncRTE);
            this.Controls.Add(this.txtTotCommRTE);
            this.Controls.Add(this.txtTitIncAMT);
            this.Controls.Add(this.txtTotCommAMT);
            this.Controls.Add(this.txtLogAMT);
            this.Controls.Add(this.txtBaseRTE);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtYOS);
            this.Controls.Add(this.txtSlsAmnt);
            this.Controls.Add(this.txtSlsPrsn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commission Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSlsPrsn;
        private System.Windows.Forms.TextBox txtSlsAmnt;
        private System.Windows.Forms.TextBox txtYOS;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBaseRTE;
        private System.Windows.Forms.TextBox txtLogAMT;
        private System.Windows.Forms.TextBox txtTotCommAMT;
        private System.Windows.Forms.TextBox txtTitIncAMT;
        private System.Windows.Forms.TextBox txtTotCommRTE;
        private System.Windows.Forms.TextBox txtTitIncRTE;
        private System.Windows.Forms.TextBox txtLogRTE;
        private System.Windows.Forms.TextBox txtBaseAMT;
    }
}


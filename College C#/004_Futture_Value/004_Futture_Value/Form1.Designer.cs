namespace _004_Futture_Value
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonInv = new System.Windows.Forms.TextBox();
            this.txtYrsRte = new System.Windows.Forms.TextBox();
            this.txtNumYrs = new System.Windows.Forms.TextBox();
            this.txtFutVal = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Years:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Future Value:";
            // 
            // txtMonInv
            // 
            this.txtMonInv.Location = new System.Drawing.Point(172, 31);
            this.txtMonInv.Name = "txtMonInv";
            this.txtMonInv.Size = new System.Drawing.Size(100, 20);
            this.txtMonInv.TabIndex = 4;
            // 
            // txtYrsRte
            // 
            this.txtYrsRte.Location = new System.Drawing.Point(172, 66);
            this.txtYrsRte.Name = "txtYrsRte";
            this.txtYrsRte.Size = new System.Drawing.Size(100, 20);
            this.txtYrsRte.TabIndex = 5;
            // 
            // txtNumYrs
            // 
            this.txtNumYrs.Location = new System.Drawing.Point(172, 101);
            this.txtNumYrs.Name = "txtNumYrs";
            this.txtNumYrs.Size = new System.Drawing.Size(100, 20);
            this.txtNumYrs.TabIndex = 6;
            // 
            // txtFutVal
            // 
            this.txtFutVal.Location = new System.Drawing.Point(172, 136);
            this.txtFutVal.Name = "txtFutVal";
            this.txtFutVal.ReadOnly = true;
            this.txtFutVal.Size = new System.Drawing.Size(100, 20);
            this.txtFutVal.TabIndex = 7;
            this.txtFutVal.TabStop = false;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(15, 218);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 8;
            this.btnCal.Text = "&Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(195, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(105, 218);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(75, 23);
            this.btnCls.TabIndex = 10;
            this.btnCls.Text = "Clear";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(87, 172);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(111, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "No more than 5 years.";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtFutVal);
            this.Controls.Add(this.txtNumYrs);
            this.Controls.Add(this.txtYrsRte);
            this.Controls.Add(this.txtMonInv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonInv;
        private System.Windows.Forms.TextBox txtYrsRte;
        private System.Windows.Forms.TextBox txtNumYrs;
        private System.Windows.Forms.TextBox txtFutVal;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Label lblError;
    }
}


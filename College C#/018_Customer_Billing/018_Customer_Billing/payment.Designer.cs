namespace _018_Customer_Billing
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCredit = new System.Windows.Forms.RadioButton();
            this.rdoBill = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExpMo = new System.Windows.Forms.ComboBox();
            this.cboExpYr = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCredit);
            this.groupBox1.Controls.Add(this.rdoBill);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoCredit
            // 
            this.rdoCredit.AutoSize = true;
            this.rdoCredit.Checked = true;
            this.rdoCredit.Location = new System.Drawing.Point(46, 19);
            this.rdoCredit.Name = "rdoCredit";
            this.rdoCredit.Size = new System.Drawing.Size(77, 17);
            this.rdoCredit.TabIndex = 1;
            this.rdoCredit.TabStop = true;
            this.rdoCredit.Text = "Credit Card";
            this.rdoCredit.UseVisualStyleBackColor = true;
            this.rdoCredit.CheckedChanged += new System.EventHandler(this.rdoCredit_CheckedChanged);
            // 
            // rdoBill
            // 
            this.rdoBill.AutoSize = true;
            this.rdoBill.Location = new System.Drawing.Point(182, 19);
            this.rdoBill.Name = "rdoBill";
            this.rdoBill.Size = new System.Drawing.Size(85, 17);
            this.rdoBill.TabIndex = 2;
            this.rdoBill.Text = "Bill Customer";
            this.rdoBill.UseVisualStyleBackColor = true;
            this.rdoBill.CheckedChanged += new System.EventHandler(this.rdoBill_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit Card Type:";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.Location = new System.Drawing.Point(102, 82);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(222, 56);
            this.lstCreditCardType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card Number:";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(102, 145);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(222, 20);
            this.txtCardNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration Date:";
            // 
            // cboExpMo
            // 
            this.cboExpMo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpMo.FormattingEnabled = true;
            this.cboExpMo.Location = new System.Drawing.Point(102, 172);
            this.cboExpMo.Name = "cboExpMo";
            this.cboExpMo.Size = new System.Drawing.Size(105, 21);
            this.cboExpMo.TabIndex = 6;
            // 
            // cboExpYr
            // 
            this.cboExpYr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpYr.FormattingEnabled = true;
            this.cboExpYr.Location = new System.Drawing.Point(219, 173);
            this.cboExpYr.Name = "cboExpYr";
            this.cboExpYr.Size = new System.Drawing.Size(105, 21);
            this.cboExpYr.TabIndex = 7;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(13, 204);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(158, 17);
            this.chkDefault.TabIndex = 8;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(51, 236);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(176, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // payment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(336, 276);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboExpYr);
            this.Controls.Add(this.cboExpMo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.payment_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCredit;
        private System.Windows.Forms.RadioButton rdoBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboExpMo;
        private System.Windows.Forms.ComboBox cboExpYr;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
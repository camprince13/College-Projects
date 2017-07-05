namespace _001_Enhanced
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntSub = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtDisPer = new System.Windows.Forms.TextBox();
            this.txtDisAmo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumInv = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotInv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvAvg = new System.Windows.Forms.TextBox();
            this.btnTotals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter &Subtotal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtotal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Percent";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEntSub
            // 
            this.txtEntSub.Location = new System.Drawing.Point(131, 28);
            this.txtEntSub.Name = "txtEntSub";
            this.txtEntSub.Size = new System.Drawing.Size(100, 20);
            this.txtEntSub.TabIndex = 5;
            this.txtEntSub.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(131, 60);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(100, 20);
            this.txtSub.TabIndex = 6;
            this.txtSub.TabStop = false;
            // 
            // txtDisPer
            // 
            this.txtDisPer.Location = new System.Drawing.Point(131, 92);
            this.txtDisPer.Name = "txtDisPer";
            this.txtDisPer.ReadOnly = true;
            this.txtDisPer.Size = new System.Drawing.Size(100, 20);
            this.txtDisPer.TabIndex = 7;
            this.txtDisPer.TabStop = false;
            // 
            // txtDisAmo
            // 
            this.txtDisAmo.Location = new System.Drawing.Point(131, 124);
            this.txtDisAmo.Name = "txtDisAmo";
            this.txtDisAmo.ReadOnly = true;
            this.txtDisAmo.Size = new System.Drawing.Size(100, 20);
            this.txtDisAmo.TabIndex = 8;
            this.txtDisAmo.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(131, 156);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of invoices";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumInv
            // 
            this.txtNumInv.Location = new System.Drawing.Point(412, 60);
            this.txtNumInv.Name = "txtNumInv";
            this.txtNumInv.ReadOnly = true;
            this.txtNumInv.Size = new System.Drawing.Size(100, 20);
            this.txtNumInv.TabIndex = 11;
            this.txtNumInv.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 219);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total of invoices:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotInv
            // 
            this.txtTotInv.Location = new System.Drawing.Point(412, 92);
            this.txtTotInv.Name = "txtTotInv";
            this.txtTotInv.ReadOnly = true;
            this.txtTotInv.Size = new System.Drawing.Size(100, 20);
            this.txtTotInv.TabIndex = 14;
            this.txtTotInv.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Invoice average:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvAvg
            // 
            this.txtInvAvg.Location = new System.Drawing.Point(412, 124);
            this.txtInvAvg.Name = "txtInvAvg";
            this.txtInvAvg.ReadOnly = true;
            this.txtInvAvg.Size = new System.Drawing.Size(100, 20);
            this.txtInvAvg.TabIndex = 16;
            this.txtInvAvg.TabStop = false;
            // 
            // btnTotals
            // 
            this.btnTotals.Location = new System.Drawing.Point(220, 219);
            this.btnTotals.Name = "btnTotals";
            this.btnTotals.Size = new System.Drawing.Size(75, 23);
            this.btnTotals.TabIndex = 17;
            this.btnTotals.Text = "Clear &Totals";
            this.btnTotals.UseVisualStyleBackColor = true;
            this.btnTotals.Click += new System.EventHandler(this.btnTotals_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(365, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(535, 282);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotals);
            this.Controls.Add(this.txtInvAvg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotInv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumInv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDisAmo);
            this.Controls.Add(this.txtDisPer);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtEntSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total Enhanced";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntSub;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtDisPer;
        private System.Windows.Forms.TextBox txtDisAmo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumInv;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotInv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvAvg;
        private System.Windows.Forms.Button btnTotals;
        private System.Windows.Forms.Button btnExit;
    }
}


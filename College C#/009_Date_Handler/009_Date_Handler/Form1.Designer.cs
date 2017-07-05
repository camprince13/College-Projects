namespace _009_Date_Handler
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
            this.txtFuture = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalDue = new System.Windows.Forms.Button();
            this.btnCalAge = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFuture
            // 
            this.txtFuture.Location = new System.Drawing.Point(134, 28);
            this.txtFuture.Name = "txtFuture";
            this.txtFuture.Size = new System.Drawing.Size(100, 20);
            this.txtFuture.TabIndex = 0;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(134, 62);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(100, 20);
            this.txtBirth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a future date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a birth date:";
            // 
            // btnCalDue
            // 
            this.btnCalDue.Location = new System.Drawing.Point(261, 5);
            this.btnCalDue.Name = "btnCalDue";
            this.btnCalDue.Size = new System.Drawing.Size(124, 23);
            this.btnCalDue.TabIndex = 4;
            this.btnCalDue.Text = "Calculate Due Date";
            this.btnCalDue.UseVisualStyleBackColor = true;
            this.btnCalDue.Click += new System.EventHandler(this.btnCalDue_Click);
            // 
            // btnCalAge
            // 
            this.btnCalAge.Location = new System.Drawing.Point(261, 40);
            this.btnCalAge.Name = "btnCalAge";
            this.btnCalAge.Size = new System.Drawing.Size(124, 23);
            this.btnCalAge.TabIndex = 5;
            this.btnCalAge.Text = "Calculate Age";
            this.btnCalAge.UseVisualStyleBackColor = true;
            this.btnCalAge.Click += new System.EventHandler(this.btnCalAge_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(261, 75);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 110);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalAge);
            this.Controls.Add(this.btnCalDue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtFuture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuture;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalDue;
        private System.Windows.Forms.Button btnCalAge;
        private System.Windows.Forms.Button btnExit;
    }
}


namespace _016_Pig_Latin
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
            this.txtField = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Text";
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(13, 40);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(259, 20);
            this.txtField.TabIndex = 1;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(21, 79);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(111, 23);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "Convert to Pig-Latin";
            this.btnCon.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 79);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pig-Latin Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnExit;
    }
}


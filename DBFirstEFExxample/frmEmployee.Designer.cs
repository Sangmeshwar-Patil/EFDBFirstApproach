namespace DBFirstEFExxample
{
    partial class frmEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeNameTextBOx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeAge = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GenderTextBox);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.EmployeeAge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmployeeNameTextBOx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 341);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // EmployeeNameTextBOx
            // 
            this.EmployeeNameTextBOx.Location = new System.Drawing.Point(231, 27);
            this.EmployeeNameTextBOx.Name = "EmployeeNameTextBOx";
            this.EmployeeNameTextBOx.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextBOx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.Location = new System.Drawing.Point(231, 86);
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.Size = new System.Drawing.Size(100, 20);
            this.EmployeeAge.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(169, 197);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(78, 134);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender";
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(231, 131);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenderTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox EmployeeAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmployeeNameTextBOx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.Label Gender;
    }
}


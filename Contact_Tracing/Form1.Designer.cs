
namespace Contact_Tracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Save = new System.Windows.Forms.Button();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.RadioButton_Male = new System.Windows.Forms.RadioButton();
            this.RadioButton_Female = new System.Windows.Forms.RadioButton();
            this.TextBox_Age = new System.Windows.Forms.TextBox();
            this.TextBox_Birthdate = new System.Windows.Forms.TextBox();
            this.TextBox_City = new System.Windows.Forms.TextBox();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.Label_Gender = new System.Windows.Forms.Label();
            this.Label_Birthdate = new System.Windows.Forms.Label();
            this.Label_Age = new System.Windows.Forms.Label();
            this.Label_MiddleName = new System.Windows.Forms.Label();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.TextBox_MiddleName = new System.Windows.Forms.TextBox();
            this.TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.Label_Brgy = new System.Windows.Forms.Label();
            this.Label_Municipality = new System.Windows.Forms.Label();
            this.Label_City = new System.Windows.Forms.Label();
            this.Label_Address = new System.Windows.Forms.Label();
            this.TextBox_Street = new System.Windows.Forms.TextBox();
            this.TextBox_Municipality = new System.Windows.Forms.TextBox();
            this.TextBox_Brgy = new System.Windows.Forms.TextBox();
            this.Label_Street = new System.Windows.Forms.Label();
            this.Label_ContactNumber = new System.Windows.Forms.Label();
            this.TextBox_ContactNumber = new System.Windows.Forms.TextBox();
            this.Label_Reminder2 = new System.Windows.Forms.Label();
            this.Label_Reminder1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Save.Location = new System.Drawing.Point(226, 250);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(130, 50);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.ButtonClick_Save);
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Location = new System.Drawing.Point(88, 49);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(155, 23);
            this.TextBox_LastName.TabIndex = 1;
            this.TextBox_LastName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // RadioButton_Male
            // 
            this.RadioButton_Male.AutoSize = true;
            this.RadioButton_Male.Location = new System.Drawing.Point(398, 88);
            this.RadioButton_Male.Name = "RadioButton_Male";
            this.RadioButton_Male.Size = new System.Drawing.Size(51, 19);
            this.RadioButton_Male.TabIndex = 6;
            this.RadioButton_Male.TabStop = true;
            this.RadioButton_Male.Text = "Male";
            this.RadioButton_Male.UseVisualStyleBackColor = true;
            this.RadioButton_Male.CheckedChanged += new System.EventHandler(this.RadioButton_Male_CheckedChanged);
            // 
            // RadioButton_Female
            // 
            this.RadioButton_Female.AutoSize = true;
            this.RadioButton_Female.Location = new System.Drawing.Point(455, 88);
            this.RadioButton_Female.Name = "RadioButton_Female";
            this.RadioButton_Female.Size = new System.Drawing.Size(63, 19);
            this.RadioButton_Female.TabIndex = 8;
            this.RadioButton_Female.TabStop = true;
            this.RadioButton_Female.Text = "Female";
            this.RadioButton_Female.UseVisualStyleBackColor = true;
            this.RadioButton_Female.CheckedChanged += new System.EventHandler(this.RadioButton_Female_CheckedChanged);
            // 
            // TextBox_Age
            // 
            this.TextBox_Age.Location = new System.Drawing.Point(53, 87);
            this.TextBox_Age.Name = "TextBox_Age";
            this.TextBox_Age.Size = new System.Drawing.Size(59, 23);
            this.TextBox_Age.TabIndex = 9;
            // 
            // TextBox_Birthdate
            // 
            this.TextBox_Birthdate.Location = new System.Drawing.Point(192, 87);
            this.TextBox_Birthdate.Name = "TextBox_Birthdate";
            this.TextBox_Birthdate.Size = new System.Drawing.Size(127, 23);
            this.TextBox_Birthdate.TabIndex = 10;
            // 
            // TextBox_City
            // 
            this.TextBox_City.Location = new System.Drawing.Point(118, 123);
            this.TextBox_City.Name = "TextBox_City";
            this.TextBox_City.Size = new System.Drawing.Size(155, 23);
            this.TextBox_City.TabIndex = 11;
            // 
            // Button_Next
            // 
            this.Button_Next.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Next.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Next.Location = new System.Drawing.Point(388, 250);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(130, 50);
            this.Button_Next.TabIndex = 12;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = false;
            this.Button_Next.Click += new System.EventHandler(this.ButtonClick_Next);
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Location = new System.Drawing.Point(19, 52);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(63, 15);
            this.Label_LastName.TabIndex = 13;
            this.Label_LastName.Text = "Last Name";
            // 
            // Label_Gender
            // 
            this.Label_Gender.AutoSize = true;
            this.Label_Gender.Location = new System.Drawing.Point(347, 90);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(45, 15);
            this.Label_Gender.TabIndex = 14;
            this.Label_Gender.Text = "Gender";
            // 
            // Label_Birthdate
            // 
            this.Label_Birthdate.AutoSize = true;
            this.Label_Birthdate.Location = new System.Drawing.Point(131, 90);
            this.Label_Birthdate.Name = "Label_Birthdate";
            this.Label_Birthdate.Size = new System.Drawing.Size(55, 15);
            this.Label_Birthdate.TabIndex = 15;
            this.Label_Birthdate.Text = "Birthdate";
            // 
            // Label_Age
            // 
            this.Label_Age.AutoSize = true;
            this.Label_Age.Location = new System.Drawing.Point(19, 90);
            this.Label_Age.Name = "Label_Age";
            this.Label_Age.Size = new System.Drawing.Size(28, 15);
            this.Label_Age.TabIndex = 16;
            this.Label_Age.Text = "Age";
            // 
            // Label_MiddleName
            // 
            this.Label_MiddleName.AutoSize = true;
            this.Label_MiddleName.Location = new System.Drawing.Point(533, 52);
            this.Label_MiddleName.Name = "Label_MiddleName";
            this.Label_MiddleName.Size = new System.Drawing.Size(79, 15);
            this.Label_MiddleName.TabIndex = 17;
            this.Label_MiddleName.Text = "Middle Name";
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.AutoSize = true;
            this.Label_FirstName.Location = new System.Drawing.Point(277, 52);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(64, 15);
            this.Label_FirstName.TabIndex = 18;
            this.Label_FirstName.Text = "First Name";
            // 
            // TextBox_MiddleName
            // 
            this.TextBox_MiddleName.Location = new System.Drawing.Point(618, 49);
            this.TextBox_MiddleName.Name = "TextBox_MiddleName";
            this.TextBox_MiddleName.Size = new System.Drawing.Size(155, 23);
            this.TextBox_MiddleName.TabIndex = 19;
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.Location = new System.Drawing.Point(347, 49);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.Size = new System.Drawing.Size(155, 23);
            this.TextBox_FirstName.TabIndex = 20;
            // 
            // Label_Brgy
            // 
            this.Label_Brgy.AutoSize = true;
            this.Label_Brgy.Location = new System.Drawing.Point(486, 149);
            this.Label_Brgy.Name = "Label_Brgy";
            this.Label_Brgy.Size = new System.Drawing.Size(56, 15);
            this.Label_Brgy.TabIndex = 21;
            this.Label_Brgy.Text = "Barangay";
            // 
            // Label_Municipality
            // 
            this.Label_Municipality.AutoSize = true;
            this.Label_Municipality.Location = new System.Drawing.Point(317, 149);
            this.Label_Municipality.Name = "Label_Municipality";
            this.Label_Municipality.Size = new System.Drawing.Size(73, 15);
            this.Label_Municipality.TabIndex = 22;
            this.Label_Municipality.Text = "Municipality";
            // 
            // Label_City
            // 
            this.Label_City.AutoSize = true;
            this.Label_City.Location = new System.Drawing.Point(155, 149);
            this.Label_City.Name = "Label_City";
            this.Label_City.Size = new System.Drawing.Size(79, 15);
            this.Label_City.TabIndex = 23;
            this.Label_City.Text = "City/Province";
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.Location = new System.Drawing.Point(20, 126);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(92, 15);
            this.Label_Address.TabIndex = 24;
            this.Label_Address.Text = "Current Address";
            // 
            // TextBox_Street
            // 
            this.TextBox_Street.Location = new System.Drawing.Point(599, 123);
            this.TextBox_Street.Name = "TextBox_Street";
            this.TextBox_Street.Size = new System.Drawing.Size(174, 23);
            this.TextBox_Street.TabIndex = 25;
            // 
            // TextBox_Municipality
            // 
            this.TextBox_Municipality.Location = new System.Drawing.Point(277, 123);
            this.TextBox_Municipality.Name = "TextBox_Municipality";
            this.TextBox_Municipality.Size = new System.Drawing.Size(155, 23);
            this.TextBox_Municipality.TabIndex = 26;
            // 
            // TextBox_Brgy
            // 
            this.TextBox_Brgy.Location = new System.Drawing.Point(438, 123);
            this.TextBox_Brgy.Name = "TextBox_Brgy";
            this.TextBox_Brgy.Size = new System.Drawing.Size(155, 23);
            this.TextBox_Brgy.TabIndex = 27;
            // 
            // Label_Street
            // 
            this.Label_Street.AutoSize = true;
            this.Label_Street.Location = new System.Drawing.Point(642, 149);
            this.Label_Street.Name = "Label_Street";
            this.Label_Street.Size = new System.Drawing.Size(86, 15);
            this.Label_Street.TabIndex = 28;
            this.Label_Street.Text = "Street/Building";
            // 
            // Label_ContactNumber
            // 
            this.Label_ContactNumber.AutoSize = true;
            this.Label_ContactNumber.Location = new System.Drawing.Point(548, 90);
            this.Label_ContactNumber.Name = "Label_ContactNumber";
            this.Label_ContactNumber.Size = new System.Drawing.Size(96, 15);
            this.Label_ContactNumber.TabIndex = 29;
            this.Label_ContactNumber.Text = "Contact Number";
            // 
            // TextBox_ContactNumber
            // 
            this.TextBox_ContactNumber.Location = new System.Drawing.Point(646, 87);
            this.TextBox_ContactNumber.Name = "TextBox_ContactNumber";
            this.TextBox_ContactNumber.Size = new System.Drawing.Size(127, 23);
            this.TextBox_ContactNumber.TabIndex = 30;
            // 
            // Label_Reminder2
            // 
            this.Label_Reminder2.AutoSize = true;
            this.Label_Reminder2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Reminder2.Location = new System.Drawing.Point(17, 195);
            this.Label_Reminder2.Name = "Label_Reminder2";
            this.Label_Reminder2.Size = new System.Drawing.Size(399, 21);
            this.Label_Reminder2.TabIndex = 31;
            this.Label_Reminder2.Text = "Review your information first, then Save, then click Next.";
            // 
            // Label_Reminder1
            // 
            this.Label_Reminder1.AutoSize = true;
            this.Label_Reminder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Reminder1.Location = new System.Drawing.Point(20, 9);
            this.Label_Reminder1.Name = "Label_Reminder1";
            this.Label_Reminder1.Size = new System.Drawing.Size(190, 21);
            this.Label_Reminder1.TabIndex = 32;
            this.Label_Reminder1.Text = "Fill out the form correctly!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 321);
            this.Controls.Add(this.Label_Reminder1);
            this.Controls.Add(this.Label_Reminder2);
            this.Controls.Add(this.TextBox_ContactNumber);
            this.Controls.Add(this.Label_ContactNumber);
            this.Controls.Add(this.Label_Street);
            this.Controls.Add(this.TextBox_Brgy);
            this.Controls.Add(this.TextBox_Municipality);
            this.Controls.Add(this.TextBox_Street);
            this.Controls.Add(this.Label_Address);
            this.Controls.Add(this.Label_City);
            this.Controls.Add(this.Label_Municipality);
            this.Controls.Add(this.Label_Brgy);
            this.Controls.Add(this.TextBox_FirstName);
            this.Controls.Add(this.TextBox_MiddleName);
            this.Controls.Add(this.Label_FirstName);
            this.Controls.Add(this.Label_MiddleName);
            this.Controls.Add(this.Label_Age);
            this.Controls.Add(this.Label_Birthdate);
            this.Controls.Add(this.Label_Gender);
            this.Controls.Add(this.Label_LastName);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.TextBox_City);
            this.Controls.Add(this.TextBox_Birthdate);
            this.Controls.Add(this.TextBox_Age);
            this.Controls.Add(this.RadioButton_Female);
            this.Controls.Add(this.RadioButton_Male);
            this.Controls.Add(this.TextBox_LastName);
            this.Controls.Add(this.Button_Save);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.RadioButton RadioButton_Male;
        private System.Windows.Forms.RadioButton RadioButton_Female;
        private System.Windows.Forms.TextBox TextBox_Age;
        private System.Windows.Forms.TextBox TextBox_Birthdate;
        private System.Windows.Forms.TextBox TextBox_City;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.Label Label_Gender;
        private System.Windows.Forms.Label Label_Birthdate;
        private System.Windows.Forms.Label Label_Age;
        private System.Windows.Forms.Label Label_MiddleName;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.TextBox TextBox_MiddleName;
        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.Label Label_Brgy;
        private System.Windows.Forms.Label Label_Municipality;
        private System.Windows.Forms.Label Label_City;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.TextBox TextBox_Street;
        private System.Windows.Forms.TextBox TextBox_Municipality;
        private System.Windows.Forms.TextBox TextBox_Brgy;
        private System.Windows.Forms.Label Label_Street;
        private System.Windows.Forms.Label Label_ContactNumber;
        private System.Windows.Forms.TextBox TextBox_ContactNumber;
        private System.Windows.Forms.Label Label_Reminder2;
        private System.Windows.Forms.Label Label_Reminder1;
    }
}


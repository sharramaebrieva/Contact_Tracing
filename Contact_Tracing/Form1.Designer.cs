
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
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Button_Name = new System.Windows.Forms.Button();
            this.Button_Birthdate = new System.Windows.Forms.Button();
            this.Button_Address = new System.Windows.Forms.Button();
            this.Button_Age = new System.Windows.Forms.Button();
            this.RadioButton_Male = new System.Windows.Forms.RadioButton();
            this.Button_Gender = new System.Windows.Forms.Button();
            this.RadioButton_Female = new System.Windows.Forms.RadioButton();
            this.TextBox_Age = new System.Windows.Forms.TextBox();
            this.TextBox_Birthdate = new System.Windows.Forms.TextBox();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.Button_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(53, 232);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(134, 50);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save Information";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.ButtonClick_Save);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(85, 12);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(115, 23);
            this.TextBox_Name.TabIndex = 1;
            this.TextBox_Name.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // Button_Name
            // 
            this.Button_Name.Location = new System.Drawing.Point(8, 12);
            this.Button_Name.Name = "Button_Name";
            this.Button_Name.Size = new System.Drawing.Size(71, 23);
            this.Button_Name.TabIndex = 2;
            this.Button_Name.Text = "Name";
            this.Button_Name.UseVisualStyleBackColor = true;
            // 
            // Button_Birthdate
            // 
            this.Button_Birthdate.Location = new System.Drawing.Point(8, 108);
            this.Button_Birthdate.Name = "Button_Birthdate";
            this.Button_Birthdate.Size = new System.Drawing.Size(71, 23);
            this.Button_Birthdate.TabIndex = 3;
            this.Button_Birthdate.Text = "Birthdate";
            this.Button_Birthdate.UseVisualStyleBackColor = true;
            // 
            // Button_Address
            // 
            this.Button_Address.Location = new System.Drawing.Point(8, 79);
            this.Button_Address.Name = "Button_Address";
            this.Button_Address.Size = new System.Drawing.Size(107, 23);
            this.Button_Address.TabIndex = 4;
            this.Button_Address.Text = "Current Address";
            this.Button_Address.UseVisualStyleBackColor = true;
            // 
            // Button_Age
            // 
            this.Button_Age.Location = new System.Drawing.Point(8, 50);
            this.Button_Age.Name = "Button_Age";
            this.Button_Age.Size = new System.Drawing.Size(71, 23);
            this.Button_Age.TabIndex = 5;
            this.Button_Age.Text = "Age";
            this.Button_Age.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Male
            // 
            this.RadioButton_Male.AutoSize = true;
            this.RadioButton_Male.Location = new System.Drawing.Point(102, 139);
            this.RadioButton_Male.Name = "RadioButton_Male";
            this.RadioButton_Male.Size = new System.Drawing.Size(51, 19);
            this.RadioButton_Male.TabIndex = 6;
            this.RadioButton_Male.TabStop = true;
            this.RadioButton_Male.Text = "Male";
            this.RadioButton_Male.UseVisualStyleBackColor = true;
            this.RadioButton_Male.CheckedChanged += new System.EventHandler(this.RadioButton_Male_CheckedChanged);
            // 
            // Button_Gender
            // 
            this.Button_Gender.Location = new System.Drawing.Point(8, 137);
            this.Button_Gender.Name = "Button_Gender";
            this.Button_Gender.Size = new System.Drawing.Size(71, 23);
            this.Button_Gender.TabIndex = 7;
            this.Button_Gender.Text = "Gender";
            this.Button_Gender.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Female
            // 
            this.RadioButton_Female.AutoSize = true;
            this.RadioButton_Female.Location = new System.Drawing.Point(172, 141);
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
            this.TextBox_Age.Location = new System.Drawing.Point(102, 50);
            this.TextBox_Age.Name = "TextBox_Age";
            this.TextBox_Age.Size = new System.Drawing.Size(115, 23);
            this.TextBox_Age.TabIndex = 9;
            // 
            // TextBox_Birthdate
            // 
            this.TextBox_Birthdate.Location = new System.Drawing.Point(120, 108);
            this.TextBox_Birthdate.Name = "TextBox_Birthdate";
            this.TextBox_Birthdate.Size = new System.Drawing.Size(115, 23);
            this.TextBox_Birthdate.TabIndex = 10;
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.Location = new System.Drawing.Point(144, 79);
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(115, 23);
            this.TextBox_Address.TabIndex = 11;
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(301, 227);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(127, 73);
            this.Button_Next.TabIndex = 12;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.ButtonClick_Next);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.TextBox_Birthdate);
            this.Controls.Add(this.TextBox_Age);
            this.Controls.Add(this.RadioButton_Female);
            this.Controls.Add(this.Button_Gender);
            this.Controls.Add(this.RadioButton_Male);
            this.Controls.Add(this.Button_Age);
            this.Controls.Add(this.Button_Address);
            this.Controls.Add(this.Button_Birthdate);
            this.Controls.Add(this.Button_Name);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Button_Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Name;
        private System.Windows.Forms.Button Button_Birthdate;
        private System.Windows.Forms.Button Button_Address;
        private System.Windows.Forms.Button Button_Age;
        private System.Windows.Forms.RadioButton RadioButton_Male;
        private System.Windows.Forms.Button Button_Gender;
        private System.Windows.Forms.RadioButton RadioButton_Female;
        private System.Windows.Forms.TextBox TextBox_Age;
        private System.Windows.Forms.TextBox TextBox_Birthdate;
        private System.Windows.Forms.TextBox TextBox_Address;
        private System.Windows.Forms.Button Button_Next;
    }
}

